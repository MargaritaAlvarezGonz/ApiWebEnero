using APIServiceM.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace APIServiceM.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RolController : ControllerBase
   
    {
        private ISecurityService _securityServices;
        private IRolService _rolServices;
        public RolController(ISecurityService securityServices, IRolService rolServices)
        {
            _securityServices = securityServices;
            _rolServices = rolServices;
        }

        [HttpPost(Name = "InsertRol")]
        public int Post([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] RolItem rolItem)
        {
            var validCredentials = _securityServices.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                return _rolServices.InsertRol(rolItem);
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }

        [HttpGet(Name = "GetRol")]
        public List<RolItem> GetAll([FromHeader] string userName, [FromHeader] string userPassword)
        {
            var validCredentials = _securityServices.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                return _rolServices.GetAllRoles();
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }

        [HttpPatch(Name = "ModifyRol")]
        public void Patch([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] RolItem rolItem)
        {
            var validCredentials = _securityServices.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                _rolServices.UpdateRol(rolItem);
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }

        [HttpDelete(Name = "DeleteRol")]
        public void Delete([FromHeader] string userName, [FromHeader] string userPassword, [FromQuery] int id)
        {
            var validCredentials = _securityServices.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                _rolServices.DeleteRol(id);
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }
    }
}
