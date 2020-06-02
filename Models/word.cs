using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanbaApp.Models
{
    public class Word
    {
        public int ID { get; set; }

        [Display(Name = "Vanba")]
        [VanbaValidator]
        public string Text { get; set; }
        
        [Display(Name = "Nomen")]
        public string MeaningAsNoun { get; set; }
        
        [Display(Name = "Verb")]
        public string MeaningAsVerb { get; set; }
        
        [Display(Name = "Adjektiv")]
        public string MeaningAsAdjective { get; set; }

        [Display(Name = "Etymologie")]
        public string Etymology { get; set; }
    }
}