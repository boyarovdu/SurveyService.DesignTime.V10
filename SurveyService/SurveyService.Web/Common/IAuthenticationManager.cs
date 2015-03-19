using System.Security.Principal;
using System.Web;
using SurveyService.Model.Entities;

namespace SurveyService.Web.Common
{
    public interface IAuthenticationHelper
    {
        HttpCookie ToCookie(UserEntity account, bool createPersistentCookie);

        IPrincipal TransformPrincipal(UserEntity accountType, IPrincipal user);
    }
}
