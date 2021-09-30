using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Connectr.TechTests.Backend.EntityFramework.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Episode = table.Column<int>(type: "int", nullable: false),
                    OpeningCrawl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diameter = table.Column<int>(type: "int", nullable: false),
                    Gravity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrbitalPeriod = table.Column<int>(type: "int", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false),
                    RotationPeriod = table.Column<int>(type: "int", nullable: true),
                    SurfaceWater = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AverageLifespan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Classification = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeworldId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mglt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoCapacity = table.Column<int>(type: "int", nullable: false),
                    Consumables = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostInCredits = table.Column<int>(type: "int", nullable: false),
                    Crew = table.Column<int>(type: "int", nullable: true),
                    HyperdriveRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passengers = table.Column<int>(type: "int", nullable: false),
                    StarshipClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoCapacity = table.Column<int>(type: "int", nullable: false),
                    Consumables = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostInCredits = table.Column<int>(type: "int", nullable: false),
                    Crew = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passengers = table.Column<int>(type: "int", nullable: false),
                    VehicleClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Mass = table.Column<int>(type: "int", nullable: false),
                    HairColor = table.Column<int>(type: "int", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: false),
                    BirthYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    HomeworldId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Planets_HomeworldId",
                        column: x => x.HomeworldId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmPlanet",
                columns: table => new
                {
                    FilmsId = table.Column<int>(type: "int", nullable: false),
                    PlanetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmPlanet", x => new { x.FilmsId, x.PlanetsId });
                    table.ForeignKey(
                        name: "FK_FilmPlanet_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmPlanet_Planets_PlanetsId",
                        column: x => x.PlanetsId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmSpecies",
                columns: table => new
                {
                    FilmsId = table.Column<int>(type: "int", nullable: false),
                    SpeciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmSpecies", x => new { x.FilmsId, x.SpeciesId });
                    table.ForeignKey(
                        name: "FK_FilmSpecies_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmSpecies_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmStarship",
                columns: table => new
                {
                    FilmsId = table.Column<int>(type: "int", nullable: false),
                    StarshipsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmStarship", x => new { x.FilmsId, x.StarshipsId });
                    table.ForeignKey(
                        name: "FK_FilmStarship_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmStarship_Starships_StarshipsId",
                        column: x => x.StarshipsId,
                        principalTable: "Starships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmVehicle",
                columns: table => new
                {
                    FilmsId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmVehicle", x => new { x.FilmsId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_FilmVehicle_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmVehicle_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterFilm",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "int", nullable: false),
                    FilmsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFilm", x => new { x.CharactersId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_CharacterFilm_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFilm_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSpecies",
                columns: table => new
                {
                    PeopleId = table.Column<int>(type: "int", nullable: false),
                    SpeciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSpecies", x => new { x.PeopleId, x.SpeciesId });
                    table.ForeignKey(
                        name: "FK_CharacterSpecies_Characters_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSpecies_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterStarship",
                columns: table => new
                {
                    PilotsId = table.Column<int>(type: "int", nullable: false),
                    StarshipsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterStarship", x => new { x.PilotsId, x.StarshipsId });
                    table.ForeignKey(
                        name: "FK_CharacterStarship_Characters_PilotsId",
                        column: x => x.PilotsId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStarship_Starships_StarshipsId",
                        column: x => x.StarshipsId,
                        principalTable: "Starships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterVehicle",
                columns: table => new
                {
                    PilotsId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterVehicle", x => new { x.PilotsId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_CharacterVehicle_Characters_PilotsId",
                        column: x => x.PilotsId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterVehicle_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFilm_FilmsId",
                table: "CharacterFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_HomeworldId",
                table: "Characters",
                column: "HomeworldId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpecies_SpeciesId",
                table: "CharacterSpecies",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStarship_StarshipsId",
                table: "CharacterStarship",
                column: "StarshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterVehicle_VehiclesId",
                table: "CharacterVehicle",
                column: "VehiclesId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmPlanet_PlanetsId",
                table: "FilmPlanet",
                column: "PlanetsId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmSpecies_SpeciesId",
                table: "FilmSpecies",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmStarship_StarshipsId",
                table: "FilmStarship",
                column: "StarshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmVehicle_VehiclesId",
                table: "FilmVehicle",
                column: "VehiclesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterFilm");

            migrationBuilder.DropTable(
                name: "CharacterSpecies");

            migrationBuilder.DropTable(
                name: "CharacterStarship");

            migrationBuilder.DropTable(
                name: "CharacterVehicle");

            migrationBuilder.DropTable(
                name: "FilmPlanet");

            migrationBuilder.DropTable(
                name: "FilmSpecies");

            migrationBuilder.DropTable(
                name: "FilmStarship");

            migrationBuilder.DropTable(
                name: "FilmVehicle");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Starships");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
