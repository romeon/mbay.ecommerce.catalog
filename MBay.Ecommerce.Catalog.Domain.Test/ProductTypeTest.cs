using MBay.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MBay.Ecommerce.Catalog.Domain.Test
{
    
    
    /// <summary>
    ///This is a test class for ProductTypeTest and is intended
    ///to contain all ProductTypeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProductTypeTest
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
        ///A test for ProductType Constructor
        ///</summary>
        [TestMethod()]
        public void ProductTypeConstructorTest()
        {
            ProductType target = new ProductType();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ProductType Constructor
        ///</summary>
        [TestMethod()]
        public void ProductTypeConstructorTest1()
        {
            Guid productTypeId = new Guid(); // TODO: Initialize to an appropriate value
            ProductType target = new ProductType(productTypeId);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreatedOn
        ///</summary>
        [TestMethod()]
        public void CreatedOnTest()
        {
            ProductType target = new ProductType(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.CreatedOn = expected;
            actual = target.CreatedOn;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DisplayOrder
        ///</summary>
        [TestMethod()]
        public void DisplayOrderTest()
        {
            ProductType target = new ProductType(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.DisplayOrder = expected;
            actual = target.DisplayOrder;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProductTypeId
        ///</summary>
        [TestMethod()]
        public void ProductTypeIdTest()
        {
            ProductType target = new ProductType(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            target.ProductTypeId = expected;
            actual = target.ProductTypeId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TaxClassId
        ///</summary>
        [TestMethod()]
        public void TaxClassIdTest()
        {
            ProductType target = new ProductType(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            target.TaxClassId = expected;
            actual = target.TaxClassId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
