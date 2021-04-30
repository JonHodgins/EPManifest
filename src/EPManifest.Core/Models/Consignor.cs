using System.Collections.Generic;

namespace EPManifest.Core
{
    public class Consignor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Manifest> Manifests { get; set; } = new List<Manifest>();
    }
}
