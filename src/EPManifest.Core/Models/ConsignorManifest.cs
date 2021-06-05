using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Core
{
    public class ConsignorManifest
    {
        public int ConsignorId { get; set; }
        public Consignor Consignor { get; set; }

        public int ManifestId { get; set; }
        public Manifest Manifest { get; set; }
    }
}
