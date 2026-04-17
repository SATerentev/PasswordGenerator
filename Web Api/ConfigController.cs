using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PassGeneratorService.Application.DTO;
using PassGeneratorService.Application.Settings;

namespace PassGeneratorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly PasswordSettings _settings;

        public ConfigController(IOptions<PasswordSettings> options)
        {
            _settings = options.Value;
        }

        [HttpGet("password")]
        public IActionResult GetConfig()
        {
            var response = new PasswordSettingsResponse 
            { 
                DefaultLength = _settings.DefaultLength, MaxLength = _settings.MaxLength, MinLength = _settings.MinLength 
            };

            return Ok(response);
        }
    }
}
