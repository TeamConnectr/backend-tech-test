using System.Collections.Generic;

namespace Connectr.TechTests.Backend.EntityFramework.Models
{
    public class Planet
    {
        public int Id {  get; set; }

        public string Name {  get; set; }

        public int? Diameter { get; set; }

        public decimal? Gravity { get; set; }

        public int? OrbitalPeriod { get; set; }

        public long? Population { get; set; }

        public int? RotationPeriod { get; set; }

        public decimal? SurfaceWater { get; set; }

        public ICollection<Film> Films {  get; set; }

        public ICollection<Character> Residents { get; set; }
    }
}
