﻿
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Domain { get; set; }
        public string Subdomain { get; set; }
        public string JobSearchPath { get; set; }
        public string JobSearchUrl { get; set; }
        public DateTime LastVerified { get; set; }
        public string Notes { get; set; }

        public ICollection<SearchStrategy> SearchStrategies { get; set; } = new List<SearchStrategy>();
    }
}
