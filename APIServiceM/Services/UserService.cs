using APIServiceM.IServices;
using Entities.Entities;
using Entities.RequestModels;
using Logic.ILogic;

namespace APIServiceM.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public void DeleteUser(int id)
        {
            _userLogic.DeleteUser(id);
        }

        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

        public int InsertUser(NewUserRequest newUserRequest)
        {
            var newUserItem = newUserRequest.ToUserItem();
            return _userLogic.InsertUser(newUserItem);
        }

        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }
    }
}