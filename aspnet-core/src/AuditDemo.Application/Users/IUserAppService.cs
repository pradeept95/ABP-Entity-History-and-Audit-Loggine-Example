using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AuditDemo.Roles.Dto;
using AuditDemo.Users.Dto;

namespace AuditDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
