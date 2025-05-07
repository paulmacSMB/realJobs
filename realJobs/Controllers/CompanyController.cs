using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using realJobs.DTOs;

namespace realJobs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class CompanyController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CompanyDto companyUrlData)
        {
            if (companyUrlData.Equals(null))
                return BadRequest("Bad Request!");

            // testing porpoises

            Console.WriteLine($"Company: {companyUrlData.CompanyName}");
            Console.WriteLine($"Domain: {companyUrlData.Domain}");
            Console.WriteLine($"Job Search URL: {companyUrlData.JobSearchUrl}");
            Console.WriteLine("Search Strategies:");
            foreach (var strategy in companyUrlData.SearchStrategies)
            {
                Console.WriteLine($"  - Type: {strategy.SearchType}, Example: {strategy.ExampleQuery}");
            }
            Console.WriteLine("------------------------");

            return Ok(new { message = "Data Received" });
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] List<CompanyDto> companyUrlData)
        //{
        //    if (companyUrlData == null || companyUrlData.Count == 0)
        //        return BadRequest("No data received.");

        //    // testing porpoises
        //    foreach (var item in companyUrlData)
        //    {
        //        Console.WriteLine($"Company: {item.CompanyName}");
        //        Console.WriteLine($"Domain: {item.Domain}");
        //        Console.WriteLine($"Job Search URL: {item.JobSearchUrl}");
        //        Console.WriteLine("Search Strategies:");
        //        foreach (var strategy in item.SearchStrategies)
        //        {
        //            Console.WriteLine($"  - Type: {strategy.SearchType}, Example: {strategy.ExampleQuery}");
        //        }
        //        Console.WriteLine("------------------------");
        //    }

        //    return Ok(new { message = "Data Received", count = companyUrlData.Count });
        //}
        //[HttpPost]
        //public async Task<IActionResult> Post()
        //{
        //    using var reader = new StreamReader(Request.Body);
        //    var body = await reader.ReadToEndAsync();
        //    Console.WriteLine("Raw request body:");
        //    Console.WriteLine(body);

        //    return Ok();
        //}

    }
}
