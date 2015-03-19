using System.Web.Mvc;
using Microsoft.Practices.Unity;
using SurveyService.Web.Areas.Main.Models;
using SurveyService.Web.Common;

namespace SurveyService.Web.Areas.Main.Controllers
{
    public class HomeController : Controller<HomeManager>
    {
        [Dependency]
        public IAuthenticationHelper AuthenticationHelper { get; set; }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Signin(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Signin(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = Manager.Signin(model);
                if (user != null)
                {
                    var cookie = AuthenticationHelper.ToCookie(user, model.RememberMe);
                    Response.Cookies.Add(cookie);

                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, Localizer.ErrorMessage("InvalidCredentials"));
            }

            return View(model);
        }
    }
}