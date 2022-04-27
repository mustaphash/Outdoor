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
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outdoors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    WorkingHours = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outdoors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lakes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lakes_Outdoors_Id",
                        column: x => x.Id,
                        principalTable: "Outdoors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Landmarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landmarks_Outdoors_Id",
                        column: x => x.Id,
                        principalTable: "Outdoors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NatureReserves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureReserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NatureReserves_Outdoors_Id",
                        column: x => x.Id,
                        principalTable: "Outdoors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Safety = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parks_Outdoors_Id",
                        column: x => x.Id,
                        principalTable: "Outdoors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RoomCount = table.Column<int>(type: "int", maxLength: 1000, nullable: false),
                    GuestCount = table.Column<int>(type: "int", maxLength: 1000, nullable: false),
                    ParkingCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villas_Outdoors_Id",
                        column: x => x.Id,
                        principalTable: "Outdoors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fountains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    InMemoryOf = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WaterTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fountains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fountains_Outdoors_Id",
                        column: x => x.Id,
                        principalTable: "Outdoors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fountains_WaterTypes_WaterTypeId",
                        column: x => x.WaterTypeId,
                        principalTable: "WaterTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_AnimalLake_Animals_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalLake_Lakes_LakesId",
                        column: x => x.LakesId,
                        principalTable: "Lakes",
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
                        name: "FK_ExtrasLake_Lakes_LakesId",
                        column: x => x.LakesId,
                        principalTable: "Lakes",
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
                        name: "FK_ExtrasLandmark_Landmarks_LandmarksId",
                        column: x => x.LandmarksId,
                        principalTable: "Landmarks",
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
                        name: "FK_AnimalNatureReserve_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalNatureReserve_NatureReserves_NatureReservesId",
                        column: x => x.NatureReservesId,
                        principalTable: "NatureReserves",
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
                        name: "FK_ExtrasNatureReserve_NatureReserves_NatureReservesId",
                        column: x => x.NatureReservesId,
                        principalTable: "NatureReserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalPark",
                columns: table => new
                {
                    AnimalsId = table.Column<int>(type: "int", nullable: false),
                    ParksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalPark", x => new { x.AnimalsId, x.ParksId });
                    table.ForeignKey(
                        name: "FK_AnimalPark_Animals_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalPark_Parks_ParksId",
                        column: x => x.ParksId,
                        principalTable: "Parks",
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
                        name: "FK_ExtrasPark_Parks_ParksId",
                        column: x => x.ParksId,
                        principalTable: "Parks",
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
                        name: "FK_ExtrasVilla_Villas_VillasId",
                        column: x => x.VillasId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_ExtrasFountain_Fountains_FountainsId",
                        column: x => x.FountainsId,
                        principalTable: "Fountains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The bear is the largest carnivore in Bulgaria and can be found in the Rhodope Mountains, Rila Mountains, Pirin Mountains, and Stara Planina", "Brown Bear" },
                    { 2, "Wolves live in parts of Stara Planina (Balkan Mountains), Strandzha Mountains, the Rhodopes, and around the city of Ruse.", "Wolf" },
                    { 3, "The fox can be encountered in many places in Bulgaria, usually in forest areas", "Fox" },
                    { 4, "Wild rabbits are still widespread around Bulgaria, mainly in the flat and low areas.", "Wild Rabbit" },
                    { 5, "Boars are known to be aggressive when they are with their cubs so stay out of the forest in the Spring. Wild Boar are hunted in Bulgaria and in some areas their population is stimulated in order to offer better hunting conditions.", "Wild Boar" },
                    { 6, "Storks have a special role in the local folklore. They are believed to be the birds bringing spring with them. Storks spend the winter in Africa and come back to their nests in Bulgaria every year at the end of March.", "Stork" },
                    { 7, "The cuckoo has a special role in spring. Old people say that when you here the cuckoo song for the first time in spring, you should check your wallet. If it’s full of money, you’ll have a prosperous year. If it’s not, it is going to be bad for you.", "Cuckoo" },
                    { 8, "Hedgehogs can be seen in the wild as well as in cities and villages. Some people in the villages even leave food for the hedgehogs to make sure they are around because they are famous for eating snakes.", "Hedgehog" },
                    { 9, "", "Pig" },
                    { 10, "", "Horse" },
                    { 11, "", "Goat" },
                    { 12, "", "Cow" },
                    { 13, "", "Snake" },
                    { 14, "", "Bison" },
                    { 15, "", "Deer" },
                    { 16, "", "Sheep" },
                    { 17, "", "Pike" },
                    { 18, "", "Carp" },
                    { 19, "", "Trout" },
                    { 20, "", "Salmon" },
                    { 21, "", "Perch" },
                    { 22, "", "Bonito" },
                    { 23, "", "Popche" },
                    { 24, "", "Catfish" },
                    { 25, "", "Redeye" },
                    { 26, "", "Woodpecker" },
                    { 27, "", "Collared Dove" },
                    { 28, "", "Swallow" },
                    { 29, "", "Sparrow" },
                    { 30, "", "Owl" }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Wi-Fi" },
                    { 2, "", "Camping" },
                    { 3, "", "FishingAllowed" },
                    { 4, "", "Elrctricity" },
                    { 5, "", "OpenForTourist" },
                    { 6, "", "WalkingPaths" }
                });

            migrationBuilder.InsertData(
                table: "WaterTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mineral" },
                    { 2, "Spring" },
                    { 3, "Table" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalLake_LakesId",
                table: "AnimalLake",
                column: "LakesId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalNatureReserve_NatureReservesId",
                table: "AnimalNatureReserve",
                column: "NatureReservesId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalPark_ParksId",
                table: "AnimalPark",
                column: "ParksId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Fountains_WaterTypeId",
                table: "Fountains",
                column: "WaterTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalLake");

            migrationBuilder.DropTable(
                name: "AnimalNatureReserve");

            migrationBuilder.DropTable(
                name: "AnimalPark");

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
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Fountains");

            migrationBuilder.DropTable(
                name: "Lakes");

            migrationBuilder.DropTable(
                name: "Landmarks");

            migrationBuilder.DropTable(
                name: "NatureReserves");

            migrationBuilder.DropTable(
                name: "Parks");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Villas");

            migrationBuilder.DropTable(
                name: "WaterTypes");

            migrationBuilder.DropTable(
                name: "Outdoors");
        }
    }
}
