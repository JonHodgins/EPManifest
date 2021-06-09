using EPManifest.Data;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.Reports.Data
{
    public class DataSourceBase
    {
        protected DbContextOptions<EPManifestDbContext> ContextOptions { get; }

        protected DataSourceBase(DbContextOptions<EPManifestDbContext> contextOptions)
        {
            ContextOptions = contextOptions;
        }
    }
}
