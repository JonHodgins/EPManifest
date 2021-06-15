using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Reports.Components;
using EPManifest.Reports.Data;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace EPManifest.Reports.Templates
{
    public class ManifestDocument : IDocument
    {
        public ManifestModel Model { get; }

        public ManifestDocument(ManifestModel model)
        {
            Model = model;
        }

        public void Compose(IContainer container)
        {
            container
            .PaddingHorizontal(50)
            .PaddingVertical(50)
            .Page(page =>
            {
                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
        }

        private void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeColumn().Stack(stack =>
                {
                    stack.Item().Text($"Manifest: {Model.Code}", TextStyle.Default.Size(20));
                    stack.Item().Text($"Date Shipped: {Model.DateShipped:d}");
                    stack.Item().Text($"Scheduled Arrival: {Model.DateScheduledArrival:d}");
                });

                row.ConstantColumn(150).ExternalLink("https://www.yukon.ca").Image(Model.LogoData);
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Stack(stack =>
            {
                stack.Spacing(5);

                stack.Item().Element(ComposeBody);

                stack.Item().BorderBottom(1).PaddingBottom(2).Text("Items", TextStyle.Default.Size(15));

                stack.Item().Element(ComposeTable);
            });
        }

        private void ComposeBody(IContainer container)
        {
            container.PaddingVertical(40).Stack(stack =>
            {
                stack.Spacing(5);

                stack.Item().Row(row =>
                {
                    row.RelativeColumn().Component(new CompanyComponent<Consignor>("Consignor(s)", Model));
                    row.ConstantColumn(50);
                    row.RelativeColumn().Component(new CompanyComponent<Consignee>("Consignee", Model));
                    row.ConstantColumn(50);
                    row.RelativeColumn().Component(new CompanyComponent<Carrier>("Carrier", Model));
                });
            });
        }

        private void ComposeTable(IContainer container)
        {
            container.PaddingTop(10).Decoration(decoration =>
            {
                // header
                decoration.Header().BorderBottom(1).Padding(5).Row(row =>
                {
                    row.ConstantColumn(25).Text("#");
                    row.ConstantColumn(50).Text("State");
                    row.RelativeColumn().AlignLeft().Text("Description");
                    row.RelativeColumn().AlignRight().Text("Quantity");
                    row.ConstantColumn(20).AlignRight().Text("");
                });

                // content
                decoration
                    .Content()
                    .Stack(stack =>
                    {
                        foreach (var item in Model.Items)
                        {
                            stack.Item().BorderBottom(1).BorderColor("CCC").Padding(5).Row(row =>
                            {
                                row.ConstantColumn(25).Text(Model.Items.IndexOf(item) + 1);
                                row.ConstantColumn(50).Text(item.State);
                                row.RelativeColumn().AlignLeft().Text($"{item.Description}");
                                row.RelativeColumn().AlignRight().Text($"{item.Quantity:###,###,###,###.##}");
                                row.ConstantColumn(20).AlignRight().Text(item.Unit);
                            });
                        }
                    });
            });
        }

        private void ComposeFooter(IContainer container)
        {
            container.Background("#EEE").Padding(10).Stack(stack =>
            {
                stack.Spacing(5);
                stack.Item().Text("For more information, please contact the Environmental Protection and Assessment Branch at: 867-667-5683 or envprot@yukon.ca");
            });
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    }
}
