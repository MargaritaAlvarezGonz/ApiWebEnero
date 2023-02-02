using Entities.Entities;

namespace APIServiceM.IServices
{
    public interface IRolService
    {
        int InsertRol(RolItem rolItem);
        void UpdateRol(RolItem rolItem);
        void DeleteRol(int id);
        List<RolItem> GetAllRoles();
    }
}
