using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SurveyService.Web.Areas.Main.Models
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [AdditionalMetadata("autofocus", true)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}