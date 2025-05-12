using Logic.DTOs;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RealJobs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class CompanyController : ControllerBase
    {
        private ICompanyHandler _companyHandler;
        public CompanyController(ICompanyHandler companyHandler)
        {
            _companyHandler = companyHandler;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompanyAsync([FromBody] CompanyDto companyUrlData, CancellationToken cancellationToken)
        {
            if (companyUrlData.Equals(null))
                return BadRequest("Bad Request!");

            await _companyHandler.CreateCompanyAsync(companyUrlData, cancellationToken);


            return Ok(new { message = "Data Received" });
        }

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


//Console.WriteLine($"Company: {companyUrlData.CompanyName}");
//Console.WriteLine($"Domain: {companyUrlData.Domain}");
//Console.WriteLine($"Job Search URL: {companyUrlData.JobSearchUrl}");
//Console.WriteLine("Search Strategies:");
//foreach (var strategy in companyUrlData.SearchStrategies)
//{
//    Console.WriteLine($"  - Type: {strategy.SearchType}, Example: {strategy.ExampleQuery}");
//}
//Console.WriteLine("------------------------");
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
