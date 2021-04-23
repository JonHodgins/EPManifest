using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Core;

namespace EPManifest.Data
{
    public interface IManifestData
    {
        IEnumerable<Manifest> GetManifestsByName(string name);

        Manifest GetManifestById(int id);

        Manifest Update(Manifest updatedManifest);

        Manifest Add(Manifest newManifest);

        int Commit();
    }
}