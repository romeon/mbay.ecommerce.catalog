using MBay.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBay.Ecommerce.Catalog;

namespace MBay.Ecommerce.Catalog.Domain.Test
{
    
    
    /// <summary>
    ///This is a test class for ProductManufacturerTest and is intended
    ///to contain all ProductManufacturerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProductManufacturerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for CreatedOn
        ///</summary>
        [TestMethod()]
        public void CreatedOnTest()
        {
            // Test Variable declaration
            DateTime expectedDateValue = DateTime.Now;
            ProductManufacturer productManufacturer = new ProductManufacturer(Guid.NewGuid()) { CreatedOn = expectedDateValue };
            DateTime createdOn = productManufacturer.CreatedOn;

            // Assertions
            Assert.IsNotNull(productManufacturer.CreatedOn);
            Assert.AreEqual(expectedDateValue, productManufacturer.CreatedOn);
        }

        /// <summary>
        ///A test for ManufacturerId
        ///</summary>
        [TestMethod()]
        public void ManufacturerIdTest()
        {
            // Test Variable declaration
            Guid expectedValueId = Guid.NewGuid();
            ProductManufacturer productManufacturer = new ProductManufacturer(expectedValueId);

            // Assertions
            Assert.IsNotNull(productManufacturer.ManufacturerId);
            Assert.AreEqual(expectedValueId, productManufacturer.ManufacturerId);
            Assert.AreNotSame(expectedValueId, productManufacturer.ManufacturerId);
        }

        /// <summary>
        ///A test for ProductId
        ///</summary>
        [TestMethod()]
        public void ProductIdTest()
        {
            // Test Variable declaration
            Guid expectedValueId = Guid.NewGuid();
            ProductManufacturer productManufacturer = new ProductManufacturer(expectedValueId);

            // Assertions
            Assert.IsNotNull(productManufacturer.ProductId);
            Assert.AreEqual(expectedValueId, productManufacturer.ProductId);
            Assert.AreNotSame(expectedValueId, productManufacturer.ProductId);
        }
    }
}
