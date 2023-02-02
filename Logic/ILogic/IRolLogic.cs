using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IRolLogic
    {
        int InsertRol(RolItem rolItem);
        void UpdateRol(RolItem rolItem);
        void DeleteRol(int id);
        List<RolItem> GetAllRoles();
    }
}
