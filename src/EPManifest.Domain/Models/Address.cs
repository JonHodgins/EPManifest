using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Core
{
    public class Address
    {
        public int Id { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        //[RegularExpression(@"^[ABCEGHJ-NPRSTVXY]\d[ABCEGHJ-NPRSTV-Z][ -]?\d[ABCEGHJ-NPRSTV-Z]\d$", ErrorMessage = "Postal Codes must be formatted as: X1X-1X1 or X1X 1X1")]
        public string PostalCode { get; set; }

        public Company Company { get; set; } = default!;
        public int CompanyId { get; set; }
    }
}