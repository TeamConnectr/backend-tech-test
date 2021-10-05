using Connectr.TechTests.Backend.EntityFramework.Models;
using System;
using System.Linq;

namespace Connectr.TechTests.Backend.EntityFramework
{
    public static class StarwarsDbInitializer
    {
        public static void Initialize(StarwarsDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Films.Any())
            {
                // Already have data
                return;
            }

            AddFilms(context);

            AddPlanets(context);

            AddCharacters(context);

            AddSpecies(context);

            AddStarships(context);

            AddVehicles(context);

            context.SaveChanges();
        }

        #region Helper methods for getting references

        private static Film GetFilm(StarwarsDbContext context, string title)
        {
            return context.Films.Local.SingleOrDefault(f => f.Title == title);
        }

        private static Character GetCharacter(StarwarsDbContext context, string name)
        {
            return context.Characters.Local.SingleOrDefault(c => c.Name == name);
        }

        private static Planet GetPlanet(StarwarsDbContext context, string name)
        {
            return context.Planets.Local.SingleOrDefault(c => c.Name == name);
        }

        #endregion

        #region Film Data

        private static void AddFilms(StarwarsDbContext context)
        {
            context.Films.AddRange(new Film[]
            {
                new Film
                {
                    Director = "George Lucas",
                    Episode = 4,
                    OpeningCrawl = "It is a period of civil war.\r\nRebel spaceships, striking\r\nfrom a hidden base, have won\r\ntheir first victory against\r\nthe evil Galactic Empire.\r\n\r\nDuring the battle, Rebel\r\nspies managed to steal secret\r\nplans to the Empire's\r\nultimate weapon, the DEATH\r\nSTAR, an armored space\r\nstation with enough power\r\nto destroy an entire planet.\r\n\r\nPursued by the Empire's\r\nsinister agents, Princess\r\nLeia races home aboard her\r\nstarship, custodian of the\r\nstolen plans that can save her\r\npeople and restore\r\nfreedom to the galaxy....",
                    Producer = "Gary Kurtz, Rick McCallum",
                    ReleaseDate = new DateTime(1977, 5, 25),
                    Title = "A New Hope"
                },
                new Film
                {
                    Director = "Irvin Kershner",
                    Episode = 5,
                    OpeningCrawl = "It is a dark time for the\r\nRebellion. Although the Death\r\nStar has been destroyed,\r\nImperial troops have driven the\r\nRebel forces from their hidden\r\nbase and pursued them across\r\nthe galaxy.\r\n\r\nEvading the dreaded Imperial\r\nStarfleet, a group of freedom\r\nfighters led by Luke Skywalker\r\nhas established a new secret\r\nbase on the remote ice world\r\nof Hoth.\r\n\r\nThe evil lord Darth Vader,\r\nobsessed with finding young\r\nSkywalker, has dispatched\r\nthousands of remote probes into\r\nthe far reaches of space....",
                    Producer = "Gary Kurtz, Rick McCallum",
                    ReleaseDate = new DateTime(1980, 5, 17),
                    Title = "The Empire Strikes Back"
                },
                new Film
                {
                    Director = "Richard Marquand",
                    Episode = 6,
                    OpeningCrawl = "Luke Skywalker has returned to\r\nhis home planet of Tatooine in\r\nan attempt to rescue his\r\nfriend Han Solo from the\r\nclutches of the vile gangster\r\nJabba the Hutt.\r\n\r\nLittle does Luke know that the\r\nGALACTIC EMPIRE has secretly\r\nbegun construction on a new\r\narmored space station even\r\nmore powerful than the first\r\ndreaded Death Star.\r\n\r\nWhen completed, this ultimate\r\nweapon will spell certain doom\r\nfor the small band of rebels\r\nstruggling to restore freedom\r\nto the galaxy...",
                    Producer = "Howard G. Kazanjian, George Lucas, Rick McCallum",
                    ReleaseDate = new DateTime(1983, 5, 25),
                    Title = "Return of the Jedi"
                },
                new Film
                {
                    Director = "George Lucas",
                    Episode = 1,
                    OpeningCrawl = "Turmoil has engulfed the\r\nGalactic Republic. The taxation\r\nof trade routes to outlying star\r\nsystems is in dispute.\r\n\r\nHoping to resolve the matter\r\nwith a blockade of deadly\r\nbattleships, the greedy Trade\r\nFederation has stopped all\r\nshipping to the small planet\r\nof Naboo.\r\n\r\nWhile the Congress of the\r\nRepublic endlessly debates\r\nthis alarming chain of events,\r\nthe Supreme Chancellor has\r\nsecretly dispatched two Jedi\r\nKnights, the guardians of\r\npeace and justice in the\r\ngalaxy, to settle the conflict....",
                    Producer = "Rick McCallum",
                    ReleaseDate = new DateTime(1999, 5, 19),
                    Title = "The Phantom Menace"
                },
                new Film
                {
                    Director = "George Lucas",
                    Episode = 2,
                    OpeningCrawl = "There is unrest in the Galactic\r\nSenate. Several thousand solar\r\nsystems have declared their\r\nintentions to leave the Republic.\r\n\r\nThis separatist movement,\r\nunder the leadership of the\r\nmysterious Count Dooku, has\r\nmade it difficult for the limited\r\nnumber of Jedi Knights to maintain \r\npeace and order in the galaxy.\r\n\r\nSenator Amidala, the former\r\nQueen of Naboo, is returning\r\nto the Galactic Senate to vote\r\non the critical issue of creating\r\nan ARMY OF THE REPUBLIC\r\nto assist the overwhelmed\r\nJedi....",
                    Producer = "Rick McCallum",
                    ReleaseDate = new DateTime(2002, 5, 16),
                    Title = "Attack of the Clones"
                },
                new Film
                {
                    Director = "George Lucas",
                    Episode = 3,
                    OpeningCrawl = "War! The Republic is crumbling\r\nunder attacks by the ruthless\r\nSith Lord, Count Dooku.\r\nThere are heroes on both sides.\r\nEvil is everywhere.\r\n\r\nIn a stunning move, the\r\nfiendish droid leader, General\r\nGrievous, has swept into the\r\nRepublic capital and kidnapped\r\nChancellor Palpatine, leader of\r\nthe Galactic Senate.\r\n\r\nAs the Separatist Droid Army\r\nattempts to flee the besieged\r\ncapital with their valuable\r\nhostage, two Jedi Knights lead a\r\ndesperate mission to rescue the\r\ncaptive Chancellor....",
                    Producer = "Rick McCallum",
                    ReleaseDate = new DateTime(2005, 5, 19),
                    Title = "Revenge of the Sith"
                },
            });
        }

        #endregion

        #region Planet Data

