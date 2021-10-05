using System.Collections.Generic;

namespace Connectr.TechTests.Backend.EntityFramework.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name {  get; set; }

        public int? Height { get; set; }

        public int? Mass {  get; set; }

        public HairColor HairColor { get; set; }

        public EyeColor EyeColor {  get; set; }

        public string BirthYear { get; set;  }

        public Gender Gender {  get; set; }

        public Planet Homeworld { get; set; }

        public ICollection<Film> Films { get; set; }

        public ICollection<Species> Species {  get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

        public IEnumerable<Starship> Starships { get; set; }
    }
}
