using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public State? State { get; set; }

        [Required(ErrorMessage = "Item description is required"), MinLength(1, ErrorMessage = "Item description is required")]
        public string Description { get; set; }

        [Required, Range(0.01, double.MaxValue, ErrorMessage = "Item quantity must be greater than zero")]
        public decimal Quantity { get; set; }

        [Required]
        public Unit? Unit { get; set; }

        public Manifest Manifest { get; set; }
        public int ManifestId { get; set; }
    }
}
