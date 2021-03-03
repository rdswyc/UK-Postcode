using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UK_Postcode.Models;
using UK_Postcode.Services;

namespace UK_Postcode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;
        private readonly PostcodeService _postcodeService;

        public AddressController(ILogger<AddressController> logger, PostcodeService postcodeService)
        {
            _logger = logger;
            _postcodeService = postcodeService;
        }

        [HttpGet("{code}")]
        public async Task<AddressViewModel> GetAsync([FromRoute] string code)
        {
            var address = await _postcodeService.GetAddress(code);
            _logger.LogInformation("Postcode received", code, address.ToString());
            return address;
        }
    }
}
