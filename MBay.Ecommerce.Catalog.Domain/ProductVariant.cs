using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class ProductVariant
    {
        /*TODO: Add the following properties
           
         * VariantID -Guid
         * IsDefault- boolean
         * Name
         * Description
         * SEKeywords
         * SEDescription
         * SEAltText
         * Colors
         * ColorSKUModifiers
         * Sizes
         * SizeSKUModifiers
         * ProductID - GUID
         * SKUSuffix
         * ManufacturerPartNumber
         * Price -double
         * SalePrice -double
         * Weight -double
         * MSRP - double
         * Cost - double
         * Points - int
         * Dimensions
         * Inventory - int
         * Notes 
         * IsTaxable -Boolean
         * IsShipSeparately - boolean
         * IsDownload - boolean
         * DownloadLocation 
         * FreeShipping -boolean
         * Published - boolean
         * Wholesale - boolean
         * IsSecureAttachment - boolean
         * IsRecurring - boolean
         * RecurringInterval - int
         * RecurringIntervalType - int
         * SubscriptionInterval -int
         * RewardPoints - int
         * SEName
         * RestrictedQuantities
         * MinimumQuantity - int
         * ExtensionData
         * ExtensionData1
         * ExtensionData2
         * ExtensionData3
         * ExtensionData4
         * ExtensionData5
         * IsImport -boolean
         * Deleted -boolean
         * CreatedOn -datetime
         * SubscriptionIntervalType - int
         * CustomerEntersPrice - boolean
         * CustomerEntersPricePrompt
         * Condition - boolean
         */

        #region Properties
        public Guid VariantId { get; set; }
        public Boolean IsDefault { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SEKeywords { get; set; }
        public string SEDescription { get; set; }
        public string SEAltText { get; set; }
        public string Colors { get; set; }
        public string ColorSKUModifiers { get; set; }
        public string Sizes { get; set; }
        public string SizeSKUModifiers { get; set; }
        public Guid ProductId { get; set; }
        public string SKUSuffix { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public double Weight { get; set; }
        public double MSRP { get; set; }
        public double Cost { get; set; }
        #endregion

        #region ctor
        public ProductVariant()
        {
            VariantId = Guid.NewGuid();
        }

        public ProductVariant(Guid variantId)
        {
            VariantId = variantId;
        }
        #endregion
    }
}
