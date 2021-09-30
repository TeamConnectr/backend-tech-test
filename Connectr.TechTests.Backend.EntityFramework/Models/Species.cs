using System.Collections.Generic;

namespace Connectr.TechTests.Backend.EntityFramework.Models
{
    public class Species
    {
        public int Id {  get; set; }

        public string Name {  get; set; }

        public decimal? AverageHeight { get; set; }

        public decimal? AverageLifespan { get; set; }

        public Classification Classification {  get; set; }

        public Designation Designation {  get; set; }

        public string Language {  get; set; }

        public int HomeworldId { get; set; }

        public ICollection<Character> People { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
