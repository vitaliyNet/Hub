using System;
using System.ComponentModel.DataAnnotations;

namespace Hub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public ApplicationUser Artist { get; set; } // who is performing

        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; } //when gig is gonna happend

        [Required]
        [StringLength(255)]
        public string Venue { get; set; } // where is gonna happend

        public Genre Gengre { get; set; } // what genre is it

        [Required]
        public byte GenreId { get; set; }
    }
}