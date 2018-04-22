using System;
using System.ComponentModel.DataAnnotations;

namespace Hub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; } // who is performing

        public DateTime DateTime { get; set; } //when gig is gonna happend

        [Required]
        [StringLength(255)]
        public string Venue { get; set; } // where is gonna happend

        [Required]
        public Genre Gengre { get; set; } // what genre is it
    }
}