using System.Threading.Tasks;
using Abp.Application.Services;
using AuditDemo.Sessions.Dto;

namespace AuditDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
