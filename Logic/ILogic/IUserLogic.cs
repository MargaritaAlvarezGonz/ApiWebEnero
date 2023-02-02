using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        int InsertUser(UserItem userItem);
        void UpdateUser(UserItem userItem);
        void DeleteUser(int id);
        List<UserItem> GetAllUsers();
        

    }
}
