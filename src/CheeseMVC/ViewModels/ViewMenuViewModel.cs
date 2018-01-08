using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CheeseMVC.Models;

namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {
        [Required]
        [Display(Name = "Menu Name")]
        public Menu Menu { get; set; }
        public IList<CheeseMenu> Items { get; set; }
    }
}
