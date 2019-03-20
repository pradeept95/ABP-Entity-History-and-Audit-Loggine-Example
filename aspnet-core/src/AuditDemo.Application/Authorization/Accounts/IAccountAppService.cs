using System.Threading.Tasks;
using Abp.Application.Services;
using AuditDemo.Authorization.Accounts.Dto;

namespace AuditDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
