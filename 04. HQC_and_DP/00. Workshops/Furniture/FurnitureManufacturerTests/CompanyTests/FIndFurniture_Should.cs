using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturerTests.CompanyTests
{
    [TestClass]
    public class FIndFurniture_Should
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
        public void FindFurniture_Throws_ArgumentNullException_When_FurnitureModelIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => this.company.FindFurniture(null));
        }
    }
}
