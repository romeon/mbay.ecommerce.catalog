using MBay.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MBay.Ecommerce.Catalog.Domain.Test
{
    
    
    /// <summary>
    ///This is a test class for CouponTest and is intended
    ///to contain all CouponTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CouponTest
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
        ///A test for Coupon Constructor
        ///</summary>
        [TestMethod()]
        public void CouponConstructorTest()
        {
            Coupon target = new Coupon();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Coupon Constructor
        ///</summary>
        [TestMethod()]
        public void CouponConstructorTest1()
        {
            Guid couponId = new Guid(); // TODO: Initialize to an appropriate value
            Coupon target = new Coupon(couponId);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CouponCode
        ///</summary>
        [TestMethod()]
        public void CouponCodeTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.CouponCode = expected;
            actual = target.CouponCode;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CouponId
        ///</summary>
        [TestMethod()]
        public void CouponIdTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            target.CouponId = expected;
            actual = target.CouponId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CouponType
        ///</summary>
        [TestMethod()]
        public void CouponTypeTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.CouponType = expected;
            actual = target.CouponType;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreatedOn
        ///</summary>
        [TestMethod()]
        public void CreatedOnTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.CreatedOn = expected;
            actual = target.CreatedOn;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Deleted
        ///</summary>
        [TestMethod()]
        public void DeletedTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Deleted = expected;
            actual = target.Deleted;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Description
        ///</summary>
        [TestMethod()]
        public void DescriptionTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Description = expected;
            actual = target.Description;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DiscountAmount
        ///</summary>
        [TestMethod()]
        public void DiscountAmountTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.DiscountAmount = expected;
            actual = target.DiscountAmount;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DiscountIncludesFreeShipping
        ///</summary>
        [TestMethod()]
        public void DiscountIncludesFreeShippingTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.DiscountIncludesFreeShipping = expected;
            actual = target.DiscountIncludesFreeShipping;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DiscountPercent
        ///</summary>
        [TestMethod()]
        public void DiscountPercentTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.DiscountPercent = expected;
            actual = target.DiscountPercent;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExpirationDate
        ///</summary>
        [TestMethod()]
        public void ExpirationDateTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.ExpirationDate = expected;
            actual = target.ExpirationDate;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExpiresAfterNUses
        ///</summary>
        [TestMethod()]
        public void ExpiresAfterNUsesTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.ExpiresAfterNUses = expected;
            actual = target.ExpiresAfterNUses;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExpiresAfterOneUsageByEachCustomer
        ///</summary>
        [TestMethod()]
        public void ExpiresAfterOneUsageByEachCustomerTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.ExpiresAfterOneUsageByEachCustomer = expected;
            actual = target.ExpiresAfterOneUsageByEachCustomer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExpiresOnFirstUseByAnyCustomer
        ///</summary>
        [TestMethod()]
        public void ExpiresOnFirstUseByAnyCustomerTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.ExpiresOnFirstUseByAnyCustomer = expected;
            actual = target.ExpiresOnFirstUseByAnyCustomer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExtensionData
        ///</summary>
        [TestMethod()]
        public void ExtensionDataTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ExtensionData = expected;
            actual = target.ExtensionData;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumUses
        ///</summary>
        [TestMethod()]
        public void NumUsesTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumUses = expected;
            actual = target.NumUses;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RequiresMinimumOrderAmount
        ///</summary>
        [TestMethod()]
        public void RequiresMinimumOrderAmountTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.RequiresMinimumOrderAmount = expected;
            actual = target.RequiresMinimumOrderAmount;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StartDate
        ///</summary>
        [TestMethod()]
        public void StartDateTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.StartDate = expected;
            actual = target.StartDate;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ValidForCategories
        ///</summary>
        [TestMethod()]
        public void ValidForCategoriesTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ValidForCategories = expected;
            actual = target.ValidForCategories;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ValidForCustomers
        ///</summary>
        [TestMethod()]
        public void ValidForCustomersTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ValidForCustomers = expected;
            actual = target.ValidForCustomers;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ValidForManufacturers
        ///</summary>
        [TestMethod()]
        public void ValidForManufacturersTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ValidForManufacturers = expected;
            actual = target.ValidForManufacturers;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ValidForProducts
        ///</summary>
        [TestMethod()]
        public void ValidForProductsTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ValidForProducts = expected;
            actual = target.ValidForProducts;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ValidForSections
        ///</summary>
        [TestMethod()]
        public void ValidForSectionsTest()
        {
            Coupon target = new Coupon(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ValidForSections = expected;
            actual = target.ValidForSections;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
