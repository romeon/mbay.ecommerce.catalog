using MBay.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MBay.Ecommerce.Catalog.Domain.Test
{
    
    
    /// <summary>
    ///This is a test class for ProductVariantTest and is intended
    ///to contain all ProductVariantTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProductVariantTest
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
        ///A test for ProductVariant Constructor
        ///</summary>
        [TestMethod()]
        public void ProductVariantConstructorTest()
        {
            ProductVariant target = new ProductVariant();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ProductVariant Constructor
        ///</summary>
        [TestMethod()]
        public void ProductVariantConstructorTest1()
        {
            Guid variantId = new Guid(); // TODO: Initialize to an appropriate value
            ProductVariant target = new ProductVariant(variantId);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ColorSKUModifiers
        ///</summary>
        [TestMethod()]
        public void ColorSKUModifiersTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ColorSKUModifiers = expected;
            actual = target.ColorSKUModifiers;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Colors
        ///</summary>
        [TestMethod()]
        public void ColorsTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Colors = expected;
            actual = target.Colors;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Cost
        ///</summary>
        [TestMethod()]
        public void CostTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.Cost = expected;
            actual = target.Cost;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Description
        ///</summary>
        [TestMethod()]
        public void DescriptionTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Description = expected;
            actual = target.Description;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsDefault
        ///</summary>
        [TestMethod()]
        public void IsDefaultTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsDefault = expected;
            actual = target.IsDefault;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MSRP
        ///</summary>
        [TestMethod()]
        public void MSRPTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.MSRP = expected;
            actual = target.MSRP;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ManufacturerPartNumber
        ///</summary>
        [TestMethod()]
        public void ManufacturerPartNumberTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ManufacturerPartNumber = expected;
            actual = target.ManufacturerPartNumber;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Price
        ///</summary>
        [TestMethod()]
        public void PriceTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.Price = expected;
            actual = target.Price;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProductId
        ///</summary>
        [TestMethod()]
        public void ProductIdTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            target.ProductId = expected;
            actual = target.ProductId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SEAltText
        ///</summary>
        [TestMethod()]
        public void SEAltTextTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SEAltText = expected;
            actual = target.SEAltText;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SEDescription
        ///</summary>
        [TestMethod()]
        public void SEDescriptionTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SEDescription = expected;
            actual = target.SEDescription;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SEKeywords
        ///</summary>
        [TestMethod()]
        public void SEKeywordsTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SEKeywords = expected;
            actual = target.SEKeywords;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SKUSuffix
        ///</summary>
        [TestMethod()]
        public void SKUSuffixTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SKUSuffix = expected;
            actual = target.SKUSuffix;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SalePrice
        ///</summary>
        [TestMethod()]
        public void SalePriceTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.SalePrice = expected;
            actual = target.SalePrice;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SizeSKUModifiers
        ///</summary>
        [TestMethod()]
        public void SizeSKUModifiersTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SizeSKUModifiers = expected;
            actual = target.SizeSKUModifiers;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Sizes
        ///</summary>
        [TestMethod()]
        public void SizesTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Sizes = expected;
            actual = target.Sizes;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VariantId
        ///</summary>
        [TestMethod()]
        public void VariantIdTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            target.VariantId = expected;
            actual = target.VariantId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Weight
        ///</summary>
        [TestMethod()]
        public void WeightTest()
        {
            ProductVariant target = new ProductVariant(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.Weight = expected;
            actual = target.Weight;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
