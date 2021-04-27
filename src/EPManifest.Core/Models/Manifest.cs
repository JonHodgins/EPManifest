using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Core
{
    public class Manifest
    {
        private Manifest()
        {
        }

        public Manifest(DateTime dateShipped, Consignor consignor, Consignee consignee, Carrier carrier)
        {
            DateShipped = dateShipped;
            Consignor = consignor;
            Consignee = consignee;
            Carrier = carrier;
        }

        public int Id { get; set; }
        public DateTime DateShipped { get; set; }
        public DateTime? DateScheduledArrival { get; set; }
        public Consignor Consignor { get; set; }
        public Consignee Consignee { get; set; }
        public Carrier Carrier { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public Address ConsignorAddress { get; set; }
        public Address ConsigneeAddress { get; set; }
    }
}