using APIServiceM.IServices;
using Data;
using Logic.ILogic;

namespace APIServiceM.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly ISecurityLogic _securityLogic;
        public SecurityService(ServiceContext serviceContext, ISecurityLogic securityLogic)
        {
            //_serviceContext = serviceContext;
            _securityLogic = securityLogic;
        }
        public bool ValidateUserCredentials(string userName, string userPassWord, int idRol)
        {
            //esto iba en la lógica! upsi

            //sería así

            return _securityLogic.ValidateUserCredentials(userName, userPassWord, idRol);


            //var selectedUser =_serviceContext.Set<UserItem>()
            //                    .Where(u => u.Name == userName
            //                        && u.Password == userPassWord
            //                        && u.IdRol == idRol).FirstOrDefault();

            //if(selectedUser != null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
