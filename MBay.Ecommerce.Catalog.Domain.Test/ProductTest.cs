using MBay.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBay.Ecommerce.Catalog;

namespace MBay.Ecommerce.Catalog.Domain.Test
{
    
    
    /// <summary>
    ///This is a test class for ProductTest and is intended
    ///to contain all ProductTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProductTest
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
        ///A test for Product Constructor
        ///</summary>
        [TestMethod()]
        public void ProductConstructorTest()
        {
            Product target = new Product();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Product Constructor
        ///</summary>
        [TestMethod()]
        public void ProductConstructorTest1()
        {
            Guid productId = new Guid(); // TODO: Initialize to an appropriate value
            Product target = new Product(productId);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AvailableStartDate
        ///</summary>
        [TestMethod()]
        public void AvailableStartDateTest()
        {
            // Test Variable declaration
            DateTime expectedDateValue = DateTime.Now;
            Product product = new Product(Guid.NewGuid()) { AvailableStartDate = expectedDateValue };
            DateTime availableStartDate = product.AvailableStartDate;

            // Assertions
            Assert.IsNotNull(product.AvailableStartDate);
            Assert.AreEqual(expectedDateValue, product.AvailableStartDate);
        }

        /// <summary>
        ///A test for AvailableStopDate
        ///</summary>
        [TestMethod()]
        public void AvailableStopDateTest()
        {
            // Test Variable declaration
            DateTime expectedDateValue = DateTime.Now;
            Product product = new Product(Guid.NewGuid()) { AvailableStopDate = expectedDateValue };
            DateTime availableStopDate = product.AvailableStopDate;

            // Assertions
            Assert.IsNotNull(product.AvailableStopDate);
            Assert.AreEqual(expectedDateValue, product.AvailableStopDate);
        }

        /// <summary>
        ///A test for ColorOptionPrompt
        ///</summary>
        [TestMethod()]
        public void ColorOptionPromptTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ColorOptionPrompt = expected;
            actual = target.ColorOptionPrompt;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContentsBGColor
        ///</summary>
        [TestMethod()]
        public void ContentsBGColorTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ContentsBGColor = expected;
            actual = target.ContentsBGColor;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreatedOn
        ///</summary>
        [TestMethod()]
        public void CreatedOnTest()
        {
            // Test Variable declaration
            DateTime expectedDateValue = DateTime.Now;
            Product product = new Product(Guid.NewGuid()) { CreatedOn = expectedDateValue };
            DateTime createdOn = product.CreatedOn;

            // Assertions
            Assert.IsNotNull(product.CreatedOn);
            Assert.AreEqual(expectedDateValue, product.CreatedOn);
        }

        /// <summary>
        ///A test for Deleted
        ///</summary>
        [TestMethod()]
        public void DeletedTest()
        {
            // Test Variable declaration
            bool expectedBooleanValue = true;
            Product product = new Product(Guid.NewGuid()) { Deleted = expectedBooleanValue };
            bool deleted = product.Deleted;

            // Assertions
            Assert.IsNotNull(product.Deleted);
            Assert.AreEqual(expectedBooleanValue, product.Deleted);
        }

        /// <summary>
        ///A test for Description
        ///</summary>
        [TestMethod()]
        public void DescriptionTest()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum";
            Product product = new Product(Guid.NewGuid()) { Description = expectedValueString };
            string description = product.Description;

            // Assertions
            Assert.AreEqual(expectedValueString, product.Description);
            Assert.IsNull(expectedValueString, product.Description);
            Assert.Inconclusive(product.Description);
        }

        /// <summary>
        ///A test for ExtensionData
        ///</summary>
        [TestMethod()]
        public void ExtensionDataTest()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum dolor sit amet";
            Product product = new Product(Guid.NewGuid()) { ExtensionData = expectedValueString };
            string extensionData = product.ExtensionData;

            // Assertions
            Assert.AreEqual(expectedValueString, product.ExtensionData);
            Assert.IsNull(expectedValueString, product.ExtensionData);
            Assert.Inconclusive(product.ExtensionData);
        }

        /// <summary>
        ///A test for ExtensionData1
        ///</summary>
        [TestMethod()]
        public void ExtensionData1Test()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum";
            Product product = new Product(Guid.NewGuid()) { ExtensionData1 = expectedValueString };
            string extensionData1 = product.ExtensionData1;

