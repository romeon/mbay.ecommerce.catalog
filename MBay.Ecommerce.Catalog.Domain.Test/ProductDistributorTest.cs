using MBay.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBay.Ecommerce.Catalog.Domain;

namespace MBay.Ecommerce.Catalog.Domain.Test
{
    
    
    /// <summary>
    ///This is a test class for ProductDistributorTest and is intended
    ///to contain all ProductDistributorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProductDistributorTest
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


        /// <summary>
        ///A test for CreatedOn
        ///</summary>
        [TestMethod()]
        public void CreatedOnTest()
        {
            // Test Variable declaration
            DateTime expectedValueDate = DateTime.Now;
            ProductDistributor productDistributor = new ProductDistributor(Guid.NewGuid()) { CreatedOn = expectedValueDate };
            DateTime createdOn = productDistributor.CreatedOn;

            // Assertions
            Assert.IsNotNull(productDistributor.CreatedOn);
            Assert.AreEqual(expectedValueDate, productDistributor.CreatedOn);
        }

        /// <summary>
        ///A test for DistributorId
        ///</summary>
        [TestMethod()]
        public void DistributorIdTest()
        {
            // Test Variable declaration
            Guid expectedValueId = Guid.NewGuid();
            ProductDistributor productDistributor = new ProductDistributor(expectedValueId);

            // Assertions
            Assert.IsNotNull(productDistributor.DistributorId);
            Assert.AreEqual(expectedValueId, productDistributor.DistributorId);
            Assert.AreNotSame(expectedValueId, productDistributor.DistributorId);
        }

        /// <summary>
        ///A test for ProductId
        ///</summary>
        [TestMethod()]
        public void ProductIdTest()
        {
            // Test Variable declaration
            Guid expectedValueId = Guid.NewGuid();
            ProductDistributor productDistributor = new ProductDistributor(expectedValueId);

            // Assertions
            Assert.IsNotNull(productDistributor.ProductId);
            Assert.AreEqual(expectedValueId, productDistributor.ProductId);
            Assert.AreNotSame(expectedValueId, productDistributor.ProductId);
        }
    }
}
