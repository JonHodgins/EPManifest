using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public class Address
    {
        [Required(ErrorMessage = "Address Line 1 is required"), MinLength(1)]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "City is required"), MinLength(1)]
        public string City { get; set; }

        [Required]
        public Provinces Province { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [RegularExpression(@"^[ABCEGHJ-NPRSTVXY]\d[ABCEGHJ-NPRSTV-Z] \d[ABCEGHJ-NPRSTV-Z]\d$", ErrorMessage = "Postal Code must be valid, and formatted as: X1X 1X1")]
        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        public int ManifestId { get; set; }
    }
}
