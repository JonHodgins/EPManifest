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
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string PostalCode { get; set; }
        public int? ConsignorId { get; set; }
        public int? ConsigneeId { get; set; }
        public int? CarrierId { get; set; }

        public Consignor Consignor { get; set; }
        public Consignee Consignee { get; set; }
        public Carrier Carrier { get; set; }
    }
}