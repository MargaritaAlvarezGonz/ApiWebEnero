using Entities.Entities;
using Entities.RequestModels;
using System.Security.Cryptography;

namespace APIServiceM.IServices
{
    public interface IUserService
    {
        int InsertUser(NewUserRequest newUserRequest);
        void UpdateUser(UserItem userItem);
        void DeleteUser(int id);
        List<UserItem> GetAllUsers();
    }
}
