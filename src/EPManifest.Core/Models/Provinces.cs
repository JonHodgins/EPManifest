using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public enum Provinces
    {
        [Display(Name = "Yukon")]
        YT,

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
        SK
    }
}
