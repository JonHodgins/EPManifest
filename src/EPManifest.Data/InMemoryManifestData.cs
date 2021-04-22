using EPManifest.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Data
{
    public class InMemoryManifestData : IManifestData
    {
        private List<Manifest> manifests;
        private List<Item> items;

        public InMemoryManifestData()
        {
            items = new List<Item> {
                new Item { Id = 1, State = State.Solid, Description = "Biological Substance", Quantity = 5, Unit = Unit.Kg },
                new Item { Id = 2, State = State.Liquid, Description = "Waste Leachate Oil", Quantity = 1000, Unit = Unit.L },
                new Item { Id = 3, State = State.Gas, Description = "Propane", Quantity = 450, Unit = Unit.L }
            };

            manifests = new List<Manifest>
            {
                new Manifest { Id = 1, Consignor = new Company { Id = 1, Name = "Teslin Health Centre" },
                    Consignee = new Company { Id = 2, Name = "KBL Environmental" },
                    Carrier = new Company { Id = 3, Name = "A-1 Delivery" },
                    ConsignorAddress = new Address { StreetNumber = 5, StreetName = "Alsek Road", City = "Whitehorse", Province = "Yukon", PostalCode = "Y1A 5X8" },
                    ConsigneeAddress = new Address { StreetNumber = 38, StreetName = "Range Road", City = "Whitehorse", Province = "Yukon", PostalCode = "Y1A 3M2" },
                    Items = new List<Item> { items[0], items[1] } },
                new Manifest { Id = 2, Consignor = new Company { Id = 4, Name = "Whitehorse General Hospital" },
                    Consignee = new Company { Id = 5, Name = "Raven Recycling" },
                    Carrier = new Company { Id = 6, Name = "A-1 Delivery" },
                    ConsignorAddress = new Address(),
                    ConsigneeAddress = new Address(),
                    Items = new List<Item> { items[2] } },
                new Manifest { Id = 3, Consignor = new Company { Id = 7, Name = "Teslin Health Centre" },
                    Consignee = new Company { Id = 8, Name = "Whitehorse General Hospital" },
                    Carrier = new Company { Id = 9, Name = "A-1 Delivery" },
                    ConsignorAddress = new Address(),
                    ConsigneeAddress = new Address(),
                    Items = new List<Item> { items[0], items[1] } },
                new Manifest { Id = 4, Consignor = new Company { Id = 10, Name = "Dawson Clinic" },
                    Consignee = new Company { Id = 11, Name = "KBL Environmental" },
                    Carrier = new Company { Id = 12, Name = "Purolator" },
                    ConsignorAddress = new Address(),
                    ConsigneeAddress = new Address(),
                    Items = new List<Item> { items[0], items[1], items[2] } },
                new Manifest { Id = 4, Consignor = new Company { Id = 10, Name = "Dawson Clinic" },
                    Consignee = new Company { Id = 11, Name = "KBL Environmental" },
                    Carrier = new Company { Id = 12, Name = "Purolator" },
                    ConsignorAddress = new Address(),
                    ConsigneeAddress = new Address(),
                    Items = new List<Item> { items[0], items[1], items[2] } },
                new Manifest { Id = 4, Consignor = new Company { Id = 10, Name = "Dawson Clinic" },
                    Consignee = new Company { Id = 11, Name = "KBL Environmental" },
                    Carrier = new Company { Id = 12, Name = "Purolator" },
                    ConsignorAddress = new Address(),
                    ConsigneeAddress = new Address(),
                    Items = new List<Item> { items[0], items[1], items[2] } },
                new Manifest { Id = 4, Consignor = new Company { Id = 10, Name = "Dawson Clinic" },
                    Consignee = new Company { Id = 11, Name = "KBL Environmental" },
                    Carrier = new Company { Id = 12, Name = "Purolator" },
                    ConsignorAddress = new Address(),
                    ConsigneeAddress = new Address(),
                    Items = new List<Item> { items[0], items[1], items[2] } },
                new Manifest { Id = 4, Consignor = new Company { Id = 10, Name = "Dawson Clinic" },
                    Consignee = new Company { Id = 11, Name = "KBL Environmental" },
                    Carrier = new Company { Id = 12, Name = "Purolator" },
                    ConsignorAddress = new Address(),
                    ConsigneeAddress = new Address(),
                    Items = new List<Item> { items[0], items[1], items[2] } },
            };
        }

        public Manifest Add(Manifest newManifest)
        {
            manifests.Add(newManifest);
            if (newManifest != null)
                newManifest.Id = manifests.Max(r => r.Id) + 1;
            return newManifest;
        }

        public int Commit()
        {
            return 0;
        }

        public Manifest GetManifestById(int id)
        {
            return manifests.SingleOrDefault(m => m.Id == id);
        }

        public IEnumerable<Manifest> GetManifestsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return manifests;
            }
            return manifests.Where(m => m.Consignor.Name.StartsWith(name, true, CultureInfo.InvariantCulture)
            || m.Consignee.Name.StartsWith(name, true, CultureInfo.InvariantCulture));
        }

        public Manifest Update(Manifest updatedManifest)
        {
            var manifest = manifests.SingleOrDefault(r => r.Id == updatedManifest.Id);
            if (manifest != null)
            {
                manifest.Consignor.Name = updatedManifest.Consignor.Name;
                manifest.ConsignorAddress.StreetNumber = updatedManifest.ConsignorAddress.StreetNumber;
                manifest.ConsignorAddress.StreetName = updatedManifest.ConsignorAddress.StreetName;
                manifest.ConsignorAddress.City = updatedManifest.ConsignorAddress.City;
                manifest.ConsignorAddress.Province = updatedManifest.ConsignorAddress.Province;
                manifest.ConsignorAddress.PostalCode = updatedManifest.ConsignorAddress.PostalCode;

                manifest.Consignee.Name = updatedManifest.Consignee.Name;
                manifest.ConsigneeAddress.StreetNumber = updatedManifest.ConsigneeAddress.StreetNumber;
                manifest.ConsigneeAddress.StreetName = updatedManifest.ConsigneeAddress.StreetName;
                manifest.ConsigneeAddress.City = updatedManifest.ConsigneeAddress.City;
                manifest.ConsigneeAddress.Province = updatedManifest.ConsigneeAddress.Province;
                manifest.ConsigneeAddress.PostalCode = updatedManifest.ConsigneeAddress.PostalCode;

                manifest.Carrier.Name = updatedManifest.Carrier.Name;
                for (int i = 0; i < updatedManifest.Items.Count; i++)
                {
                    manifest.Items[i].State = updatedManifest.Items[i].State;
                    manifest.Items[i].Description = updatedManifest.Items[i].Description;
                    manifest.Items[i].Quantity = updatedManifest.Items[i].Quantity;
                    manifest.Items[i].Unit = updatedManifest.Items[i].Unit;
                }
            }
            return manifest;
        }
    }
}