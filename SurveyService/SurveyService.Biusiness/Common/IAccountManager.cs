using System.Linq;
using SurveyService.Model.Entities;

namespace SurveyService.Biusiness.Common
{
    public interface IAccountManager
    {
        IQueryable<UserEntity> QueryAll();

        UserEntity Load(long id);

        void Create(UserEntity instance, string password);

        void Delete(UserEntity instance);

        void Update(UserEntity instance);

        UserEntity FindByPasswordCredential(string username, string password);

        UserEntity FindByUsername(string username);

        void ChangePassword(UserEntity instance, string oldPassword, string newPassword);

        void ChangePassword(UserEntity instance, string newPassword, bool changeAfterSignin = false);

        bool CheckPassword(string password, UserEntity instance);

        //void CreatePasswordRestoreRequest(string email);

        //void CheckPasswordRestoreRequest(string email, string shortCode, out string authorizationCode);

        //void ValidatePasswordRestoreRequest(string authorizationCode);

        //void ValidateAndChangePassword(UserEntity account, string oldPassword, string newPassword);

        //void ChangePassword(string authorizationCode, string newPassword);
    }
}
