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
        public int Id { get; set; }
        public DateTime DateShipped { get; set; }
        public DateTime? DateScheduledArrival { get; set; }
        public Consignor Consignor { get; set; }
        public Consignee Consignee { get; set; }
        public Carrier Carrier { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}