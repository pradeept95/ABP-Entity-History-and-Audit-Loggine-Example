using Abp.Auditing;
using Abp.Domain.Entities.Auditing; 
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditDemo.Models
{ 
    [Audited]
    public class AuditTestModel : AuditedEntity<Guid>
    { 
        public int MyProp1 { get; set; }
        public string MyProp2 { get; set; }
        public string MyProp3 { get; set; }

        [DisableAuditing]
        public string Password { get; set; }
    }
}
