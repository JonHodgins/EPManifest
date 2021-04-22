using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Domain
{
    public class Manifest
    {
        public int Id { get; set; }
        public DateTime DateShipped { get; set; } = DateTime.Now;
        public DateTime DateScheduledArrival { get; set; } = DateTime.Today;

        public Company Consignor { get; set; }
        public Company Consignee { get; set; }
        public Company Carrier { get; set; }
        public Address ConsignorAddress { get; set; }
        public Address ConsigneeAddress { get; set; }
        public List<Item> Items { get; set; }
    }
}