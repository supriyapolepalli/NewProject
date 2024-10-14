using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Recruitpolepasy.Pages.Models.Candidate;
using Recruitpolepasy.Pages.Models.Industry;

namespace Recruitpolepasy.Pages.Models.Company
{
    public class Companies
    {
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        [StringLength(100)]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Location")]
        [StringLength(200)]
        public string Location { get; set; }

        [Display(Name = "Industry")]
        public int IndustryId { get; set; }
        public Industries Industry { get; set; } // Navigation Property

        public ICollection<Candidates> Candidates { get; set; } // Navigation Property
    }
}
