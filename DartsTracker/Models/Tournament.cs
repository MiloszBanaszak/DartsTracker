using System;
using System.Collections.Generic;
namespace DartsTracker.Models
{
    public class Tournament
    {
        public int ID { get; set; } 
        public string Name { get; set; }    =string.Empty;  
        public DateTime Date { get; set; }
        public List<Match> Matches { get; set; } = new();
    }
}
