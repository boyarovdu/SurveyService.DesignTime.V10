using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyService.Web.Common
{
    public interface ILocalizer
    {
        string ErrorMessage(string key);
    }
}
