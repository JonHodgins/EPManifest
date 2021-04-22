using EPManifest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public State State { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Unit Unit { get; set; }
    }
}