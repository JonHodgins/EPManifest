﻿// <auto-generated />
using System;
using EPManifest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EPManifest.Data.Migrations
{
    [DbContext(typeof(EPManifestContext))]
    [Migration("20210423005507_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompanyManifest", b =>
                {
                    b.Property<int>("CompaniesId")
                        .HasColumnType("int");

                    b.Property<int>("ManifestsId")
                        .HasColumnType("int");

                    b.HasKey("CompaniesId", "ManifestsId");

                    b.HasIndex("ManifestsId");

                    b.ToTable("CompanyManifest");
                });

            modelBuilder.Entity("EPManifest.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EPManifest.Domain.Manifest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateScheduledArrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateShipped")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Manifests");
                });

            modelBuilder.Entity("CompanyManifest", b =>
                {
                    b.HasOne("EPManifest.Domain.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPManifest.Domain.Manifest", null)
                        .WithMany()
                        .HasForeignKey("ManifestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}