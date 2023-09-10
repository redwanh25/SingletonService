using Microsoft.AspNetCore.Mvc;
using SingletonService.Services;

namespace SingletonService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueSetController : Controller
    {
        private readonly IService _service;
        public ValueSetController(IService service)
        {
            _service = service;
        }

        [HttpPost("set-value/{policyNumber}")]
        public void SetValue(string policyNumber)
        {
            _service.SetPolicyNumber(policyNumber);
        }
    }
}
