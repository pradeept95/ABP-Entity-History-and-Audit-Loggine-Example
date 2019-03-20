using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AuditDemo.MultiTenancy.Dto;

namespace AuditDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

