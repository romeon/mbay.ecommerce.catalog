using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using MBay.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBay.Ecommerce.Catalog.Domain.Test
{
    
    
    /// <summary>
    ///This is a test class for ProductCategoryTest and is intended
    ///to contain all ProductCategoryTest Unit Tests
    ///</summary>

    [TestClass()]
    public class ProductCategoryTest
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
        ///A test for ProductCategory Constructor
        ///</summary>
        [TestMethod()]
        public void ProductCategoryConstructorTest()
        {
            ProductCategory target = new ProductCategory();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ProductCategory Constructor
        ///</summary>
        [TestMethod()]
        public void ProductCategoryConstructorTest1()
        {
            Guid productId = new Guid(); // TODO: Initialize to an appropriate value
            ProductCategory target = new ProductCategory(productId);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CategoryId
        ///</summary>
        [TestMethod()]
        public void CategoryIdTest()
        {
            Guid expectedValue = Guid.NewGuid();
            ProductCategory productCategory = new ProductCategory(expectedValue);

            Assert.IsNotNull(productCategory.CategoryId);
            Assert.AreEqual(expectedValue, productCategory.CategoryId);
            Assert.AreNotSame(expectedValue, productCategory.CategoryId);
        }

        /// <summary>
        ///A test for CreatedOn
        ///</summary>
        [TestMethod()]
        public void CreatedOnTest()
        {
            DateTime expectedValue = DateTime.Now;
            ProductCategory productCategory = new ProductCategory(Guid.NewGuid()) { CreatedOn = expectedValue };
            DateTime createdOn = productCategory.CreatedOn;

            Assert.IsNotNull(productCategory.CreatedOn);
            Assert.AreEqual(expectedValue, productCategory.CreatedOn);
            Assert.AreNotSame(expectedValue, productCategory.CreatedOn);
        }

        /// <summary>
        ///A test for ProductId
        ///</summary>
        [TestMethod()]
        public void ProductIdTest()
        {
            Guid expectedValue = Guid.NewGuid();
            ProductCategory productCategory = new ProductCategory(expectedValue);

            Assert.IsNotNull(productCategory.ProductId);
            Assert.AreEqual(expectedValue, productCategory.ProductId);
            Assert.AreNotSame(expectedValue, productCategory.ProductId);
        }
    }
}
