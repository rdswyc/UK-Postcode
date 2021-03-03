using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UK_Postcode.Models;
using UK_Postcode.Services;

namespace UK_Postcode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        private readonly ILogger<BaseController> _logger;
        private readonly PostcodeService _postcodeService;

        public BaseController(ILogger<BaseController> logger, PostcodeService postcodeService)
        {
            _logger = logger;
            _postcodeService = postcodeService;
        }

        [HttpGet("{code}")]
        public async Task<Postcode> GetAsync([FromRoute] string code)
        {
            var postcode = await _postcodeService.GetPostcode(code);
            _logger.LogInformation("Postcode received", postcode);
            return postcode;
        }
    }
}
