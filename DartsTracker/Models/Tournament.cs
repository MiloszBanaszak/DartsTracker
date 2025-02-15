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
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; } = DateTime.Today;

        public List<Match> Matches { get; set; } = new List<Match>();
    }
}
