using System;
using System.Collections.Generic;

namespace Connectr.TechTests.Backend.EntityFramework.Models
{
    public class Film
    {
        public int Id { get; set; }

        public string Director { get; set; }

        public int Episode { get; set; }

        public string OpeningCrawl {  get; set; }

        public string Producer { get; set; }

        public DateTime ReleaseDate { get;set; }

        public string Title {  get; set; }

        public ICollection<Character> Characters { get; set; }

        public ICollection<Planet> Planets { get; set; }

        public ICollection<Species> Species { get; set; }

        public ICollection<Starship> Starships {  get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
