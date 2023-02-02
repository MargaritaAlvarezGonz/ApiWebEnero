using APIServiceM.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIServiceM.Services
{
    public class RolService
    {
        public class RolServices : IRolService
        {
            private readonly IRolLogic _rolLogic;
            public RolServices(IRolLogic rolLogic)
            {
                _rolLogic = rolLogic;
            }

            void IRolService.DeleteRol(int id)
            {
                _rolLogic.DeleteRol(id);
            }

            List<RolItem> IRolService.GetAllRoles()
            {
                return _rolLogic.GetAllRoles();
            }

            int IRolService.InsertRol(RolItem rolItem)
            {
                _rolLogic.InsertRol(rolItem);
                return rolItem.Id;
            }

            void IRolService.UpdateRol(RolItem rolItem)
            {
                _rolLogic.UpdateRol(rolItem);
            }
        }
    }
}
