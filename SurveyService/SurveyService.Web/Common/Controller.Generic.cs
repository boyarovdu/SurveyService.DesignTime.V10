using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace SurveyService.Web.Common
{
    public class Controller<TManager> : Controller
        where TManager : class 
    {

        [Dependency]
        public ILocalizer Localizer { get; set; }

        [Dependency]
        public TManager Manager { get; set; }
    }
}