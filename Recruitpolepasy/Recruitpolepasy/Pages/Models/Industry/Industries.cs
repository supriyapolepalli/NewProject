using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Recruitpolepasy.Pages.Models.Candidate;
using Recruitpolepasy.Pages.Models.Company;
namespace Recruitpolepasy.Pages.Models.Industry
{
    public class Industries
    {
        public int IndustryId { get; set; }

        [Required]
        [Display(Name = "Industry Name")]
        [StringLength(100)]
        public string IndustryName { get; set; }

        public ICollection<Candidates> Candidates { get; set; } // Navigation Property
        public ICollection<Companies> Companies { get; set; } // Navigation Property
    }
}
