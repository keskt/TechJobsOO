using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class SearchJobsViewModel : BaseViewModel
    {
        // TODO #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel

        
        public List<Job> Jobs { get; set; }

        
        [Required(ErrorMessage = "Please provide a keyword for search. To browse all jobs, use the List -> All menu.")]
        [Display(Name = "Keyword:")]
        public string Value { get; set; } = "";

        public SearchJobsViewModel() : base()
        {
            Column = JobFieldType.All;
        }
    }
}