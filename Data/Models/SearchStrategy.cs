using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class SearchStrategy
    {
        [Key]
        public int StrategyId { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string SearchType { get; set; }
        public string ExampleQuery { get; set; }
        public string Method { get; set; }
        public string MatchPattern { get; set; }
        public Dictionary<string, string> Headers { get; set; }

        public Company Company { get; set; }

    }
}
