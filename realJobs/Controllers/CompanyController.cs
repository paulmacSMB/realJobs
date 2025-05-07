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

            // testing porpoises
            foreach (var item in companyUrlData)
            {
                Console.WriteLine($"Company: {item.CompanyName}");
                Console.WriteLine($"Domain: {item.Domain}");
                Console.WriteLine($"Job Search URL: {item.JobSearchUrl}");
                Console.WriteLine("Search Strategies:");
                foreach (var strategy in item.SearchStrategies)
                {
                    Console.WriteLine($"  - Type: {strategy.SearchType}, Example: {strategy.ExampleQuery}");
                }
                Console.WriteLine("------------------------");
            }

            return Ok(new {message = "Data Received", count = companyUrlData.Count });
        }
    }
}
