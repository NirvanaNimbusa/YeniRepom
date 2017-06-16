using System.Threading.Tasks;
using Abp.Application.Services;
using MyNewWebSite.Roles.Dto;

namespace MyNewWebSite.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
