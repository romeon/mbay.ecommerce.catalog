using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class ProductCategory
    {
        /*TODO: Add the following properties
           
         * ProductID -Guid
         * CategoryID -Guid
         * CreatedOn - datetime
         * 
         */

        #region Properties
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
        #endregion

        #region ctor
        public ProductCategory()
        {
            ProductId = Guid.NewGuid();
        }

        public ProductCategory(Guid productId)
        {
            ProductId = productId;
        }
        #endregion
    }
}
