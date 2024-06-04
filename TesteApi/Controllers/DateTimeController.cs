using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace TesteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateTimeController : ControllerBase
    {
        public DateTimeController() { }
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                return Ok(await Task.FromResult(dateTime.ToString()));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Status = "Erro", Message = ex.Message });
            }
        }
    }
}
