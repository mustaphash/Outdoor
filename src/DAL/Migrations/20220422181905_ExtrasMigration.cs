using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ExtrasMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Electricity",
                table: "Villa");

            migrationBuilder.DropColumn(
                name: "Wi-Fi",
                table: "Villa");

            migrationBuilder.DropColumn(
                name: "Camping",
                table: "Park");

            migrationBuilder.DropColumn(
                name: "CarPath",
                table: "Outdoor");

            migrationBuilder.DropColumn(
                name: "OpenForTourist",
                table: "NatureReserve");

            migrationBuilder.DropColumn(
                name: "Camping",
                table: "Lake");

            migrationBuilder.DropColumn(
                name: "FishingAllowed",
                table: "Lake");

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtrasFountain",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    FountainsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtrasFountain", x => new { x.ExtrasId, x.FountainsId });
                    table.ForeignKey(
                        name: "FK_ExtrasFountain_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtrasFountain_Fountain_FountainsId",
                        column: x => x.FountainsId,
                        principalTable: "Fountain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtrasLake",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    LakesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtrasLake", x => new { x.ExtrasId, x.LakesId });
                    table.ForeignKey(
                        name: "FK_ExtrasLake_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtrasLake_Lake_LakesId",
                        column: x => x.LakesId,
                        principalTable: "Lake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtrasLandmark",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    LandmarksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtrasLandmark", x => new { x.ExtrasId, x.LandmarksId });
                    table.ForeignKey(
                        name: "FK_ExtrasLandmark_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtrasLandmark_Landmark_LandmarksId",
                        column: x => x.LandmarksId,
                        principalTable: "Landmark",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtrasNatureReserve",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    NatureReservesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtrasNatureReserve", x => new { x.ExtrasId, x.NatureReservesId });
                    table.ForeignKey(
                        name: "FK_ExtrasNatureReserve_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtrasNatureReserve_NatureReserve_NatureReservesId",
                        column: x => x.NatureReservesId,
                        principalTable: "NatureReserve",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtrasPark",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    ParksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtrasPark", x => new { x.ExtrasId, x.ParksId });
                    table.ForeignKey(
                        name: "FK_ExtrasPark_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtrasPark_Park_ParksId",
                        column: x => x.ParksId,
                        principalTable: "Park",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtrasVilla",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    VillasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtrasVilla", x => new { x.ExtrasId, x.VillasId });
                    table.ForeignKey(
                        name: "FK_ExtrasVilla_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtrasVilla_Villa_VillasId",
                        column: x => x.VillasId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExtrasFountain_FountainsId",
                table: "ExtrasFountain",
                column: "FountainsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtrasLake_LakesId",
                table: "ExtrasLake",
                column: "LakesId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtrasLandmark_LandmarksId",
                table: "ExtrasLandmark",
                column: "LandmarksId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtrasNatureReserve_NatureReservesId",
                table: "ExtrasNatureReserve",
                column: "NatureReservesId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtrasPark_ParksId",
                table: "ExtrasPark",
                column: "ParksId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtrasVilla_VillasId",
                table: "ExtrasVilla",
                column: "VillasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtrasFountain");

            migrationBuilder.DropTable(
                name: "ExtrasLake");

            migrationBuilder.DropTable(
                name: "ExtrasLandmark");

            migrationBuilder.DropTable(
                name: "ExtrasNatureReserve");

            migrationBuilder.DropTable(
                name: "ExtrasPark");

            migrationBuilder.DropTable(
                name: "ExtrasVilla");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.AddColumn<bool>(
                name: "Electricity",
                table: "Villa",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Wi-Fi",
                table: "Villa",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Camping",
                table: "Park",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "CarPath",
                table: "Outdoor",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "OpenForTourist",
                table: "NatureReserve",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Camping",
                table: "Lake",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishingAllowed",
                table: "Lake",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }
    }
}
