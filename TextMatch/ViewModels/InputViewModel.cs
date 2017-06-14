using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TextMatch.ViewModels
{
    public class InputViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Text { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Subtext { get; set; }
    }
}
