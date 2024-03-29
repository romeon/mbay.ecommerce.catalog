﻿using System;
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
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string SEKeywords { get; set; }
        public string SEDescription { get; set; }
        public string DisplayPrefix { get; set; }
        public string SETitle { get; set; }
        public string SEAltText { get; set; }
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
