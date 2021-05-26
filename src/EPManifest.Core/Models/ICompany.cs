using System.Collections.Generic;

namespace EPManifest.Core
{
    public interface ICompany
    {
        string Code { get; set; }
        int Id { get; set; }
        List<Manifest> Manifests { get; set; }
        string Name { get; set; }
    }
}