using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class New1Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandmarkLandmarkType");

            migrationBuilder.DropTable(
                name: "LandmarkTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LandmarkTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<double>(type: "float", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandmarkTypes", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_LandmarkLandmarkType_TypeId",
                table: "LandmarkLandmarkType",
                column: "TypeId");
        }
    }
}
