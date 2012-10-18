using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class Product
    {
        /*TODO: Add the following properties
        
         * ProductID -Guid
         * Name
         * Summary
         * Description
         * SEKeywords
         * SEDescription
         * SpecTitle
         * MiscText
         * SETitle
         * SizeOptionPrompt
         * ColorOptionPrompt
         * TextOptionPrompt
         * ProductTypeID -Guid
         * TaxClassID -Guid
         * SKU
         * ManufacturerPartNumber
         * IsFeatured -boolean
         * Published -boolean
         * Wholesale - boolean
         * RequiresRegistration -boolean
         * Notes
         * QuantityDiscountID -int
         * RelatedProducts
         * UpsellProducts
         * UpsellProductDiscountPercentage -double
         * IsAPack - boolean
         * PackSize - int
         * ShowBuyButton - boolean
         * HidePriceUntilCart - boolean
         * SEName
         * ExtensionData
         * ExtensionData1
         * ExtensionData2
         * ExtensionData3
         * ExtensionData4
         * ExtensionData5
         * ContentsBGColor
         * Deleted -boolean
         * CreatedOn - datetime
         * WarehouseLocation
         * AvailableStartDate -datetime
         * AvailableStopDate -datetime
         * GoogleCheckoutAllowed -boolean
         *         
         */

        #region Properties
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string SEKeywords { get; set; }
        public string SEDescription { get; set; }
        public string SpecTitle { get; set; }
        public string MiscText { get; set; }
        public string SETitle { get; set; }
        public string SizeOptionPrompt { get; set; }
        public string ColorOptionPrompt { get; set; }
        public string TextOptionPrompt { get; set; }
        public Guid ProductTypeId { get; set; }
        public Guid TaxClassId { get; set; }
        public string SKU { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public bool IsFeatured { get; set; }
        public bool Published { get; set; }
        public bool Wholesale { get; set; }
        public bool RequiresRegistration { get; set; }
        public string Notes { get; set; }
        public int QuantityDiscountId { get; set; }
        public string RelatedProducts { get; set; }
        public string UpsellProducts { get; set; }
        public double UpsellProductDiscountPercentage { get; set; }
        public bool IsAPack { get; set; }
        public int PackSize { get; set; }
        public bool ShowBuyButton { get; set; }
        public bool HidePriceUntilCart { get; set; }
        public string SEName { get; set; }
        public string ExtensionData { get; set; }
        public string ExtensionData1 { get; set; }
        public string ExtensionData2 { get; set; }
        public string ExtensionData3 { get; set; }
        public string ExtensionData4 { get; set; }
        public string ExtensionData5 { get; set; }
        public string ContentsBGColor { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public string WarehouseLocation { get; set; }
        public DateTime AvailableStartDate { get; set; }
        public DateTime AvailableStopDate { get; set; }
        public bool GoogleCheckoutAllowed { get; set; }
        #endregion

        #region ctor
        public Product()
        {
            ProductId = Guid.NewGuid();
        }

        public Product(Guid productId)
        {
            ProductId = productId;
        }
        #endregion
    }
}
