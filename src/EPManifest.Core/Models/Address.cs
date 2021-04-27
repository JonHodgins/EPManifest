using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Core
{
    public class Address
    {
        private Address()
        {
        }

        public Address(string addressLine1, string city, Provinces province, string postalCode, string addressLine2 = "", string phoneNumber = "")
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            Province = province;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
        }

        //public int Id { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public Provinces Province { get; set; }
        [Required]
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
    }

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
}