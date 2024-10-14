namespace Recruitpolepasy.Pages.Models.Candidate;
using System;
using System.ComponentModel.DataAnnotations;
using Recruitpolepasy.Pages.Models.Company;
using Recruitpolepasy.Pages.Models.Industry;
using Recruitpolepasy.Pages.Models.JobTitle;

public class Candidates
{
    [Required]
    public int CandidateId { get; set; }

    [Required]
    [Display(Name = "First Name")]
    [StringLength(50)]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [Display(Name = "Email Address")]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [Display(Name = "Phone Number")]
    [Phone]
    public string PhoneNumber { get; set; }

    [Display(Name = "Job Title")]
    public int JobTitleId { get; set; }
    public JobTitles JobTitle { get; set; } // Navigation Property

    [Display(Name = "Company")]
    public int CompanyId { get; set; }
    public Companies Company { get; set; } // Navigation Property

    [Display(Name = "Industry")]
    public int IndustryId { get; set; }
    public Industries Industry { get; set; } // Navigation Property
}
