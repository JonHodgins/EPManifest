using EPManifest.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Core
{
    public class Item
    {
        private Item()
        {
        }

        public Item(State state, string description, int quantity, Unit unit)
        {
            State = state;
            Description = description;
            Quantity = quantity;
            Unit = unit;
        }

        public int Id { get; set; }
        public State State { get; set; }
        [Required]
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Unit Unit { get; set; }

        public Manifest Manifest { get; set; }
        public int ManifestId { get; set; }
    }
}