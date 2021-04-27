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
        Manifest GetManifestById(int id);

        Manifest Update(Manifest updatedManifest);

        Manifest Add(Manifest newManifest);

        int Commit();
    }
}