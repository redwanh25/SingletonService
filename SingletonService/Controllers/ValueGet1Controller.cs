using Microsoft.AspNetCore.Mvc;
using SingletonService.Services;

namespace SingletonService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueGet1Controller : Controller
    {
        private readonly IService _service;
        public ValueGet1Controller(IService service)
        {
            _service = service;
        }

        [HttpGet("get-value")]
        public string GetValue()
        {
            return _service.GetPolicyNumber();
        }
    }
}
