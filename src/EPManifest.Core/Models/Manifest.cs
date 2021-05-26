using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public class Manifest
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public DateTime? DateShipped { get; set; }

        public DateTime? DateScheduledArrival { get; set; }

        [ValidateComplexType]
        public List<Consignor> Consignors { get; set; } = new List<Consignor>();

        [ValidateComplexType]
        public Consignee Consignee { get; set; }

        [ValidateComplexType]
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
