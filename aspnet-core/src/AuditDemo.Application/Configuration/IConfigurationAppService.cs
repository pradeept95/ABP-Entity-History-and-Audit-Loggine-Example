using System.Threading.Tasks;
using AuditDemo.Configuration.Dto;

namespace AuditDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
