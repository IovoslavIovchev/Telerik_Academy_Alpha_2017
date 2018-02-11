using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturerTests.CompanyTests
{
    [TestClass]
    public class Catalog_Should
    {
        // Arrange

        private ICompany company;

        [TestInitialize]
        public void Initialize()
        {
            this.company = new Company("TestCompany", "1234567890");
        }

        [TestCleanup]
        public void Cleanup()
        {
            this.company = null;
        }

        // Unit tests

        [TestMethod]
        public void AddFurniture_Throws_ArgumentNullException_When_FurnitureIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => this.company.AddFurniture(null));
        }

        [TestMethod]
        public void CompanyCatalog_ReturnsNoFurnitures_When_CatalogIsEmpty()
        {
            Assert.AreEqual("TestCompany - 1234567890 - no furnitures", this.company.Catalog());
        }

        [TestMethod]
        public void CompanyCatalog_ReturnsCatalog_When_ThereIsOneChairInCatalog()
        {
            var fakeChair = new Mock<IChair>();
            fakeChair.Setup(x => x.ToString()).Returns("fakeChair");
            string expected = "TestCompany - 1234567890 - 1 furniture\r\nfakeChair";

            this.company.AddFurniture(fakeChair.Object);

            Assert.AreEqual(expected, this.company.Catalog());
        }
    }
}
