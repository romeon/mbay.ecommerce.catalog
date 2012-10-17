using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class ProductType
    {
        /*TODO: Add the following properties

         * ProductTypeID -Guid
         * DisplayOrder -int
         * TaxClassID -Guid
         * CreatedOn -datetime
         */

        #region Properties
        public Guid ProductTypeId { get; set; }
        public int DisplayOrder { get; set; }
        public Guid TaxClassId { get; set; }
        public DateTime CreatedOn { get; set; }
        #endregion

        #region ctor
        public ProductType()
        {
            ProductTypeId = Guid.NewGuid();
        }

        public ProductType(Guid productTypeId)
        {
            ProductTypeId = productTypeId;
        }
        #endregion
    }
}