        private static void AddPlanets(StarwarsDbContext context)
        {
            context.Planets.AddRange(new Planet[]
            {
                new Planet
                {
                    Name = "Tatooine",
                    Diameter = 10465,
                    Gravity = null,
                    OrbitalPeriod = 304,
                    Population = 200000,
                    RotationPeriod = null,
                    SurfaceWater = 1m,
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Alderaan",
                    Diameter = 12500,
                    Gravity = null,
                    OrbitalPeriod = 364,
                    Population = 2000000000,
                    RotationPeriod = null,
                    SurfaceWater = 40m,
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Yavin IV",
                    Diameter = 10200,
                    Gravity = null,
                    OrbitalPeriod = 4818,
                    Population = 1000,
                    RotationPeriod = null,
                    SurfaceWater = 8m,
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Planet
                {
                    Name = "Hoth",
                    Diameter = 7200,
                    Gravity = null,
                    OrbitalPeriod = 549,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 100m,
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Planet
                {
                    Name = "Dagobah",
                    Diameter = 8900,
                    Gravity = null,
                    OrbitalPeriod = 341,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 8m,
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Bespin",
                    Diameter = 118000,
                    Gravity = null,
                    OrbitalPeriod = 5110,
                    Population = 6000000,
                    RotationPeriod = null,
                    SurfaceWater = 0m,
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Planet
                {
                    Name = "Endor",
                    Diameter = 4900,
                    Gravity = null,
                    OrbitalPeriod = 402,
                    Population = 30000000,
                    RotationPeriod = null,
                    SurfaceWater = 8m,
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Planet
                {
                    Name = "Naboo",
                    Diameter = 12120,
                    Gravity = null,
                    OrbitalPeriod = 312,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 12m,
                    Films = new Film[] { GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Coruscant",
                    Diameter = 12240,
                    Gravity = null,
                    OrbitalPeriod = 368,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] { GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Kamino",
                    Diameter = 19720,
                    Gravity = null,
                    OrbitalPeriod = 463,
                    Population = 1000000000,
                    RotationPeriod = null,
                    SurfaceWater = 100m,
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Planet
                {
                    Name = "Geonosis",
                    Diameter = 11370,
                    Gravity = null,
                    OrbitalPeriod = 256,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 5m,
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Planet
                {
                    Name = "Utapau",
                    Diameter = 12900,
                    Gravity = null,
                    OrbitalPeriod = 351,
                    Population = 95000000,
                    RotationPeriod = null,
                    SurfaceWater = 0.9m,
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Mustafar",
                    Diameter = 4200,
                    Gravity = null,
                    OrbitalPeriod = 412,
                    Population = 20000,
                    RotationPeriod = null,
                    SurfaceWater = 0m,
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Kashyyyk",
                    Diameter = 12765,
                    Gravity = null,
                    OrbitalPeriod = 381,
                    Population = 45000000,
                    RotationPeriod = null,
                    SurfaceWater = 60m,
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Polis Massa",
                    Diameter = 0,
                    Gravity = null,
                    OrbitalPeriod = 590,
                    Population = 1000000,
                    RotationPeriod = null,
                    SurfaceWater = 0m,
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Mygeeto",
                    Diameter = 10088,
                    Gravity = null,
                    OrbitalPeriod = 167,
                    Population = 19000000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Felucia",
                    Diameter = 9100,
                    Gravity = null,
                    OrbitalPeriod = 231,
                    Population = 8500000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Cato Neimoidia",
                    Diameter = 0,
                    Gravity = null,
                    OrbitalPeriod = 278,
                    Population = 10000000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Saleucami",
                    Diameter = 14920,
                    Gravity = null,
                    OrbitalPeriod = 392,
                    Population = 1400000000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Planet
                {
                    Name = "Stewjon",
                    Diameter = 0,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Eriadu",
                    Diameter = 13490,
                    Gravity = null,
                    OrbitalPeriod = 360,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Corellia",
                    Diameter = 11000,
                    Gravity = null,
                    OrbitalPeriod = 329,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 70m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Rodia",
                    Diameter = 7549,
                    Gravity = null,
                    OrbitalPeriod = 305,
                    Population = 1300000000,
                    RotationPeriod = null,
                    SurfaceWater = 60m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Nal Hutta",
                    Diameter = 12150,
                    Gravity = null,
                    OrbitalPeriod = 413,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Dantooine",
                    Diameter = 9830,
                    Gravity = null,
                    OrbitalPeriod = 378,
                    Population = 1000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Bestine IV",
                    Diameter = 6400,
                    Gravity = null,
                    OrbitalPeriod = 680,
                    Population = 62000000,
                    RotationPeriod = null,
                    SurfaceWater = 98m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Ord Mantell",
                    Diameter = 14050,
                    Gravity = null,
                    OrbitalPeriod = 334,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 10m,
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Planet
                {
                    Name = "unknown",
                    Diameter = 0,
                    Gravity = null,
                    OrbitalPeriod = 0,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Trandosha",
                    Diameter = 0,
                    Gravity = null,
                    OrbitalPeriod = 371,
                    Population = 42000000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Socorro",
                    Diameter = 0,
                    Gravity = null,
                    OrbitalPeriod = 326,
                    Population = 300000000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Mon Cala",
                    Diameter = 11030,
                    Gravity = 1m,
                    OrbitalPeriod = 398,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 100m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Chandrila",
                    Diameter = 13500,
                    Gravity = 1m,
                    OrbitalPeriod = 368,
                    Population = 1200000000,
                    RotationPeriod = null,
                    SurfaceWater = 40m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Sullust",
                    Diameter = 12780,
                    Gravity = 1m,
                    OrbitalPeriod = 263,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 5m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Toydaria",
                    Diameter = 7900,
                    Gravity = 1m,
                    OrbitalPeriod = 184,
                    Population = 11000000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Malastare",
                    Diameter = 18880,
                    Gravity = 1.56m,
                    OrbitalPeriod = 201,
                    Population = 2000000000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Dathomir",
                    Diameter = 10480,
                    Gravity = 0.9m,
                    OrbitalPeriod = 491,
                    Population = 5200,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Ryloth",
                    Diameter = 10600,
                    Gravity = 1m,
                    OrbitalPeriod = 305,
                    Population = 1500000000,
                    RotationPeriod = null,
                    SurfaceWater = 5m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Aleen Minor",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Vulpter",
                    Diameter = 14900,
                    Gravity = 1m,
                    OrbitalPeriod = 391,
                    Population = 421000000,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Troiken",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Tund",
                    Diameter = 12190,
                    Gravity = null,
                    OrbitalPeriod = 1770,
                    Population = 0,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Haruun Kal",
                    Diameter = 10120,
                    Gravity = 0.98m,
                    OrbitalPeriod = 383,
                    Population = 705300,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Cerea",
                    Diameter = null,
                    Gravity = 1m,
                    OrbitalPeriod = 386,
                    Population = 450000000,
                    RotationPeriod = null,
                    SurfaceWater = 20m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Glee Anselm",
                    Diameter = 15600,
                    Gravity = 1m,
                    OrbitalPeriod = 206,
                    Population = 500000000,
                    RotationPeriod = null,
                    SurfaceWater = 80m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Iridonia",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = 413,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Tholoth",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Iktotch",
                    Diameter = null,
                    Gravity = 1m,
                    OrbitalPeriod = 481,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Quermia",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Dorin",
                    Diameter = 13400,
                    Gravity = 1m,
                    OrbitalPeriod = 409,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Champala",
                    Diameter = null,
                    Gravity = 1m,
                    OrbitalPeriod = 318,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Mirial",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Serenno",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Concord Dawn",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Zolan",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Ojom",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = 500000000,
                    RotationPeriod = null,
                    SurfaceWater = 100m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Skako",
                    Diameter = null,
                    Gravity = 1m,
                    OrbitalPeriod = 384,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Muunilinst",
                    Diameter = 13800,
                    Gravity = 1m,
                    OrbitalPeriod = 412,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = 25m,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Shili",
                    Diameter = null,
                    Gravity = 1m,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Kalee",
                    Diameter = 13850,
                    Gravity = 1m,
                    OrbitalPeriod = 378,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                },
                new Planet
                {
                    Name = "Umbara",
                    Diameter = null,
                    Gravity = null,
                    OrbitalPeriod = null,
                    Population = null,
                    RotationPeriod = null,
                    SurfaceWater = null,
                    Films = new Film[] {  }
                }
            });
        }

        #endregion

        #region Character Data

        private static void AddCharacters(StarwarsDbContext context)
        {
            context.Characters.AddRange(new Character[]
            {
                new Character
                {
                    Name = "Luke Skywalker",
                    Height = 172,
                    Mass = 77,
                    HairColor = HairColor.Blond,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "19BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "C-3PO",
                    Height = 167,
                    Mass = 75,
                    HairColor = HairColor.NotApplicable,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "112BBY",
                    Gender = Gender.NotApplicable,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "R2-D2",
                    Height = 96,
                    Mass = 32,
                    HairColor = HairColor.NotApplicable,
                    EyeColor = EyeColor.Red,
                    BirthYear = "33BBY",
                    Gender = Gender.NotApplicable,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Darth Vader",
                    Height = 202,
                    Mass = 136,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "41.9BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Leia Organa",
                    Height = 150,
                    Mass = 49,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "19BBY",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Alderaan"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Owen Lars",
                    Height = 178,
                    Mass = 120,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "52BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Beru Whitesun lars",
                    Height = 165,
                    Mass = 75,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "47BBY",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "R5-D4",
                    Height = 97,
                    Mass = 32,
                    HairColor = HairColor.NotApplicable,
                    EyeColor = EyeColor.Red,
                    BirthYear = "unknown",
                    Gender = Gender.NotApplicable,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Character
                {
                    Name = "Biggs Darklighter",
                    Height = 183,
                    Mass = 84,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "24BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Character
                {
                    Name = "Obi-Wan Kenobi",
                    Height = 182,
                    Mass = 77,
                    HairColor = HairColor.Auburn,
                    EyeColor = EyeColor.BlueGrey,
                    BirthYear = "57BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Stewjon"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Anakin Skywalker",
                    Height = 188,
                    Mass = 84,
                    HairColor = HairColor.Blond,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "41.9BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Wilhuff Tarkin",
                    Height = 180,
                    Mass = null,
                    HairColor = HairColor.Auburn,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "64BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Eriadu"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Chewbacca",
                    Height = 228,
                    Mass = 112,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "200BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Kashyyyk"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Han Solo",
                    Height = 180,
                    Mass = 80,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "29BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Corellia"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Greedo",
                    Height = 173,
                    Mass = 74,
                    HairColor = HairColor.NotApplicable,
                    EyeColor = EyeColor.Black,
                    BirthYear = "44BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Rodia"),
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Character
                {
                    Name = "Jabba Desilijic Tiure",
                    Height = 175,
                    Mass = null,
                    HairColor = HairColor.NotApplicable,
                    EyeColor = EyeColor.Orange,
                    BirthYear = "600BBY",
                    Gender = Gender.Hermaphrodite,
                    Homeworld = GetPlanet(context, "Nal Hutta"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Wedge Antilles",
                    Height = 170,
                    Mass = 77,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Hazel,
                    BirthYear = "21BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Corellia"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Jek Tono Porkins",
                    Height = 180,
                    Mass = 110,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Bestine IV"),
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Character
                {
                    Name = "Yoda",
                    Height = 66,
                    Mass = 17,
                    HairColor = HairColor.White,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "896BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "unknown"),
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Palpatine",
                    Height = 170,
                    Mass = 75,
                    HairColor = HairColor.Grey,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "82BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Boba Fett",
                    Height = 183,
                    Mass = null,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "31.5BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Kamino"),
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "IG-88",
                    Height = 200,
                    Mass = 140,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Red,
                    BirthYear = "15BBY",
                    Gender = Gender.None,
                    Homeworld = GetPlanet(context, "unknown"),
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Character
                {
                    Name = "Bossk",
                    Height = 190,
                    Mass = 113,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Red,
                    BirthYear = "53BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Trandosha"),
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Character
                {
                    Name = "Lando Calrissian",
                    Height = 177,
                    Mass = 79,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "31BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Socorro"),
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Lobot",
                    Height = 175,
                    Mass = 79,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "37BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Bespin"),
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Character
                {
                    Name = "Ackbar",
                    Height = 180,
                    Mass = 83,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Orange,
                    BirthYear = "41BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Mon Cala"),
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Mon Mothma",
                    Height = 150,
                    Mass = null,
                    HairColor = HairColor.Auburn,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "48BBY",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Chandrila"),
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Arvel Crynyd",
                    Height = null,
                    Mass = null,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "unknown"),
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Wicket Systri Warrick",
                    Height = 88,
                    Mass = 20,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "8BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Endor"),
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Nien Nunb",
                    Height = 160,
                    Mass = 68,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Black,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Sullust"),
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Qui-Gon Jinn",
                    Height = 193,
                    Mass = 89,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "92BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "unknown"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Nute Gunray",
                    Height = 191,
                    Mass = 90,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Red,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Cato Neimoidia"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Finis Valorum",
                    Height = 170,
                    Mass = null,
                    HairColor = HairColor.Blond,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "91BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Coruscant"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Padmé Amidala",
                    Height = 185,
                    Mass = 45,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "46BBY",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Jar Jar Binks",
                    Height = 196,
                    Mass = 66,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Orange,
                    BirthYear = "52BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Roos Tarpals",
                    Height = 224,
                    Mass = 82,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Orange,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Rugor Nass",
                    Height = 206,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Orange,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Ric Olié",
                    Height = 183,
                    Mass = null,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Watto",
                    Height = 137,
                    Mass = null,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Toydaria"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Sebulba",
                    Height = 112,
                    Mass = 40,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Orange,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Malastare"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Quarsh Panaka",
                    Height = 183,
                    Mass = null,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "62BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Shmi Skywalker",
                    Height = 163,
                    Mass = null,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "72BBY",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Darth Maul",
                    Height = 175,
                    Mass = 80,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "54BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Dathomir"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Bib Fortuna",
                    Height = 180,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Pink,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Ryloth"),
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Character
                {
                    Name = "Ayla Secura",
                    Height = 178,
                    Mass = 55,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Hazel,
                    BirthYear = "48BBY",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Ryloth"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Ratts Tyerel",
                    Height = 79,
                    Mass = 15,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Unknown,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Aleen Minor"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Dud Bolt",
                    Height = 94,
                    Mass = 45,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Vulpter"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Gasgano",
                    Height = 122,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Black,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Troiken"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Ben Quadinaros",
                    Height = 163,
                    Mass = 65,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Orange,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Tund"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Mace Windu",
                    Height = 188,
                    Mass = 84,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "72BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Haruun Kal"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Ki-Adi-Mundi",
                    Height = 198,
                    Mass = 82,
                    HairColor = HairColor.White,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "92BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Cerea"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Kit Fisto",
                    Height = 196,
                    Mass = 87,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Black,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Glee Anselm"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Eeth Koth",
                    Height = 171,
                    Mass = null,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Iridonia"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Adi Gallia",
                    Height = 184,
                    Mass = 50,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Coruscant"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Saesee Tiin",
                    Height = 188,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Orange,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Iktotch"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Yarael Poof",
                    Height = 264,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Quermia"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Character
                {
                    Name = "Plo Koon",
                    Height = 188,
                    Mass = 80,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Black,
                    BirthYear = "22BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Dorin"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Mas Amedda",
                    Height = 196,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Champala"),
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Gregar Typho",
                    Height = 185,
                    Mass = 85,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Cordé",
                    Height = 157,
                    Mass = null,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Cliegg Lars",
                    Height = 183,
                    Mass = null,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "82BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Tatooine"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Poggle the Lesser",
                    Height = 183,
                    Mass = 80,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Geonosis"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Luminara Unduli",
                    Height = 170,
                    Mass = null,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "58BBY",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Mirial"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Barriss Offee",
                    Height = 166,
                    Mass = 50,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "40BBY",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Mirial"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Dormé",
                    Height = 165,
                    Mass = null,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Naboo"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Dooku",
                    Height = 193,
                    Mass = 80,
                    HairColor = HairColor.White,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "102BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Serenno"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Bail Prestor Organa",
                    Height = 191,
                    Mass = null,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "67BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Alderaan"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Jango Fett",
                    Height = 183,
                    Mass = 79,
                    HairColor = HairColor.Black,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "66BBY",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Concord Dawn"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Zam Wesell",
                    Height = 168,
                    Mass = 55,
                    HairColor = HairColor.Blond,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Zolan"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Dexter Jettster",
                    Height = 198,
                    Mass = 102,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Yellow,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Ojom"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Lama Su",
                    Height = 229,
                    Mass = 88,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Black,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Kamino"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Taun We",
                    Height = 213,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Black,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Kamino"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Jocasta Nu",
                    Height = 167,
                    Mass = null,
                    HairColor = HairColor.White,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Coruscant"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "R4-P17",
                    Height = 96,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Red,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "unknown"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Wat Tambor",
                    Height = 193,
                    Mass = 48,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Unknown,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Skako"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "San Hill",
                    Height = 191,
                    Mass = null,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Gold,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Muunilinst"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Character
                {
                    Name = "Shaak Ti",
                    Height = 178,
                    Mass = 57,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Black,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Shili"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Grievous",
                    Height = 216,
                    Mass = 159,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Green,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Kalee"),
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Tarfful",
                    Height = 234,
                    Mass = 136,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Blue,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Kashyyyk"),
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Raymus Antilles",
                    Height = 188,
                    Mass = 79,
                    HairColor = HairColor.Brown,
                    EyeColor = EyeColor.Brown,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Alderaan"),
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Sly Moore",
                    Height = 178,
                    Mass = 48,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.White,
                    BirthYear = "unknown",
                    Gender = Gender.Female,
                    Homeworld = GetPlanet(context, "Umbara"),
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Character
                {
                    Name = "Tion Medon",
                    Height = 206,
                    Mass = 80,
                    HairColor = HairColor.None,
                    EyeColor = EyeColor.Black,
                    BirthYear = "unknown",
                    Gender = Gender.Male,
                    Homeworld = GetPlanet(context, "Utapau"),
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                }
            });
        }

        #endregion

        #region Species Data

        private static void AddSpecies(StarwarsDbContext context)
        {
            context.Species.AddRange(new Species[]
            {
                new Species
                {
                    Name = "Human",
                    AverageHeight = 180m,
                    AverageLifespan = 120m,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Galactic Basic",
                    Homeworld = GetPlanet(context, "Coruscant"),
                    People = new Character[] { GetCharacter(context, "Dormé"), GetCharacter(context, "Dooku"), GetCharacter(context, "Bail Prestor Organa"), GetCharacter(context, "Jocasta Nu") },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Droid",
                    AverageHeight = null,
                    AverageLifespan = null,
                    Classification = Classification.Artificial,
                    Designation = Designation.Sentient,
                    Language = "n/a",
                    Homeworld = null,
                    People = new Character[] { GetCharacter(context, "C-3PO"), GetCharacter(context, "R2-D2"), GetCharacter(context, "R5-D4"), GetCharacter(context, "IG-88") },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Wookie",
                    AverageHeight = 210m,
                    AverageLifespan = 400m,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Shyriiwook",
                    Homeworld = GetPlanet(context, "Kashyyyk"),
                    People = new Character[] { GetCharacter(context, "Chewbacca"), GetCharacter(context, "Tarfful") },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Rodian",
                    AverageHeight = 170m,
                    AverageLifespan = null,
                    Classification = Classification.Sentient,
                    Designation = Designation.Reptilian,
                    Language = "Galatic Basic",
                    Homeworld = GetPlanet(context, "Rodia"),
                    People = new Character[] { GetCharacter(context, "Greedo") },
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Species
                {
                    Name = "Hutt",
                    AverageHeight = 300m,
                    AverageLifespan = 1000m,
                    Classification = Classification.Gastropod,
                    Designation = Designation.Sentient,
                    Language = "Huttese",
                    Homeworld = GetPlanet(context, "Nal Hutta"),
                    People = new Character[] { GetCharacter(context, "Jabba Desilijic Tiure") },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Return of the Jedi") }
                },
                new Species
                {
                    Name = "Yoda's species",
                    AverageHeight = 66m,
                    AverageLifespan = 900m,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Galactic basic",
                    Homeworld = GetPlanet(context, "unknown"),
                    People = new Character[] { GetCharacter(context, "Yoda") },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Trandoshan",
                    AverageHeight = 200m,
                    AverageLifespan = null,
                    Classification = Classification.Reptile,
                    Designation = Designation.Sentient,
                    Language = "Dosh",
                    Homeworld = GetPlanet(context, "Trandosha"),
                    People = new Character[] { GetCharacter(context, "Bossk") },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Species
                {
                    Name = "Mon Calamari",
                    AverageHeight = 160m,
                    AverageLifespan = null,
                    Classification = Classification.Amphibian,
                    Designation = Designation.Sentient,
                    Language = "Mon Calamarian",
                    Homeworld = GetPlanet(context, "Mon Cala"),
                    People = new Character[] { GetCharacter(context, "Ackbar") },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Species
                {
                    Name = "Ewok",
                    AverageHeight = 100m,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Ewokese",
                    Homeworld = GetPlanet(context, "Endor"),
                    People = new Character[] { GetCharacter(context, "Wicket Systri Warrick") },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Species
                {
                    Name = "Sullustan",
                    AverageHeight = 180m,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Sullutese",
                    Homeworld = GetPlanet(context, "Sullust"),
                    People = new Character[] { GetCharacter(context, "Nien Nunb") },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Species
                {
                    Name = "Neimodian",
                    AverageHeight = 180m,
                    AverageLifespan = null,
                    Classification = Classification.Unknown,
                    Designation = Designation.Sentient,
                    Language = "Neimoidia",
                    Homeworld = GetPlanet(context, "Cato Neimoidia"),
                    People = new Character[] { GetCharacter(context, "Nute Gunray") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Species
                {
                    Name = "Gungan",
                    AverageHeight = 190m,
                    AverageLifespan = null,
                    Classification = Classification.Amphibian,
                    Designation = Designation.Sentient,
                    Language = "Gungan basic",
                    Homeworld = GetPlanet(context, "Naboo"),
                    People = new Character[] { GetCharacter(context, "Jar Jar Binks"), GetCharacter(context, "Roos Tarpals"), GetCharacter(context, "Rugor Nass") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones") }
                },
                new Species
                {
                    Name = "Toydarian",
                    AverageHeight = 120m,
                    AverageLifespan = 91m,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Toydarian",
                    Homeworld = GetPlanet(context, "Toydaria"),
                    People = new Character[] { GetCharacter(context, "Watto") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones") }
                },
                new Species
                {
                    Name = "Dug",
                    AverageHeight = 100m,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Dugese",
                    Homeworld = GetPlanet(context, "Malastare"),
                    People = new Character[] { GetCharacter(context, "Sebulba") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Species
                {
                    Name = "Twi'lek",
                    AverageHeight = 200m,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Twi'leki",
                    Homeworld = GetPlanet(context, "Ryloth"),
                    People = new Character[] { GetCharacter(context, "Bib Fortuna"), GetCharacter(context, "Ayla Secura") },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi"), GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Aleena",
                    AverageHeight = 80m,
                    AverageLifespan = 79m,
                    Classification = Classification.Reptile,
                    Designation = Designation.Sentient,
                    Language = "Aleena",
                    Homeworld = GetPlanet(context, "Aleen Minor"),
                    People = new Character[] { GetCharacter(context, "Ratts Tyerel") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Species
                {
                    Name = "Vulptereen",
                    AverageHeight = 100m,
                    AverageLifespan = null,
                    Classification = Classification.Unknown,
                    Designation = Designation.Sentient,
                    Language = "vulpterish",
                    Homeworld = GetPlanet(context, "Vulpter"),
                    People = new Character[] { GetCharacter(context, "Dud Bolt") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Species
                {
                    Name = "Xexto",
                    AverageHeight = 125m,
                    AverageLifespan = null,
                    Classification = Classification.Unknown,
                    Designation = Designation.Sentient,
                    Language = "Xextese",
                    Homeworld = GetPlanet(context, "Troiken"),
                    People = new Character[] { GetCharacter(context, "Gasgano") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Species
                {
                    Name = "Toong",
                    AverageHeight = 200m,
                    AverageLifespan = null,
                    Classification = Classification.Unknown,
                    Designation = Designation.Sentient,
                    Language = "Tundan",
                    Homeworld = GetPlanet(context, "Tund"),
                    People = new Character[] { GetCharacter(context, "Ben Quadinaros") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Cerean",
                    AverageHeight = 200m,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Cerean",
                    Homeworld = GetPlanet(context, "Cerea"),
                    People = new Character[] { GetCharacter(context, "Ki-Adi-Mundi") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Nautolan",
                    AverageHeight = 180m,
                    AverageLifespan = 70m,
                    Classification = Classification.Amphibian,
                    Designation = Designation.Sentient,
                    Language = "Nautila",
                    Homeworld = GetPlanet(context, "Glee Anselm"),
                    People = new Character[] { GetCharacter(context, "Kit Fisto") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Species
                {
                    Name = "Zabrak",
                    AverageHeight = 180m,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Zabraki",
                    Homeworld = GetPlanet(context, "Iridonia"),
                    People = new Character[] { GetCharacter(context, "Darth Maul"), GetCharacter(context, "Eeth Koth") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Species
                {
                    Name = "Tholothian",
                    AverageHeight = null,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "unknown",
                    Homeworld = GetPlanet(context, "Tholoth"),
                    People = new Character[] { GetCharacter(context, "Adi Gallia") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Iktotchi",
                    AverageHeight = 180m,
                    AverageLifespan = null,
                    Classification = Classification.Unknown,
                    Designation = Designation.Sentient,
                    Language = "Iktotchese",
                    Homeworld = GetPlanet(context, "Iktotch"),
                    People = new Character[] { GetCharacter(context, "Saesee Tiin") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Quermian",
                    AverageHeight = 240m,
                    AverageLifespan = 86m,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Quermian",
                    Homeworld = GetPlanet(context, "Quermia"),
                    People = new Character[] { GetCharacter(context, "Yarael Poof") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Kel Dor",
                    AverageHeight = 180m,
                    AverageLifespan = 70m,
                    Classification = Classification.Unknown,
                    Designation = Designation.Sentient,
                    Language = "Kel Dor",
                    Homeworld = GetPlanet(context, "Dorin"),
                    People = new Character[] { GetCharacter(context, "Plo Koon") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Chagrian",
                    AverageHeight = 190m,
                    AverageLifespan = null,
                    Classification = Classification.Amphibian,
                    Designation = Designation.Sentient,
                    Language = "Chagria",
                    Homeworld = GetPlanet(context, "Champala"),
                    People = new Character[] { GetCharacter(context, "Mas Amedda") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Geonosian",
                    AverageHeight = 178m,
                    AverageLifespan = null,
                    Classification = Classification.Insectoid,
                    Designation = Designation.Sentient,
                    Language = "Geonosian",
                    Homeworld = GetPlanet(context, "Geonosis"),
                    People = new Character[] { GetCharacter(context, "Poggle the Lesser") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Mirialan",
                    AverageHeight = 180m,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Mirialan",
                    Homeworld = GetPlanet(context, "Mirial"),
                    People = new Character[] { GetCharacter(context, "Luminara Unduli"), GetCharacter(context, "Barriss Offee") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Clawdite",
                    AverageHeight = 180m,
                    AverageLifespan = 70m,
                    Classification = Classification.Reptilian,
                    Designation = Designation.Sentient,
                    Language = "Clawdite",
                    Homeworld = GetPlanet(context, "Zolan"),
                    People = new Character[] { GetCharacter(context, "Zam Wesell") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Besalisk",
                    AverageHeight = 178m,
                    AverageLifespan = 75m,
                    Classification = Classification.Amphibian,
                    Designation = Designation.Sentient,
                    Language = "besalisk",
                    Homeworld = GetPlanet(context, "Ojom"),
                    People = new Character[] { GetCharacter(context, "Dexter Jettster") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Species
                {
                    Name = "Kaminoan",
                    AverageHeight = 220m,
                    AverageLifespan = 80m,
                    Classification = Classification.Amphibian,
                    Designation = Designation.Sentient,
                    Language = "Kaminoan",
                    Homeworld = GetPlanet(context, "Kamino"),
                    People = new Character[] { GetCharacter(context, "Lama Su"), GetCharacter(context, "Taun We") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Species
                {
                    Name = "Skakoan",
                    AverageHeight = null,
                    AverageLifespan = null,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Skakoan",
                    Homeworld = GetPlanet(context, "Skako"),
                    People = new Character[] { GetCharacter(context, "Wat Tambor") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Muun",
                    AverageHeight = 190m,
                    AverageLifespan = 100m,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Muun",
                    Homeworld = GetPlanet(context, "Muunilinst"),
                    People = new Character[] { GetCharacter(context, "San Hill") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Togruta",
                    AverageHeight = 180m,
                    AverageLifespan = 94m,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Togruti",
                    Homeworld = GetPlanet(context, "Shili"),
                    People = new Character[] { GetCharacter(context, "Shaak Ti") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Kaleesh",
                    AverageHeight = 170m,
                    AverageLifespan = 80m,
                    Classification = Classification.Reptile,
                    Designation = Designation.Sentient,
                    Language = "Kaleesh",
                    Homeworld = GetPlanet(context, "Kalee"),
                    People = new Character[] { GetCharacter(context, "Grievous") },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Species
                {
                    Name = "Pau'an",
                    AverageHeight = 190m,
                    AverageLifespan = 700m,
                    Classification = Classification.Mammal,
                    Designation = Designation.Sentient,
                    Language = "Utapese",
                    Homeworld = GetPlanet(context, "Utapau"),
                    People = new Character[] { GetCharacter(context, "Tion Medon") },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                }
            });
        }

        #endregion

        #region Starship Data

        private static void AddStarships(StarwarsDbContext context)
        {
            context.Starships.AddRange(new Starship[]
            {
                new Starship
                {
                    Name = "CR90 corvette",
                    Mglt = "60",
                    CargoCapacity = 3000000,
                    Consumables = "1 year",
                    CostInCredits = 3500000,
                    Crew = null,
                    HyperdriveRating = 2m,
                    Length = 150,
                    Manufacturer = "Corellian Engineering Corporation",
                    Model = "CR90 corvette",
                    Passengers = 600,
                    StarshipClass = "corvette",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Return of the Jedi"), GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "Star Destroyer",
                    Mglt = "60",
                    CargoCapacity = 36000000,
                    Consumables = "2 years",
                    CostInCredits = 150000000,
                    Crew = null,
                    HyperdriveRating = 2m,
                    Length = null,
                    Manufacturer = "Kuat Drive Yards",
                    Model = "Imperial I-class Star Destroyer",
                    Passengers = null,
                    StarshipClass = "Star Destroyer",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "Sentinel-class landing craft",
                    Mglt = "70",
                    CargoCapacity = 180000,
                    Consumables = "1 month",
                    CostInCredits = 240000,
                    Crew = 5,
                    HyperdriveRating = 1m,
                    Length = 38,
                    Manufacturer = "Sienar Fleet Systems, Cyngus Spaceworks",
                    Model = "Sentinel-class landing craft",
                    Passengers = 75,
                    StarshipClass = "landing craft",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Starship
                {
                    Name = "Death Star",
                    Mglt = "10",
                    CargoCapacity = 1000000000000,
                    Consumables = "3 years",
                    CostInCredits = 1000000000000,
                    Crew = null,
                    HyperdriveRating = 4m,
                    Length = 120000,
                    Manufacturer = "Imperial Department of Military Research, Sienar Fleet Systems",
                    Model = "DS-1 Orbital Battle Station",
                    Passengers = null,
                    StarshipClass = "Deep Space Mobile Battlestation",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Starship
                {
                    Name = "Millennium Falcon",
                    Mglt = "75",
                    CargoCapacity = 100000,
                    Consumables = "2 months",
                    CostInCredits = 100000,
                    Crew = 4,
                    HyperdriveRating = 0.5m,
                    Length = null,
                    Manufacturer = "Corellian Engineering Corporation",
                    Model = "YT-1300 light freighter",
                    Passengers = 6,
                    StarshipClass = "Light freighter",
                    Pilots = new Character[] { GetCharacter(context, "Chewbacca"), GetCharacter(context, "Han Solo"), GetCharacter(context, "Lando Calrissian"), GetCharacter(context, "Nien Nunb") },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "Y-wing",
                    Mglt = "80",
                    CargoCapacity = 110,
                    Consumables = "1 week",
                    CostInCredits = 134999,
                    Crew = 2,
                    HyperdriveRating = 1m,
                    Length = 14,
                    Manufacturer = "Koensayr Manufacturing",
                    Model = "BTL Y-wing",
                    Passengers = 0,
                    StarshipClass = "assault starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "X-wing",
                    Mglt = "100",
                    CargoCapacity = 110,
                    Consumables = "1 week",
                    CostInCredits = 149999,
                    Crew = 1,
                    HyperdriveRating = 1m,
                    Length = null,
                    Manufacturer = "Incom Corporation",
                    Model = "T-65 X-wing",
                    Passengers = 0,
                    StarshipClass = "Starfighter",
                    Pilots = new Character[] { GetCharacter(context, "Luke Skywalker"), GetCharacter(context, "Biggs Darklighter"), GetCharacter(context, "Wedge Antilles"), GetCharacter(context, "Jek Tono Porkins") },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "TIE Advanced x1",
                    Mglt = "105",
                    CargoCapacity = 150,
                    Consumables = "5 days",
                    CostInCredits = null,
                    Crew = 1,
                    HyperdriveRating = 1m,
                    Length = null,
                    Manufacturer = "Sienar Fleet Systems",
                    Model = "Twin Ion Engine Advanced x1",
                    Passengers = 0,
                    StarshipClass = "Starfighter",
                    Pilots = new Character[] { GetCharacter(context, "Darth Vader") },
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Starship
                {
                    Name = "Executor",
                    Mglt = "40",
                    CargoCapacity = 250000000,
                    Consumables = "6 years",
                    CostInCredits = 1143350000,
                    Crew = null,
                    HyperdriveRating = 2m,
                    Length = 19000,
                    Manufacturer = "Kuat Drive Yards, Fondor Shipyards",
                    Model = "Executor-class star dreadnought",
                    Passengers = 38000,
                    StarshipClass = "Star dreadnought",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "Rebel transport",
                    Mglt = "20",
                    CargoCapacity = 19000000,
                    Consumables = "6 months",
                    CostInCredits = null,
                    Crew = 6,
                    HyperdriveRating = 4m,
                    Length = 90,
                    Manufacturer = "Gallofree Yards, Inc.",
                    Model = "GR-75 medium transport",
                    Passengers = 90,
                    StarshipClass = "Medium transport",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "Slave 1",
                    Mglt = "70",
                    CargoCapacity = 70000,
                    Consumables = "1 month",
                    CostInCredits = null,
                    Crew = 1,
                    HyperdriveRating = 3m,
                    Length = null,
                    Manufacturer = "Kuat Systems Engineering",
                    Model = "Firespray-31-class patrol and attack",
                    Passengers = 6,
                    StarshipClass = "Patrol craft",
                    Pilots = new Character[] { GetCharacter(context, "Boba Fett") },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Attack of the Clones") }
                },
                new Starship
                {
                    Name = "Imperial shuttle",
                    Mglt = "50",
                    CargoCapacity = 80000,
                    Consumables = "2 months",
                    CostInCredits = 240000,
                    Crew = 6,
                    HyperdriveRating = 1m,
                    Length = 20,
                    Manufacturer = "Sienar Fleet Systems",
                    Model = "Lambda-class T-4a shuttle",
                    Passengers = 20,
                    StarshipClass = "Armed government transport",
                    Pilots = new Character[] { GetCharacter(context, "Luke Skywalker"), GetCharacter(context, "Chewbacca"), GetCharacter(context, "Han Solo") },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "EF76 Nebulon-B escort frigate",
                    Mglt = "40",
                    CargoCapacity = 6000000,
                    Consumables = "2 years",
                    CostInCredits = 8500000,
                    Crew = 854,
                    HyperdriveRating = 2m,
                    Length = 300,
                    Manufacturer = "Kuat Drive Yards",
                    Model = "EF76 Nebulon-B escort frigate",
                    Passengers = 75,
                    StarshipClass = "Escort ship",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "Calamari Cruiser",
                    Mglt = "60",
                    CargoCapacity = null,
                    Consumables = "2 years",
                    CostInCredits = 104000000,
                    Crew = 5400,
                    HyperdriveRating = 1m,
                    Length = 1200,
                    Manufacturer = "Mon Calamari shipyards",
                    Model = "MC80 Liberty type Star Cruiser",
                    Passengers = 1200,
                    StarshipClass = "Star Cruiser",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "A-wing",
                    Mglt = "120",
                    CargoCapacity = 40,
                    Consumables = "1 week",
                    CostInCredits = 175000,
                    Crew = 1,
                    HyperdriveRating = 1m,
                    Length = null,
                    Manufacturer = "Alliance Underground Engineering, Incom Corporation",
                    Model = "RZ-1 A-wing Interceptor",
                    Passengers = 0,
                    StarshipClass = "Starfighter",
                    Pilots = new Character[] { GetCharacter(context, "Arvel Crynyd") },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "B-wing",
                    Mglt = "91",
                    CargoCapacity = 45,
                    Consumables = "1 week",
                    CostInCredits = 220000,
                    Crew = 1,
                    HyperdriveRating = 2m,
                    Length = null,
                    Manufacturer = "Slayn & Korpil",
                    Model = "A/SF-01 B-wing starfighter",
                    Passengers = 0,
                    StarshipClass = "Assault Starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Starship
                {
                    Name = "Republic Cruiser",
                    Mglt = "unknown",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 9,
                    HyperdriveRating = 2m,
                    Length = 115,
                    Manufacturer = "Corellian Engineering Corporation",
                    Model = "Consular-class cruiser",
                    Passengers = 16,
                    StarshipClass = "Space cruiser",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Starship
                {
                    Name = "Droid control ship",
                    Mglt = "unknown",
                    CargoCapacity = 4000000000,
                    Consumables = "500 days",
                    CostInCredits = null,
                    Crew = 175,
                    HyperdriveRating = 2m,
                    Length = 3170,
                    Manufacturer = "Hoersch-Kessel Drive, Inc.",
                    Model = "Lucrehulk-class Droid Control Ship",
                    Passengers = 139000,
                    StarshipClass = "Droid control ship",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "Naboo fighter",
                    Mglt = "unknown",
                    CargoCapacity = 65,
                    Consumables = "7 days",
                    CostInCredits = 200000,
                    Crew = 1,
                    HyperdriveRating = 1m,
                    Length = 11,
                    Manufacturer = "Theed Palace Space Vessel Engineering Corps",
                    Model = "N-1 starfighter",
                    Passengers = 0,
                    StarshipClass = "Starfighter",
                    Pilots = new Character[] { GetCharacter(context, "Anakin Skywalker"), GetCharacter(context, "Padmé Amidala"), GetCharacter(context, "Gregar Typho") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Attack of the Clones") }
                },
                new Starship
                {
                    Name = "Naboo Royal Starship",
                    Mglt = "unknown",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 8,
                    HyperdriveRating = 1.8m,
                    Length = 76,
                    Manufacturer = "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives",
                    Model = "J-type 327 Nubian royal starship",
                    Passengers = null,
                    StarshipClass = "yacht",
                    Pilots = new Character[] { GetCharacter(context, "Ric Olié") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Starship
                {
                    Name = "Scimitar",
                    Mglt = "unknown",
                    CargoCapacity = 2500000,
                    Consumables = "30 days",
                    CostInCredits = 55000000,
                    Crew = 1,
                    HyperdriveRating = 1.5m,
                    Length = null,
                    Manufacturer = "Republic Sienar Systems",
                    Model = "Star Courier",
                    Passengers = 6,
                    StarshipClass = "Space Transport",
                    Pilots = new Character[] { GetCharacter(context, "Darth Maul") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Starship
                {
                    Name = "J-type diplomatic barge",
                    Mglt = "unknown",
                    CargoCapacity = null,
                    Consumables = "1 year",
                    CostInCredits = 2000000,
                    Crew = 5,
                    HyperdriveRating = 0.7m,
                    Length = 39,
                    Manufacturer = "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives",
                    Model = "J-type diplomatic barge",
                    Passengers = 10,
                    StarshipClass = "Diplomatic barge",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Starship
                {
                    Name = "AA-9 Coruscant freighter",
                    Mglt = "unknown",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = null,
                    HyperdriveRating = null,
                    Length = 390,
                    Manufacturer = "Botajef Shipyards",
                    Model = "Botajef AA-9 Freighter-Liner",
                    Passengers = 30000,
                    StarshipClass = "freighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Starship
                {
                    Name = "Jedi starfighter",
                    Mglt = "unknown",
                    CargoCapacity = 60,
                    Consumables = "7 days",
                    CostInCredits = 180000,
                    Crew = 1,
                    HyperdriveRating = 1m,
                    Length = 8,
                    Manufacturer = "Kuat Systems Engineering",
                    Model = "Delta-7 Aethersprite-class interceptor",
                    Passengers = 0,
                    StarshipClass = "Starfighter",
                    Pilots = new Character[] { GetCharacter(context, "Obi-Wan Kenobi"), GetCharacter(context, "Plo Koon") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "H-type Nubian yacht",
                    Mglt = "unknown",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 4,
                    HyperdriveRating = 0.9m,
                    Length = null,
                    Manufacturer = "Theed Palace Space Vessel Engineering Corps",
                    Model = "H-type Nubian yacht",
                    Passengers = null,
                    StarshipClass = "yacht",
                    Pilots = new Character[] { GetCharacter(context, "Padmé Amidala") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Starship
                {
                    Name = "Republic Assault ship",
                    Mglt = "unknown",
                    CargoCapacity = 11250000,
                    Consumables = "2 years",
                    CostInCredits = null,
                    Crew = 700,
                    HyperdriveRating = 0.6m,
                    Length = 752,
                    Manufacturer = "Rothana Heavy Engineering",
                    Model = "Acclamator I-class assault ship",
                    Passengers = 16000,
                    StarshipClass = "assault ship",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Starship
                {
                    Name = "Solar Sailer",
                    Mglt = "unknown",
                    CargoCapacity = 240,
                    Consumables = "7 days",
                    CostInCredits = 35700,
                    Crew = 3,
                    HyperdriveRating = 1.5m,
                    Length = null,
                    Manufacturer = "Huppla Pasa Tisc Shipwrights Collective",
                    Model = "Punworcca 116-class interstellar sloop",
                    Passengers = 11,
                    StarshipClass = "yacht",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Starship
                {
                    Name = "Trade Federation cruiser",
                    Mglt = "unknown",
                    CargoCapacity = 50000000,
                    Consumables = "4 years",
                    CostInCredits = 125000000,
                    Crew = 600,
                    HyperdriveRating = 1.5m,
                    Length = 1088,
                    Manufacturer = "Rendili StarDrive, Free Dac Volunteers Engineering corps.",
                    Model = "Providence-class carrier/destroyer",
                    Passengers = 48247,
                    StarshipClass = "capital ship",
                    Pilots = new Character[] { GetCharacter(context, "Obi-Wan Kenobi"), GetCharacter(context, "Anakin Skywalker") },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "Theta-class T-2c shuttle",
                    Mglt = "unknown",
                    CargoCapacity = 50000,
                    Consumables = "56 days",
                    CostInCredits = 1000000,
                    Crew = 5,
                    HyperdriveRating = 1m,
                    Length = null,
                    Manufacturer = "Cygnus Spaceworks",
                    Model = "Theta-class T-2c shuttle",
                    Passengers = 16,
                    StarshipClass = "transport",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "Republic attack cruiser",
                    Mglt = "unknown",
                    CargoCapacity = 20000000,
                    Consumables = "2 years",
                    CostInCredits = 59000000,
                    Crew = 7400,
                    HyperdriveRating = 1m,
                    Length = 1137,
                    Manufacturer = "Kuat Drive Yards, Allanteen Six shipyards",
                    Model = "Senator-class Star Destroyer",
                    Passengers = 2000,
                    StarshipClass = "star destroyer",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "Naboo star skiff",
                    Mglt = "unknown",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 3,
                    HyperdriveRating = 0.5m,
                    Length = null,
                    Manufacturer = "Theed Palace Space Vessel Engineering Corps/Nubia Star Drives, Incorporated",
                    Model = "J-type star skiff",
                    Passengers = 3,
                    StarshipClass = "yacht",
                    Pilots = new Character[] { GetCharacter(context, "Obi-Wan Kenobi"), GetCharacter(context, "Padmé Amidala") },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "Jedi Interceptor",
                    Mglt = "unknown",
                    CargoCapacity = 60,
                    Consumables = "2 days",
                    CostInCredits = 320000,
                    Crew = 1,
                    HyperdriveRating = 1m,
                    Length = null,
                    Manufacturer = "Kuat Systems Engineering",
                    Model = "Eta-2 Actis-class light interceptor",
                    Passengers = 0,
                    StarshipClass = "starfighter",
                    Pilots = new Character[] { GetCharacter(context, "Obi-Wan Kenobi"), GetCharacter(context, "Anakin Skywalker") },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "arc-170",
                    Mglt = "100",
                    CargoCapacity = 110,
                    Consumables = "5 days",
                    CostInCredits = 155000,
                    Crew = 3,
                    HyperdriveRating = 1m,
                    Length = null,
                    Manufacturer = "Incom Corporation, Subpro Corporation",
                    Model = "Aggressive Reconnaissance-170 starfighte",
                    Passengers = 0,
                    StarshipClass = "starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "Banking clan frigte",
                    Mglt = "unknown",
                    CargoCapacity = 40000000,
                    Consumables = "2 years",
                    CostInCredits = 57000000,
                    Crew = 200,
                    HyperdriveRating = 1m,
                    Length = 825,
                    Manufacturer = "Hoersch-Kessel Drive, Inc, Gwori Revolutionary Industries",
                    Model = "Munificent-class star frigate",
                    Passengers = null,
                    StarshipClass = "cruiser",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "Belbullab-22 starfighter",
                    Mglt = "unknown",
                    CargoCapacity = 140,
                    Consumables = "7 days",
                    CostInCredits = 168000,
                    Crew = 1,
                    HyperdriveRating = 6m,
                    Length = null,
                    Manufacturer = "Feethan Ottraw Scalable Assemblies",
                    Model = "Belbullab-22 starfighter",
                    Passengers = 0,
                    StarshipClass = "starfighter",
                    Pilots = new Character[] { GetCharacter(context, "Obi-Wan Kenobi"), GetCharacter(context, "Grievous") },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Starship
                {
                    Name = "V-wing",
                    Mglt = "unknown",
                    CargoCapacity = 60,
                    Consumables = "15 hours",
                    CostInCredits = 102500,
                    Crew = 1,
                    HyperdriveRating = 1m,
                    Length = null,
                    Manufacturer = "Kuat Systems Engineering",
                    Model = "Alpha-3 Nimbus-class V-wing starfighter",
                    Passengers = 0,
                    StarshipClass = "starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                }
            });
        }

        #endregion

        #region Vehicle Data

        private static void AddVehicles(StarwarsDbContext context)
        {
            context.Vehicles.AddRange(new Vehicle[]
            {
                new Vehicle
                {
                    Name = "Sand Crawler",
                    CargoCapacity = 50000,
                    Consumables = "2 months",
                    CostInCredits = 150000,
                    Crew = 46,
                    Length = null,
                    Manufacturer = "Corellia Mining Corporation",
                    Model = "Digger Crawler",
                    Passengers = 30,
                    VehicleClass = "wheeled",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "Attack of the Clones") }
                },
                new Vehicle
                {
                    Name = "T-16 skyhopper",
                    CargoCapacity = 50,
                    Consumables = "0",
                    CostInCredits = 14500,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Incom Corporation",
                    Model = "T-16 skyhopper",
                    Passengers = 1,
                    VehicleClass = "repulsorcraft",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Vehicle
                {
                    Name = "X-34 landspeeder",
                    CargoCapacity = 5,
                    Consumables = "unknown",
                    CostInCredits = 10550,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "SoroSuub Corporation",
                    Model = "X-34 landspeeder",
                    Passengers = 1,
                    VehicleClass = "repulsorcraft",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope") }
                },
                new Vehicle
                {
                    Name = "TIE/LN starfighter",
                    CargoCapacity = 65,
                    Consumables = "2 days",
                    CostInCredits = null,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Sienar Fleet Systems",
                    Model = "Twin Ion Engine/Ln Starfighter",
                    Passengers = 0,
                    VehicleClass = "starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "A New Hope"), GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Vehicle
                {
                    Name = "Snowspeeder",
                    CargoCapacity = 10,
                    Consumables = "none",
                    CostInCredits = null,
                    Crew = 2,
                    Length = null,
                    Manufacturer = "Incom corporation",
                    Model = "t-47 airspeeder",
                    Passengers = 0,
                    VehicleClass = "airspeeder",
                    Pilots = new Character[] { GetCharacter(context, "Luke Skywalker"), GetCharacter(context, "Wedge Antilles") },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Vehicle
                {
                    Name = "TIE bomber",
                    CargoCapacity = null,
                    Consumables = "2 days",
                    CostInCredits = null,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Sienar Fleet Systems",
                    Model = "TIE/sa bomber",
                    Passengers = 0,
                    VehicleClass = "space/planetary bomber",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Vehicle
                {
                    Name = "AT-AT",
                    CargoCapacity = 1000,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 5,
                    Length = 20,
                    Manufacturer = "Kuat Drive Yards, Imperial Department of Military Research",
                    Model = "All Terrain Armored Transport",
                    Passengers = 40,
                    VehicleClass = "assault walker",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Vehicle
                {
                    Name = "AT-ST",
                    CargoCapacity = 200,
                    Consumables = "none",
                    CostInCredits = null,
                    Crew = 2,
                    Length = 2,
                    Manufacturer = "Kuat Drive Yards, Imperial Department of Military Research",
                    Model = "All Terrain Scout Transport",
                    Passengers = 0,
                    VehicleClass = "walker",
                    Pilots = new Character[] { GetCharacter(context, "Chewbacca") },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back"), GetFilm(context, "Return of the Jedi") }
                },
                new Vehicle
                {
                    Name = "Storm IV Twin-Pod cloud car",
                    CargoCapacity = 10,
                    Consumables = "1 day",
                    CostInCredits = 75000,
                    Crew = 2,
                    Length = 7,
                    Manufacturer = "Bespin Motors",
                    Model = "Storm IV Twin-Pod",
                    Passengers = 0,
                    VehicleClass = "repulsorcraft",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Empire Strikes Back") }
                },
                new Vehicle
                {
                    Name = "Sail barge",
                    CargoCapacity = 2000000,
                    Consumables = "Live food tanks",
                    CostInCredits = 285000,
                    Crew = 26,
                    Length = 30,
                    Manufacturer = "Ubrikkian Industries Custom Vehicle Division",
                    Model = "Modified Luxury Sail Barge",
                    Passengers = 500,
                    VehicleClass = "sail barge",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Vehicle
                {
                    Name = "Bantha-II cargo skiff",
                    CargoCapacity = 135000,
                    Consumables = "1 day",
                    CostInCredits = 8000,
                    Crew = 5,
                    Length = null,
                    Manufacturer = "Ubrikkian Industries",
                    Model = "Bantha-II",
                    Passengers = 16,
                    VehicleClass = "repulsorcraft cargo skiff",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Vehicle
                {
                    Name = "TIE/IN interceptor",
                    CargoCapacity = 75,
                    Consumables = "2 days",
                    CostInCredits = null,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Sienar Fleet Systems",
                    Model = "Twin Ion Engine Interceptor",
                    Passengers = 0,
                    VehicleClass = "starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Vehicle
                {
                    Name = "Imperial Speeder Bike",
                    CargoCapacity = 4,
                    Consumables = "1 day",
                    CostInCredits = 8000,
                    Crew = 1,
                    Length = 3,
                    Manufacturer = "Aratech Repulsor Company",
                    Model = "74-Z speeder bike",
                    Passengers = 1,
                    VehicleClass = "speeder",
                    Pilots = new Character[] { GetCharacter(context, "Luke Skywalker"), GetCharacter(context, "Leia Organa") },
                    Films = new Film[] { GetFilm(context, "Return of the Jedi") }
                },
                new Vehicle
                {
                    Name = "Vulture Droid",
                    CargoCapacity = 0,
                    Consumables = "none",
                    CostInCredits = null,
                    Crew = 0,
                    Length = null,
                    Manufacturer = "Haor Chall Engineering, Baktoid Armor Workshop",
                    Model = "Vulture-class droid starfighter",
                    Passengers = 0,
                    VehicleClass = "starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace"), GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Multi-Troop Transport",
                    CargoCapacity = 12000,
                    Consumables = "unknown",
                    CostInCredits = 138000,
                    Crew = 4,
                    Length = 31,
                    Manufacturer = "Baktoid Armor Workshop",
                    Model = "Multi-Troop Transport",
                    Passengers = 112,
                    VehicleClass = "repulsorcraft",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Vehicle
                {
                    Name = "Armored Assault Tank",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 4,
                    Length = null,
                    Manufacturer = "Baktoid Armor Workshop",
                    Model = "Armoured Assault Tank",
                    Passengers = 6,
                    VehicleClass = "repulsorcraft",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Vehicle
                {
                    Name = "Single Trooper Aerial Platform",
                    CargoCapacity = null,
                    Consumables = "none",
                    CostInCredits = 2500,
                    Crew = 1,
                    Length = 2,
                    Manufacturer = "Baktoid Armor Workshop",
                    Model = "Single Trooper Aerial Platform",
                    Passengers = 0,
                    VehicleClass = "repulsorcraft",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Vehicle
                {
                    Name = "C-9979 landing craft",
                    CargoCapacity = 1800000,
                    Consumables = "1 day",
                    CostInCredits = 200000,
                    Crew = 140,
                    Length = 210,
                    Manufacturer = "Haor Chall Engineering",
                    Model = "C-9979 landing craft",
                    Passengers = 284,
                    VehicleClass = "landing craft",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Vehicle
                {
                    Name = "Tribubble bongo",
                    CargoCapacity = 1600,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 1,
                    Length = 15,
                    Manufacturer = "Otoh Gunga Bongameken Cooperative",
                    Model = "Tribubble bongo",
                    Passengers = 2,
                    VehicleClass = "submarine",
                    Pilots = new Character[] { GetCharacter(context, "Obi-Wan Kenobi"), GetCharacter(context, "Qui-Gon Jinn") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Vehicle
                {
                    Name = "Sith speeder",
                    CargoCapacity = 2,
                    Consumables = "unknown",
                    CostInCredits = 4000,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Razalon",
                    Model = "FC-20 speeder bike",
                    Passengers = 0,
                    VehicleClass = "speeder",
                    Pilots = new Character[] { GetCharacter(context, "Darth Maul") },
                    Films = new Film[] { GetFilm(context, "The Phantom Menace") }
                },
                new Vehicle
                {
                    Name = "Zephyr-G swoop bike",
                    CargoCapacity = 200,
                    Consumables = "none",
                    CostInCredits = 5750,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Mobquet Swoops and Speeders",
                    Model = "Zephyr-G swoop bike",
                    Passengers = 1,
                    VehicleClass = "repulsorcraft",
                    Pilots = new Character[] { GetCharacter(context, "Anakin Skywalker") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Vehicle
                {
                    Name = "Koro-2 Exodrive airspeeder",
                    CargoCapacity = 80,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Desler Gizh Outworld Mobility Corporation",
                    Model = "Koro-2 Exodrive airspeeder",
                    Passengers = 1,
                    VehicleClass = "airspeeder",
                    Pilots = new Character[] { GetCharacter(context, "Zam Wesell") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Vehicle
                {
                    Name = "XJ-6 airspeeder",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Narglatch AirTech prefabricated kit",
                    Model = "XJ-6 airspeeder",
                    Passengers = 1,
                    VehicleClass = "airspeeder",
                    Pilots = new Character[] { GetCharacter(context, "Anakin Skywalker") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Vehicle
                {
                    Name = "LAAT/i",
                    CargoCapacity = 170,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 6,
                    Length = null,
                    Manufacturer = "Rothana Heavy Engineering",
                    Model = "Low Altitude Assault Transport/infrantry",
                    Passengers = 30,
                    VehicleClass = "gunship",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "LAAT/c",
                    CargoCapacity = 40000,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Rothana Heavy Engineering",
                    Model = "Low Altitude Assault Transport/carrier",
                    Passengers = 0,
                    VehicleClass = "gunship",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Vehicle
                {
                    Name = "AT-TE",
                    CargoCapacity = 10000,
                    Consumables = "21 days",
                    CostInCredits = null,
                    Crew = 6,
                    Length = null,
                    Manufacturer = "Rothana Heavy Engineering, Kuat Drive Yards",
                    Model = "All Terrain Tactical Enforcer",
                    Passengers = 36,
                    VehicleClass = "walker",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "SPHA",
                    CargoCapacity = 500,
                    Consumables = "7 days",
                    CostInCredits = null,
                    Crew = 25,
                    Length = 140,
                    Manufacturer = "Rothana Heavy Engineering",
                    Model = "Self-Propelled Heavy Artillery",
                    Passengers = 30,
                    VehicleClass = "walker",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Vehicle
                {
                    Name = "Flitknot speeder",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = 8000,
                    Crew = 1,
                    Length = 2,
                    Manufacturer = "Huppla Pasa Tisc Shipwrights Collective",
                    Model = "Flitknot speeder",
                    Passengers = 0,
                    VehicleClass = "speeder",
                    Pilots = new Character[] { GetCharacter(context, "Dooku") },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Vehicle
                {
                    Name = "Neimoidian shuttle",
                    CargoCapacity = 1000,
                    Consumables = "7 days",
                    CostInCredits = null,
                    Crew = 2,
                    Length = 20,
                    Manufacturer = "Haor Chall Engineering",
                    Model = "Sheathipede-class transport shuttle",
                    Passengers = 6,
                    VehicleClass = "transport",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones"), GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Geonosian starfighter",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Huppla Pasa Tisc Shipwrights Collective",
                    Model = "Nantex-class territorial defense",
                    Passengers = 0,
                    VehicleClass = "starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Attack of the Clones") }
                },
                new Vehicle
                {
                    Name = "Tsmeu-6 personal wheel bike",
                    CargoCapacity = 10,
                    Consumables = "none",
                    CostInCredits = 15000,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Z-Gomot Ternbuell Guppat Corporation",
                    Model = "Tsmeu-6 personal wheel bike",
                    Passengers = 1,
                    VehicleClass = "wheeled walker",
                    Pilots = new Character[] { GetCharacter(context, "Grievous") },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Emergency Firespeeder",
                    CargoCapacity = null,
                    Consumables = "unknown",
                    CostInCredits = null,
                    Crew = 2,
                    Length = null,
                    Manufacturer = "unknown",
                    Model = "Fire suppression speeder",
                    Passengers = null,
                    VehicleClass = "fire suppression ship",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Droid tri-fighter",
                    CargoCapacity = 0,
                    Consumables = "none",
                    CostInCredits = 20000,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Colla Designs, Phlac-Arphocc Automata Industries",
                    Model = "tri-fighter",
                    Passengers = 0,
                    VehicleClass = "droid starfighter",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Oevvaor jet catamaran",
                    CargoCapacity = 50,
                    Consumables = "3 days",
                    CostInCredits = 12125,
                    Crew = 2,
                    Length = null,
                    Manufacturer = "Appazanna Engineering Works",
                    Model = "Oevvaor jet catamaran",
                    Passengers = 2,
                    VehicleClass = "airspeeder",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Raddaugh Gnasp fluttercraft",
                    CargoCapacity = 20,
                    Consumables = "none",
                    CostInCredits = 14750,
                    Crew = 2,
                    Length = 7,
                    Manufacturer = "Appazanna Engineering Works",
                    Model = "Raddaugh Gnasp fluttercraft",
                    Passengers = 0,
                    VehicleClass = "air speeder",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Clone turbo tank",
                    CargoCapacity = 30000,
                    Consumables = "20 days",
                    CostInCredits = 350000,
                    Crew = 20,
                    Length = null,
                    Manufacturer = "Kuat Drive Yards",
                    Model = "HAVw A6 Juggernaut",
                    Passengers = 300,
                    VehicleClass = "wheeled walker",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Corporate Alliance tank droid",
                    CargoCapacity = null,
                    Consumables = "none",
                    CostInCredits = 49000,
                    Crew = 0,
                    Length = null,
                    Manufacturer = "Techno Union",
                    Model = "NR-N99 Persuader-class droid enforcer",
                    Passengers = 4,
                    VehicleClass = "droid tank",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "Droid gunship",
                    CargoCapacity = 0,
                    Consumables = "none",
                    CostInCredits = 60000,
                    Crew = 0,
                    Length = null,
                    Manufacturer = "Baktoid Fleet Ordnance, Haor Chall Engineering",
                    Model = "HMP droid gunship",
                    Passengers = 0,
                    VehicleClass = "airspeeder",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                },
                new Vehicle
                {
                    Name = "AT-RT",
                    CargoCapacity = 20,
                    Consumables = "1 day",
                    CostInCredits = 40000,
                    Crew = 1,
                    Length = null,
                    Manufacturer = "Kuat Drive Yards",
                    Model = "All Terrain Recon Transport",
                    Passengers = 0,
                    VehicleClass = "walker",
                    Pilots = new Character[] {  },
                    Films = new Film[] { GetFilm(context, "Revenge of the Sith") }
                }
            });
        }

        #endregion
    }
}
