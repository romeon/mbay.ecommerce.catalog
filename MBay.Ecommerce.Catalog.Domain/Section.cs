using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBay.Core.Domain
{
    public class Section
    {
        /*TODO: Add the following properties
           
         * SectionID -Guid
         * Name
         * Summary
         * Description
         * SEKeywords
         * SEDescription
         * DisplayPrefix
         * SETitle
         * SEAltText
         * ParentSectionID -Guid
         * Published - boolean
         * Wholesale -boolean
         * ShowInProductBrowser -boolean
         * QuantityDiscountID -boolean
         * SEName
         * IsImport -boolean
         * Deleted - boolean
         * CreatedOn -datetime
         */

        #region Properties
        public Guid SectionId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string SEKeywords { get; set; }
        public string SEDescription { get; set; }
        public string DisplayPrefix { get; set; }
        public string SETitle { get; set; }
        public string SEAltText { get; set; }
        public Guid ParentSectionId { get; set; }
        public Boolean Published { get; set; }
        public Boolean Wholesale { get; set; }
        public Boolean ShowInProductBrowser { get; set; }
        public Boolean QuantityDiscountId { get; set; }
        public string SEName { get; set; }
        public Boolean IsImport { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime CreatedOn { get; set; }
        #endregion

        #region ctor
        public Section()
        {
            SectionId = Guid.NewGuid();
        }

        public Section(Guid sectionId)
        {
            SectionId = sectionId;
        }
        #endregion
    }
}
