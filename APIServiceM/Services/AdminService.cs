using APIServiceM.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIServiceM.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminLogic _adminLogic;
        public AdminService(IAdminLogic adminLogic)
        {
            _adminLogic = adminLogic;
        }
        public int InsertAdmin(AdminItem adminItem)
        {
            _adminLogic.InsertAdminItem(adminItem);
            return adminItem.Id;
        }
    }
}