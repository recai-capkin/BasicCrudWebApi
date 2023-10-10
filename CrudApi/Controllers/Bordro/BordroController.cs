using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CrudApi.Controllers.Bordro
{
    [Route("api/[controller]")]
    [ApiController]
    public class BordroController : ControllerBase
    {
        [HttpGet("get-bordro")]
        public async Task<IActionResult> GetBordro()
        {
            return Ok("Bordro geldi");
        }
    }
}
