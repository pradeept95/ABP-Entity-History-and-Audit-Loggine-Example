using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AuditDemo.AuditTest.Dto;
using System;

namespace AuditDemo.AuditTest
{
    public interface IAuditTestAppService : IAsyncCrudAppService<MyAuditTestDto, Guid, PagedResultRequestDto, MyAuditTestDto, MyAuditTestDto>
    {
       
    }
}
