using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MvcApplication1.Models
{
    public class NotenViewModel
    {
        [Required(ErrorMessage = "Grade is reqired.")]
        [Range(1, 6, ErrorMessage = "Grade is not valid")]
        public double Note { get; set; }
        [Required(ErrorMessage = "Fach is required")]
        public string Fach { get; set; }
    }
}
