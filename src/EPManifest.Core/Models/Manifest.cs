using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public class Manifest
    {
        //public Manifest(DateTime dateShipped, Consignor consignor, Consignee consignee, Carrier carrier)
        //{
        //    DateShipped = dateShipped;
        //    Consignor = consignor;
        //    Consignee = consignee;
        //    Carrier = carrier;
        //}

        //private Manifest()
        //{
        //}

        public int Id { get; set; }

        [Required]
        public DateTime? DateShipped { get; set; }

        public DateTime? DateScheduledArrival { get; set; }

        public Consignor Consignor { get; set; }

        public Consignee Consignee { get; set; }

        public Carrier Carrier { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();

        public int ConsignorId { get; set; }
        public int ConsigneeId { get; set; }
        public int CarrierId { get; set; }

        public Address ConsignorAddress { get; set; }
        public Address ConsigneeAddress { get; set; }
    }
}
