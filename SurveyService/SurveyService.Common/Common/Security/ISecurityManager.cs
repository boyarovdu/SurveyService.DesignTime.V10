using System.Security.Principal;

// ReSharper disable once CheckNamespace
namespace SurveyService.Common.Security
{
    public interface ISecurityManager
    {
        bool HasPermission(IPrincipal principal, string permission);


        long UserId(IIdentity identity);

        string Fullname(IIdentity identity);

        bool IsPasswordChangeRequired(IIdentity identity);

        string ToPermissionClaimName(string value);
    }
}
