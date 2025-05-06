namespace realJobs.DTOs
{
    public class SearchStrategyDto
    {
        public string CompanyName { get; set; }
        public string SearchType { get; set; }
        public string ExampleQuery { get; set; }
        public string Method { get; set; }
        public string MatchPattern { get; set; }
        public Dictionary<string, string> Headers { get; set; }
    }
}
