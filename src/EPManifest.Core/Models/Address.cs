using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public enum Provinces
    {
        [Display(Name = "Alberta")]
        AB,

        [Display(Name = "British Columbia")]
        BC,

        [Display(Name = "Manitoba")]
        MB,

        [Display(Name = "New Brunswick")]
        NB,

        [Display(Name = "Newfoundland and Labrador")]
        NL,

        [Display(Name = "Northwest Territories")]
        NT,

        [Display(Name = "Nova Scotia")]
        NS,

        [Display(Name = "Nunavut")]
        NU,

        [Display(Name = "Ontario")]
        ON,

        [Display(Name = "Prince Edward Island")]
        PE,

        [Display(Name = "Quebec")]
        QC,

        [Display(Name = "Saskatchewan")]
        SK,

        [Display(Name = "Yukon")]
        YT
    }

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
        [RegularExpression(@"^[ABCEGHJ-NPRSTVXY]\d[ABCEGHJ-NPRSTV-Z]\d[ABCEGHJ-NPRSTV-Z]\d$", ErrorMessage = "Postal Codes must be formatted as: X1X1X1")]
        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }
    }
}
