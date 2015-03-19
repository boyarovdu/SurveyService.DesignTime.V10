using Microsoft.Practices.Unity;
using SurveyService.Biusiness.Common;
using SurveyService.Common.Security;
using SurveyService.Model.Entities;
using SurveyService.Web.Areas.Main.Models;

namespace SurveyService.Web.Areas.Main.Controllers
{
    public class HomeManager
    {
        [Dependency]
        public IAccountManager AccountManager { get; set; }

        [Dependency]
        public ISecurityManager SecurityManager { get; set; }

        public UserEntity Signin(LoginModel model)
        {
            var user = AccountManager.FindByPasswordCredential(model.Email, model.Password);
            return user;
        }
    }
}