using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanbaApp.Models
{
    public class Rule
    {
        public int ID { get; set; }

        [Display(Name = "Kurzbeschreibung")]
        public string ShortDescription { get; set; }
        
        [Display(Name = "Beschreibung")]
        public string Description { get; set; }
    }
}