﻿namespace Logic.DTOs
{
    public class CompanyDto
    {
        //public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Domain { get; set; }
        public string Subdomain { get; set; }
        public string JobSearchPath { get; set; }
        public string JobSearchUrl { get; set; }
        public DateTime LastVerified { get; set; }
        public string Notes { get; set; }

        public ICollection<SearchStrategyDto> SearchStrategies { get; set; } = new List<SearchStrategyDto>();
    }
}
