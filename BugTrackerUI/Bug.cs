using BugTrackerUI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public class Bug
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter Title.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter Description.")]
        [MinLength(10)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please enter Priority.")]
        [Range(1,5)]
        public int Priority { get; set; }
    }
}
