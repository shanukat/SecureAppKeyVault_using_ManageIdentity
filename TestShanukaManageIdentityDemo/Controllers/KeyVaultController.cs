using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TestShanukaManageIdentityDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KeyVaultController : Controller
    {
        private readonly IKeyVaultManager _secretManager;
        public KeyVaultController(IKeyVaultManager secretManager)
        {
            _secretManager = secretManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string secretName)
        {

            try
            {
                if (string.IsNullOrEmpty(secretName))
                {
                    return BadRequest();
                }
                string secretValue = await _secretManager.GetSecret(secretName);

                if (!string.IsNullOrEmpty(secretValue))
                {
                    return Ok(secretValue);
                }
                else
                {

                    return NotFound("Secret key not found.");
                }

            }

            catch
            {

                return BadRequest("Error: Unable to read secret");

            }

        }
    }
}
