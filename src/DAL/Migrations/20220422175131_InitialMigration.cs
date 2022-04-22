using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LandmarkTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Height = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandmarkTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outdoor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CarPath = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    WorkingHours = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outdoor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fountain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    WaterType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InMemoryOf = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fountain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fountain_Outdoor_Id",
                        column: x => x.Id,
                        principalTable: "Outdoor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lake",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FishingAllowed = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Camping = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lake", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lake_Outdoor_Id",
                        column: x => x.Id,
                        principalTable: "Outdoor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Landmark",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landmark_Outdoor_Id",
                        column: x => x.Id,
                        principalTable: "Outdoor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NatureReserve",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OpenForTourist = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Size = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureReserve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NatureReserve_Outdoor_Id",
                        column: x => x.Id,
                        principalTable: "Outdoor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Park",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Safety = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Camping = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    WalkingPaths = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Park", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Park_Outdoor_Id",
                        column: x => x.Id,
                        principalTable: "Outdoor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Villa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RoomCount = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    WiFi = table.Column<bool>(name: "Wi-Fi", type: "bit", nullable: false, defaultValue: true),
                    Electricity = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ParkingCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villa_Outdoor_Id",
                        column: x => x.Id,
                        principalTable: "Outdoor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LandmarkLandmarkType",
                columns: table => new
                {
                    LandmarksId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandmarkLandmarkType", x => new { x.LandmarksId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_LandmarkLandmarkType_Landmark_LandmarksId",
                        column: x => x.LandmarksId,
                        principalTable: "Landmark",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandmarkLandmarkType_LandmarkTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "LandmarkTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ParkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Park_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Park",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AnimalLake",
                columns: table => new
                {
                    AnimalsId = table.Column<int>(type: "int", nullable: false),
                    LakesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalLake", x => new { x.AnimalsId, x.LakesId });
                    table.ForeignKey(
                        name: "FK_AnimalLake_Animal_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalLake_Lake_LakesId",
                        column: x => x.LakesId,
                        principalTable: "Lake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalNatureReserve",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    NatureReservesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalNatureReserve", x => new { x.AnimalId, x.NatureReservesId });
                    table.ForeignKey(
                        name: "FK_AnimalNatureReserve_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalNatureReserve_NatureReserve_NatureReservesId",
                        column: x => x.NatureReservesId,
                        principalTable: "NatureReserve",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_ParkId",
                table: "Animal",
                column: "ParkId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalLake_LakesId",
                table: "AnimalLake",
                column: "LakesId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalNatureReserve_NatureReservesId",
                table: "AnimalNatureReserve",
                column: "NatureReservesId");

            migrationBuilder.CreateIndex(
                name: "IX_LandmarkLandmarkType_TypeId",
                table: "LandmarkLandmarkType",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalLake");

            migrationBuilder.DropTable(
                name: "AnimalNatureReserve");

            migrationBuilder.DropTable(
                name: "Fountain");

            migrationBuilder.DropTable(
                name: "LandmarkLandmarkType");

            migrationBuilder.DropTable(
                name: "Villa");

            migrationBuilder.DropTable(
                name: "Lake");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "NatureReserve");

            migrationBuilder.DropTable(
                name: "Landmark");

            migrationBuilder.DropTable(
                name: "LandmarkTypes");

            migrationBuilder.DropTable(
                name: "Park");

            migrationBuilder.DropTable(
                name: "Outdoor");
        }
    }
}
