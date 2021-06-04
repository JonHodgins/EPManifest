using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public class Manifest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Date Shipped is required")]
        public DateTime? DateShipped { get; set; }

        public DateTime? DateScheduledArrival { get; set; }

        [ValidateComplexType, NotNullOrEmptyCollection(ErrorMessage = "Consignors is required")]
        public List<Consignor> Consignors { get; set; } = new List<Consignor>();

        [ValidateComplexType, Required(ErrorMessage = "Consignee is required")]
        public Consignee Consignee { get; set; }

        [ValidateComplexType, Required(ErrorMessage = "Carrier is required")]
        public Carrier Carrier { get; set; }

        [ValidateComplexType]
        public List<Item> Items { get; set; } = new List<Item>();

        public int ConsigneeId { get; set; }
        public int CarrierId { get; set; }

        [ValidateComplexType]
        public Address ConsignorAddress { get; set; }

        [ValidateComplexType]
        public Address ConsigneeAddress { get; set; }
    }
}
