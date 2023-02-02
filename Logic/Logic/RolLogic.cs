using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class RolLogic : IRolLogic

    {
        private readonly ServiceContext _serviceContext;
        public RolLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public void DeleteRol(int id)
        {
            var rolToDelete = _serviceContext.Set<RolItem>()
               .Where(u => u.Id == id).First();

            rolToDelete.IsActive = false;

            _serviceContext.SaveChanges();
        }

        public List<RolItem> GetAllRoles()
        {
            return _serviceContext.Set<RolItem>().ToList();
        }

        public int InsertRol(RolItem rolItem)
        {
            throw new NotImplementedException();
            //_serviceContext.Roles.Add(rolItem);
            //_serviceContext.SaveChanges();
            //return rolItem.Id;
        }

        public void UpdateRol(RolItem rolItem)
        {
            throw new NotImplementedException();
            //_serviceContext.Roles.Update(rolItem);
            //_serviceContext.SaveChanges();
        }
    }
}
