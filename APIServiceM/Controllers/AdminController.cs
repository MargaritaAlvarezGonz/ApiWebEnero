using APIServiceM.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIServiceM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IAdminService _adminService;
        public AdminController(ILogger<AdminController> logger, IAdminService adminService)
        {
            _logger = logger;
            _adminService = adminService;
        }

        [HttpPost(Name = "InsertAdmin")]
        public int Post([FromBody]AdminItem adminItem)
        {
            return _adminService.InsertAdmin(adminItem);
        }
    }
}
