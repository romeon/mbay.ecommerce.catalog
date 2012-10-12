using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    class Category
    {
        /*TODO: Add the following properties
           
         * CategoryID -Guid
         * Name
         * Summary
         * Description
         * SEKeywords
         * SEDescription
         * DisplayPrefix
         * SETitle
         * SEAltText
         * ParentCategoryID -Guid
         * Published -boolean
         * Wholesale -boolean
         * SEName
         * IsImport -boolean
         * Deleted -boolean
         * CreatedOn -datetime
         * TaxClassID -datetime
         */

        #region Properties
        public Guid CategoryId { get; set; }
        public String Name { get; set; }
        #endregion

        #region ctor
        public Category()
        {
            CategoryId = Guid.NewGuid();
        }

        public Category(Guid categoryId)
        {
            CategoryId = categoryId;
        }
        #endregion
    }
}
