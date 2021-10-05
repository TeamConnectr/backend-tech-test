using System.Collections.Generic;

namespace Connectr.TechTests.Backend.EntityFramework.Models
{
    public class Starship
    {
        public int Id {  get; set; }

        public string Name {  get; set; }

        public string Mglt {  get; set; }

        public long? CargoCapacity { get; set; }

        public string Consumables { get; set; }

        public long? CostInCredits { get; set; }

        public int? Crew { get; set; }

        public decimal? HyperdriveRating { get; set; }

        public int? Length { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int? Passengers { get; set; }    

        public string StarshipClass { get; set; }

        public ICollection<Film> Films { get; set; }

        public ICollection<Character> Pilots { get; set; }
    }
}
