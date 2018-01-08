using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CheeseMVC.Models;

namespace CheeseMVC.ViewModels
{
    public class AddMenuViewModel
    {

        [Required]
        [Display(Name = "Menu Name")]
        public string Name { get; set; }
    }
}
