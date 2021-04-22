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
        public DateTime DateShipped { get; set; }
        public DateTime DateScheduledArrival { get; set; }

        public Company Consignor { get; set; }
        public Company Consignee { get; set; }
        public Company Carrier { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}