using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DartsTracker.Models
{
    public class Tournament
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(255)] 
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public List<Match> Matches { get; set; } = new List<Match>();
    }
}
