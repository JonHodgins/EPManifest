//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using EPManifest.Core;
//using EPManifest.Data;
//using EPManifest.Data.Repositories;
//using Xunit;
//using FluentAssertions;

//namespace EPManifest.Tests
//{
//    public class RepositoryTests
//    {
//        [Fact]
//        public void CanGetAllManifests()
//        {
//            var context = new EPManifestDbContext();
//            var repository = new ManifestRepository(context);

//            var manifest = new Manifest(
//                DateTime.Now, new Consignor { Name = "Frank's Shipping" },
//                new Consignee { Name = "Paul's Delivery" }, new Carrier { Name = "Tim's Delivery" });

//            var expected = repository.AddManifest(manifest);
//            var actual = repository.GetManifestById(1);

//            actual.Should().BeEquivalentTo(expected);
//        }
//    }
//}
