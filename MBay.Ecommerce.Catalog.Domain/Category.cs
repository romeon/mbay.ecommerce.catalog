using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class Category
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
        public String Summary { get; set; }
        public String Description { get; set; }
        public String SEKeywords { get; set; }
        public String SEDescription { get; set; }
        public String DisplayPrefix { get; set; }
        public String SETitle { get; set; }
        public String SEAltText { get; set; }
        public Guid ParentCategoryID { get; set; }
        public Boolean Published { get; set; }
        public Boolean Wholesale { get; set; }
        public string SEName { get; set; }
        public Boolean IsImport { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime TaxClassID { get; set; }
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
