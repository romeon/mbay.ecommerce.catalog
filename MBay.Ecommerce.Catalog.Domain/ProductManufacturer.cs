using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class ProductManufacturer
    {
        /*TODO: Add the following properties
           
         * ProductID -Guid
         * ManufacturerID -Guid
         * CreatedOn - datetime
         */

        #region Properties
        public Guid ProductId { get; set; }
        public Guid ManufacturerId { get; set; }
        public DateTime CreatedOn { get; set; }
        #endregion

        #region ctor
        public ProductManufacturer()
        {
            ProductId = Guid.NewGuid();
        }

        public ProductManufacturer(Guid productId)
        {
            ProductId = productId;
        }
        #endregion
    }
}
