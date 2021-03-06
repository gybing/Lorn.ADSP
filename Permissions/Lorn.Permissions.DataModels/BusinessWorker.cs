//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.Permissions.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusinessWorker
    {
        public BusinessWorker()
        {
            this.Permissions = new HashSet<Permission>();
            this.ParentRBusinessWorkers = new HashSet<RBusinessWorker>();
            this.ChildRBusinessWorker = new HashSet<RBusinessWorker>();
        }
    
        public System.Guid BusinessWorkerId { get; set; }
        public bool Enabled { get; set; }
    
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<RBusinessWorker> ParentRBusinessWorkers { get; set; }
        public virtual ICollection<RBusinessWorker> ChildRBusinessWorker { get; set; }
    }
}
