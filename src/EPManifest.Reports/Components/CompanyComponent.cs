using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Reports.Data;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace EPManifest.Reports.Components
{
    public class CompanyComponent<T> : IComponent where T : ICompany
    {
        private string Title { get; }
        private ManifestModel Model { get; }

        public CompanyComponent(string title, ManifestModel model)
        {
            Title = title;
            Model = model;
        }

        public void Compose(IContainer container)
        {
            container.Stack(stack =>
            {
                stack.Spacing(5);

                stack.Item().BorderBottom(1).PaddingBottom(5).Text(Title);

                switch (typeof(T))
                {
                    case Type c when c == typeof(Carrier):
                        stack.Item().Text(Model.Carrier.Name);
                        break;

                    case Type c when c == typeof(Consignee):
                        stack.Item().Text(Model.Consignee.Name);
                        stack.Item().Text(Model.ConsigneeAddress.AddressLine1);
                        stack.Item().Text(Model.ConsigneeAddress.AddressLine2);
                        stack.Item().Text($"{Model.ConsigneeAddress.City}, {Model.ConsigneeAddress.Province}");
                        stack.Item().Text(Model.ConsigneeAddress.PostalCode);
                        break;

                    case Type c when c == typeof(Consignor):
                        stack.Item().Text(string.Join(", ", Model.Consignors.Select(c => c.Name)));
                        stack.Item().Text(Model.ConsignorAddress.AddressLine1);
                        stack.Item().Text(Model.ConsignorAddress.AddressLine2);
                        stack.Item().Text($"{Model.ConsignorAddress.City}, {Model.ConsignorAddress.Province}");
                        stack.Item().Text(Model.ConsignorAddress.PostalCode);
                        break;
                }
            });
        }
    }
}
