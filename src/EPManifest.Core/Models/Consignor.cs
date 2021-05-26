using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EPManifest.Core
{
    public class Consignor
    {
        public int Id { get; set; }

        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Manifest> Manifests { get; set; } = new List<Manifest>();
    }
}
