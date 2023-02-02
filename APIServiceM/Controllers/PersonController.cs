using APIServiceM.IServices;
using Entities.Entities;
using Entities.SearchFilters;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace APIServiceM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase

    {

        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpPost(Name = "InsertPerson")]
        public int Post([FromBody] PersonItem personItem)
        {
            return _personService.InsertPerson(personItem);
        }

        [HttpGet(Name = "GetPerson")]
        public List<PersonItem> GetPerson()
        {
            return _personService.GetPerson();
        }

        
        [HttpDelete(Name = "DeletePerson")]

        public void DeletePersonItem([FromQuery] int id)
        {
            _personService.DeletePersonItem(id);
        }

        [HttpPatch(Name = "ModifyPerson")]
        public void Patch([FromBody] PersonItem personItem)
        {
            _personService.UpdatePerson(personItem);
        }
        //private ISecurityService _securityService;
        //private IPersonService _personService;

        //public PersonController(ISecurityService securityService, IPersonService personService)
        //{
        //    _securityService = securityService;
        //    _personService = personService;
        //}

        //[HttpPost(Name = "InsertPerson")]
        //public int Post([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] PersonItem personItem)
        //{
        //    var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
        //    if (validCredentials == true)
        //    {
        //        return _personService.InsertPerson(personItem);
        //    }
        //    else
        //    {
        //        throw new InvalidCredentialException();
        //    }
        //}

        //    [HttpPatch(Name = "ModifyPerson")]
        //    public void Patch([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] PersonItem personItem)
        //    {
        //        var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
        //        if (validCredentials == true)
        //        {
        //            _personService.UpdatePerson(personItem);
        //        }
        //        else
        //        {
        //            throw new InvalidCredentialException();
        //        }
        //    }
    } 
}
