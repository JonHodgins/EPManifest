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
        public List<Company> Companies { get; set; } = new List<Company>();
        public List<Item> Items { get; set; } = new List<Item>();
    }
}