using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AuditDemo.Models;
using System; 

namespace AuditDemo.AuditTest.Dto
{
    [AutoMapTo(typeof(AuditTestModel))]
    public class MyAuditTestDto : AuditedEntityDto<Guid>
    {
        public int MyProp1 { get; set; }
        public string MyProp2 { get; set; }
        public string MyProp3 { get; set; } 
        public string Password { get; set; }
    }
}
