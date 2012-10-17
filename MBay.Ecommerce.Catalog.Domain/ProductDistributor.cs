using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class ProductDistributor
    {
        /*TODO: Add the following properties
           
         * ProductID -Guid
         * DistributorID -Guid
         * CreatedOn - datetime
         */

        #region Properties
        public Guid ProductId { get; set; }
        public Guid DistributorId { get; set; }
        public DateTime CreatedOn { get; set; }
        #endregion

        #region ctor
        public ProductDistributor()
        {
            ProductId = Guid.NewGuid();
        }

        public ProductDistributor(Guid productId)
        {
            ProductId = productId;
        }
        #endregion
    }
}
