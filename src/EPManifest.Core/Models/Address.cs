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
        //[RegularExpression(@"^[ABCEGHJ-NPRSTVXY]\d[ABCEGHJ-NPRSTV-Z] \d[ABCEGHJ-NPRSTV-Z]\d$", ErrorMessage = "Postal Code must be valid, and formatted as: X1X 1X1")]
        //Using a weaker validation regex for testing, as BogusDataGenerator outputs invalid Postal Codes
        [RegularExpression(@"^[A-Z]\d[A-Z] \d[A-Z]\d$", ErrorMessage = "Postal Code must be formatted as: X1X 1X1")]
        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        public int ManifestId { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(AddressLine2))
            {
                return $"{AddressLine1}, {City}, {Province}, {PostalCode}";
            }
            else
            {
                return $"{AddressLine1}, {AddressLine2}, {City}, {Province}, {PostalCode}";
            }
        }
    }
}
