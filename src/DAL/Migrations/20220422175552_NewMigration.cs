using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Park_ParkId",
                table: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Animal_ParkId",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "ParkId",
                table: "Animal");

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
                        name: "FK_AnimalPark_Animal_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalPark_Park_ParksId",
                        column: x => x.ParksId,
                        principalTable: "Park",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalPark_ParksId",
                table: "AnimalPark",
                column: "ParksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalPark");

            migrationBuilder.AddColumn<int>(
                name: "ParkId",
                table: "Animal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animal_ParkId",
                table: "Animal",
                column: "ParkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Park_ParkId",
                table: "Animal",
                column: "ParkId",
                principalTable: "Park",
                principalColumn: "Id");
        }
    }
}
