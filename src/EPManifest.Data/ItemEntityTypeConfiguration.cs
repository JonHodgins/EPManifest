using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPManifest.Data
{
    internal class ItemEntityTypeConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(i => i.State).IsRequired().HasConversion<string>().HasMaxLength(6).IsUnicode(false);
            builder.Property(i => i.Description).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Quantity).IsRequired().HasPrecision(16, 2);
            builder.Property(i => i.Unit).IsRequired().HasConversion<string>().HasMaxLength(2).IsUnicode(false);
        }
    }
}
