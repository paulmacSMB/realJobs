namespace Logic.DTOs
{
    public class SearchStrategyDto
    {
        public int StrategyId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string SearchType { get; set; }
        public string ExampleQuery { get; set; }
        public string Method { get; set; }
        public string MatchPattern { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public CompanyDto Company { get; set; }
    }
}
