using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using realJobs.DTOs;

namespace realJobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] List<CompanyDto> companyUrlData)
        {
            if (companyUrlData == null || companyUrlData.Count == 0)
                return BadRequest("No data received.");

            return Ok(new {message = "Data Received", count = companyUrlData.Count });
        }
    }
}
