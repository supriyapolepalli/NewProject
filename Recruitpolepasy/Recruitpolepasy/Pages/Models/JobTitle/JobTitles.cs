using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Recruitpolepasy.Pages.Models.Candidate;
namespace Recruitpolepasy.Pages.Models.JobTitle
{
    public class JobTitles
    {
        public int JobTitleId { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        [StringLength(100)]
        public string TitleName { get; set; }

        public ICollection<Candidates> Candidates { get; set; } // Navigation Property
    }
}
