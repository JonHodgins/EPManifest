using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPManifest.Data
{
    internal class ManifestEntityTypeConfiguration : IEntityTypeConfiguration<Manifest>
    {
        public void Configure(EntityTypeBuilder<Manifest> builder)
        {
            builder.OwnsOne(m => m.ConsignorAddress,
                a =>
                {
                    a.Property(a => a.AddressLine1).IsRequired().HasMaxLength(100);
                    a.Property(a => a.AddressLine2).HasMaxLength(100);
                    a.Property(a => a.City).IsRequired().HasMaxLength(50);
                    a.Property(a => a.Province).IsRequired().HasColumnType("char(2)");
                    a.Property(a => a.PostalCode).IsRequired().HasMaxLength(7).IsUnicode(false);
                    a.Property(a => a.PhoneNumber).HasMaxLength(10);
                    a.ToTable("ConsignorAddresses");
                }).OwnsOne(m => m.ConsigneeAddress,
                a =>
                {
                    a.Property(a => a.AddressLine1).IsRequired().HasMaxLength(100);
                    a.Property(a => a.AddressLine2).HasMaxLength(100);
                    a.Property(a => a.City).IsRequired().HasMaxLength(50);
                    a.Property(a => a.Province).IsRequired().HasColumnType("char(2)");
                    a.Property(a => a.PostalCode).IsRequired().HasMaxLength(7).IsUnicode(false);
                    a.Property(a => a.PhoneNumber).HasMaxLength(10);
                    a.ToTable("ConsigneeAddresses");
                });

            builder.Property(m => m.Code).IsRequired(false).HasMaxLength(20);

            builder.HasOne("EPManifest.Core.Consignee", "Consignee")
                        .WithMany("Manifests")
                        .HasForeignKey("ConsigneeId")
                        .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne("EPManifest.Core.Carrier", "Carrier")
                        .WithMany("Manifests")
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Consignors)
                .WithMany(c => c.Manifests)
                .UsingEntity<ConsignorManifest>(
                j => j
                .HasOne(mc => mc.Consignor)
                .WithMany(c => c.ConsignorManifests)
                .HasForeignKey(mc => mc.ConsignorId),
                j => j
                .HasOne(mc => mc.Manifest)
                .WithMany(c => c.ConsignorManifests)
                .HasForeignKey(mc => mc.ManifestId),
                j => j.HasKey(c => new { c.ManifestId, c.ConsignorId }));
        }
    }
}
