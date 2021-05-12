using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public class Item
    {
        public Item(State state, string description, int quantity, Unit unit)
        {
            State = state;
            Description = description;
            Quantity = quantity;
            Unit = unit;
        }

        private Item()
        {
        }

        public int Id { get; set; }

        [Required]
        public State State { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public Unit Unit { get; set; }

        public Manifest Manifest { get; set; }
        public int ManifestId { get; set; }
    }
}
