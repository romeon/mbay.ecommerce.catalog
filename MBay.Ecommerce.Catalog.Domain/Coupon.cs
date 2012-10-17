using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class Coupon
    {
        /*TODO: Add the following properties
          
         * CouponID -Guid
         * CouponCode
         * Description
         * StartDate -datetime
         * ExpirationDate -datetime
         * DiscountPercent -double
         * DiscountAmount -double
         * DiscountIncludesFreeShipping -boolean
         * ExpiresOnFirstUseByAnyCustomer -boolean
         * ExpiresAfterOneUsageByEachCustomer -boolean
         * ExpiresAfterNUses -int
         * RequiresMinimumOrderAmount -double
         * ValidForCustomers
         * ValidForProducts
         * ValidForManufacturers
         * ValidForCategories
         * ValidForSections
         * CouponType -int
         * NumUses -int
         * ExtensionData
         * Deleted -boolean
         * CreatedOn -datetime
         */

        #region Properties
        public Guid CouponId { get; set; }
        public string CouponCode { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountAmount { get; set; }
        public Boolean DiscountIncludesFreeShipping { get; set; }
        public Boolean ExpiresOnFirstUseByAnyCustomer { get; set; }
        public Boolean ExpiresAfterOneUsageByEachCustomer { get; set; }
        public int ExpiresAfterNUses { get; set; }
        public double RequiresMinimumOrderAmount { get; set; }
        public string ValidForCustomers { get; set; }
        public string ValidForProducts { get; set; }
        public string ValidForManufacturers { get; set; }
        public string ValidForCategories { get; set; }
        public string ValidForSections { get; set; }
        public int CouponType { get; set; }
        public int NumUses { get; set; }
        public string ExtensionData { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime CreatedOn { get; set; }
        #endregion

        #region ctor
        public Coupon()
        {
            CouponId = Guid.NewGuid();
        }

        public Coupon(Guid couponId)
        {
            CouponId = couponId;
        }
        #endregion
    }
}
