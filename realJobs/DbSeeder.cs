using Data.Models;
using Logic.DTOs;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace RealJobs
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<RealJobDbContext>();

            if (!context.SearchStrategies.Any())
            {

                var companyList = context.Companies.ToList();
                //var companiesJson = await File.ReadAllTextAsync("Companies.json");
                //var companies = JsonConvert.DeserializeObject<List<Company>>(companiesJson);

                //context.Companies.AddRange(companies);
                //await context.SaveChangesAsync();

                var strategiesJson = await File.ReadAllTextAsync("SearchStrategies.json");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };

                var rawStrategies = JsonSerializer.Deserialize<List<SearchStrategyDto>>(strategiesJson, options);

                var strategies = rawStrategies.Select(s =>
                {
                    var company = companyList.FirstOrDefault(c => c.CompanyName == s.CompanyName);
                    return new SearchStrategy
                    {
                        CompanyId = company.CompanyId,
                        CompanyName = s.CompanyName,
                        SearchType = s.SearchType,
                        ExampleQuery = s.ExampleQuery,
                        Method = s.Method,
                        MatchPattern = s.MatchPattern,
                        Headers = s.Headers,
                    };
                }).ToList();

                context.SearchStrategies.AddRange(strategies);
                await context.SaveChangesAsync();
            }
        }
    }
}