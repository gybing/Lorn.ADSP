//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.ADSP.AM.DataModels
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// RedirectCondition
    /// </summary>
    public partial class RedirectCondition
    {
        public RedirectCondition()
        {
            this.RedirctConditionDetails = new HashSet<RedirectConditionDetail>();
        }
    
        /// <summary>
        /// RedirectConditionId
        /// </summary>
        public System.Guid RedirectConditionId { get; set; }
        /// <summary>
        /// RedirectDimensionId
        /// </summary>
        public System.Guid RedirectDimensionId { get; set; }
        /// <summary>
        /// IsExclude
        /// </summary>
        public bool IsExclude { get; set; }
        /// <summary>
        /// SpotPlanGroup_SpotPlanGroupId
        /// </summary>
        public Nullable<System.Guid> SpotPlanGroup_SpotPlanGroupId { get; set; }
    
         /// <summary>
        /// RedirctConditionDetails
        /// </summary>
        public virtual ICollection<RedirectConditionDetail> RedirctConditionDetails { get; set; }
         /// <summary>
        /// AdSpotPlanGroup
        /// </summary>
        public virtual AdSpotPlanGroup AdSpotPlanGroup { get; set; }
         /// <summary>
        /// AdSpotPlanEdition
        /// </summary>
        public virtual AdSpotPlanEdition AdSpotPlanEdition { get; set; }
    }
}