            // Assertions
            Assert.AreEqual(expectedValueString, product.ExtensionData1);
            Assert.IsNull(expectedValueString, product.ExtensionData1);
            Assert.Inconclusive(product.ExtensionData1);
        }

        /// <summary>
        ///A test for ExtensionData2
        ///</summary>
        [TestMethod()]
        public void ExtensionData2Test()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum";
            Product product = new Product(Guid.NewGuid()) { ExtensionData2 = expectedValueString };
            string extensionData2 = product.ExtensionData2;

            // Assertions
            Assert.AreEqual(expectedValueString, product.ExtensionData2);
            Assert.IsNull(expectedValueString, product.ExtensionData2);
            Assert.Inconclusive(product.ExtensionData2);
        }

        /// <summary>
        ///A test for ExtensionData3
        ///</summary>
        [TestMethod()]
        public void ExtensionData3Test()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum";
            Product product = new Product(Guid.NewGuid()) { ExtensionData3 = expectedValueString };
            string extensionData3 = product.ExtensionData3;

            // Assertions
            Assert.AreEqual(expectedValueString, product.ExtensionData3);
            Assert.IsNull(expectedValueString, product.ExtensionData3);
            Assert.Inconclusive(product.ExtensionData3);
        }

        /// <summary>
        ///A test for ExtensionData4
        ///</summary>
        [TestMethod()]
        public void ExtensionData4Test()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum";
            Product product = new Product(Guid.NewGuid()) { ExtensionData4 = expectedValueString };
            string extensionData4 = product.ExtensionData4;

            // Assertions
            Assert.AreEqual(expectedValueString, product.ExtensionData4);
            Assert.IsNull(expectedValueString, product.ExtensionData4);
            Assert.Inconclusive(product.ExtensionData4);
        }

        /// <summary>
        ///A test for ExtensionData5
        ///</summary>
        [TestMethod()]
        public void ExtensionData5Test()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum";
            Product product = new Product(Guid.NewGuid()) { ExtensionData5 = expectedValueString };
            string extensionData5 = product.ExtensionData5;

            // Assertions
            Assert.AreEqual(expectedValueString, product.ExtensionData5);
            Assert.IsNull(expectedValueString, product.ExtensionData5);
            Assert.Inconclusive(product.ExtensionData5);
        }

        /// <summary>
        ///A test for GoogleCheckoutAllowed
        ///</summary>
        [TestMethod()]
        public void GoogleCheckoutAllowedTest()
        {
            // Test Variable declaration
            bool expectedBooleanValue = true;
            Product product = new Product(Guid.NewGuid()) { GoogleCheckoutAllowed = expectedBooleanValue };
            bool googleCheckoutAllowed = product.GoogleCheckoutAllowed;

            // Assertions
            Assert.IsNotNull(product.GoogleCheckoutAllowed);
            Assert.AreEqual(expectedBooleanValue, product.GoogleCheckoutAllowed);
        }

        /// <summary>
        ///A test for HidePriceUntilCart
        ///</summary>
        [TestMethod()]
        public void HidePriceUntilCartTest()
        {
            // Test Variable declaration
            bool expectedBooleanValue = true;
            Product product = new Product(Guid.NewGuid()) { HidePriceUntilCart = expectedBooleanValue };
            bool hidePriceUntilCart = product.HidePriceUntilCart;

            // Assertions
            Assert.IsNotNull(product.HidePriceUntilCart);
            Assert.AreEqual(expectedBooleanValue, product.HidePriceUntilCart);
        }

        /// <summary>
        ///A test for IsAPack
        ///</summary>
        [TestMethod()]
        public void IsAPackTest()
        {
            // Test Variable declaration
            bool expectedBooleanValue = true;
            Product product = new Product(Guid.NewGuid()) { IsAPack = expectedBooleanValue };
            bool isAPack = product.IsAPack;

            // Assertions
            Assert.IsNotNull(product.IsAPack);
            Assert.AreEqual(expectedBooleanValue, product.IsAPack);
        }

        /// <summary>
        ///A test for IsFeatured
        ///</summary>
        [TestMethod()]
        public void IsFeaturedTest()
        {
            // Test Variable declaration
            bool expectedBooleanValue = true;
            Product product = new Product(Guid.NewGuid()) { IsFeatured = expectedBooleanValue };
            bool isFeatured = product.IsFeatured;

            // Assertions
            Assert.IsNotNull(product.IsFeatured);
            Assert.AreEqual(expectedBooleanValue, product.IsFeatured);
        }

        /// <summary>
        ///A test for ManufacturerPartNumber
        ///</summary>
        [TestMethod()]
        public void ManufacturerPartNumberTest()
        {
            // Test Variable declaration
            string expectedValueString = "12345";
            Product product = new Product(Guid.NewGuid()) { ManufacturerPartNumber = expectedValueString };
            string manufacturerPartNumber = product.ManufacturerPartNumber;

            // Assertions
            Assert.IsNotNull(product.ManufacturerPartNumber);
            Assert.AreEqual(expectedValueString, product.ManufacturerPartNumber);
            Assert.AreNotSame(expectedValueString, product.ManufacturerPartNumber);
            Assert.Inconclusive(product.ManufacturerPartNumber);
        }

        /// <summary>
        ///A test for MiscText
        ///</summary>
        [TestMethod()]
        public void MiscTextTest()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum";
            Product product = new Product(Guid.NewGuid()) { MiscText = expectedValueString };
            string miscText = product.MiscText;

            // Assertions
            Assert.IsNotNull(product.MiscText);
            Assert.AreEqual(expectedValueString, product.MiscText);
            Assert.AreNotSame(expectedValueString, product.MiscText);
            Assert.Inconclusive(product.MiscText);
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            // Test Variable declaration
            string expectedValueString = "John";
            Product product = new Product(Guid.NewGuid()) { Name = expectedValueString };
            string name = product.Name;

            // Assertions
            Assert.IsNotNull(product.Name);
            Assert.AreEqual(expectedValueString, product.Name);
            Assert.AreNotSame(expectedValueString, product.Name);
            Assert.Inconclusive(product.Name);
        }

        /// <summary>
        ///A test for Notes
        ///</summary>
        [TestMethod()]
        public void NotesTest()
        {
            // Test Variable declaration
            string expectedValueString = "Lorem ipsum dolor sit amet";
            Product product = new Product(Guid.NewGuid()) { Notes = expectedValueString };
            string notes = product.Notes;

            // Assertions
            Assert.IsNotNull(product.Notes);
            Assert.AreEqual(expectedValueString, product.Notes);
            Assert.AreNotSame(expectedValueString, product.Notes);
            Assert.Inconclusive(product.Notes);
        }

        /// <summary>
        ///A test for PackSize
        ///</summary>
        [TestMethod()]
        public void PackSizeTest()
        {
            // Test Variable declaration
            int expectedValueInt = 1;
            Product product = new Product(Guid.NewGuid()) { PackSize = expectedValueInt };
            int packSize = product.PackSize;

            // Assertions
            Assert.IsNotNull(product.PackSize);
            Assert.AreEqual(expectedValueInt, product.PackSize);
        }

        /// <summary>
        ///A test for ProductId
        ///</summary>
        [TestMethod()]
        public void ProductIdTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            target.ProductId = expected;
            actual = target.ProductId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProductTypeId
        ///</summary>
        [TestMethod()]
        public void ProductTypeIdTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            target.ProductTypeId = expected;
            actual = target.ProductTypeId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Published
        ///</summary>
        [TestMethod()]
        public void PublishedTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Published = expected;
            actual = target.Published;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for QuantityDiscountId
        ///</summary>
        [TestMethod()]
        public void QuantityDiscountIdTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.QuantityDiscountId = expected;
            actual = target.QuantityDiscountId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RelatedProducts
        ///</summary>
        [TestMethod()]
        public void RelatedProductsTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.RelatedProducts = expected;
            actual = target.RelatedProducts;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RequiresRegistration
        ///</summary>
        [TestMethod()]
        public void RequiresRegistrationTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.RequiresRegistration = expected;
            actual = target.RequiresRegistration;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SEDescription
        ///</summary>
        [TestMethod()]
        public void SEDescriptionTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
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
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SEKeywords = expected;
            actual = target.SEKeywords;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SEName
        ///</summary>
        [TestMethod()]
        public void SENameTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SEName = expected;
            actual = target.SEName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SETitle
        ///</summary>
        [TestMethod()]
        public void SETitleTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SETitle = expected;
            actual = target.SETitle;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SKU
        ///</summary>
        [TestMethod()]
        public void SKUTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SKU = expected;
            actual = target.SKU;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShowBuyButton
        ///</summary>
        [TestMethod()]
        public void ShowBuyButtonTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.ShowBuyButton = expected;
            actual = target.ShowBuyButton;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SizeOptionPrompt
        ///</summary>
        [TestMethod()]
        public void SizeOptionPromptTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SizeOptionPrompt = expected;
            actual = target.SizeOptionPrompt;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SpecTitle
        ///</summary>
        [TestMethod()]
        public void SpecTitleTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SpecTitle = expected;
            actual = target.SpecTitle;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Summary
        ///</summary>
        [TestMethod()]
        public void SummaryTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Summary = expected;
            actual = target.Summary;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TaxClassId
        ///</summary>
        [TestMethod()]
        public void TaxClassIdTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            target.TaxClassId = expected;
            actual = target.TaxClassId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TextOptionPrompt
        ///</summary>
        [TestMethod()]
        public void TextOptionPromptTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TextOptionPrompt = expected;
            actual = target.TextOptionPrompt;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpsellProductDiscountPercentage
        ///</summary>
        [TestMethod()]
        public void UpsellProductDiscountPercentageTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.UpsellProductDiscountPercentage = expected;
            actual = target.UpsellProductDiscountPercentage;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpsellProducts
        ///</summary>
        [TestMethod()]
        public void UpsellProductsTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.UpsellProducts = expected;
            actual = target.UpsellProducts;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WarehouseLocation
        ///</summary>
        [TestMethod()]
        public void WarehouseLocationTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.WarehouseLocation = expected;
            actual = target.WarehouseLocation;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Wholesale
        ///</summary>
        [TestMethod()]
        public void WholesaleTest()
        {
            Product target = new Product(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Wholesale = expected;
            actual = target.Wholesale;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
