using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Core;

namespace EPManifest.Reports.Data
{
    public class ManifestModel
    {
        public byte[] LogoData { get; set; }

        public string Code { get; set; }

        public DateTime? DateShipped { get; set; }

        public DateTime? DateScheduledArrival { get; set; }

        public List<Consignor> Consignors { get; set; } = new List<Consignor>();

        public Consignee Consignee { get; set; }

        public Carrier Carrier { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();

        public Address ConsignorAddress { get; set; }

        public Address ConsigneeAddress { get; set; }
    }
}
