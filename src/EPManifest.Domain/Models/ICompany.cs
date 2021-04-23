using System.Collections.Generic;

namespace EPManifest.Core
{
    public interface ICompany
    {
        int Id { get; set; }
        string Name { get; set; }
        List<Manifest> Manifests { get; set; }
    }
}