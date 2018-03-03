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
    public class AddCompany_Should
    {
        // Initialize

        private ICompany company;

        [TestInitialize]
        public void Initialize()
        {
            this.company = new Company("TestCompany", "1234567890");
        }

        // CleanUp

        [TestCleanup]
        public void Cleanup()
        {
            this.company = null;
        }

        // Unit tests

        [TestMethod]
        public void Throw_ArgumentNullException_When_FurnitureIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => this.company.AddFurniture(null));
        }
    }
}
