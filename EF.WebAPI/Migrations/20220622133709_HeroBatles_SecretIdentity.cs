using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.WebAPI.Migrations
{
    public partial class HeroBatles_SecretIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Batles_BatleId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_BatleId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "BatleId",
                table: "Heroes");

            migrationBuilder.CreateTable(
                name: "HeroBatles",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    BatleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroBatles", x => new { x.BatleId, x.HeroId });
                    table.ForeignKey(
                        name: "FK_HeroBatles_Batles_BatleId",
                        column: x => x.BatleId,
                        principalTable: "Batles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroBatles_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecretIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecretIdentities_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroBatles_HeroId",
                table: "HeroBatles",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentities_HeroId",
                table: "SecretIdentities",
                column: "HeroId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroBatles");

            migrationBuilder.DropTable(
                name: "SecretIdentities");

            migrationBuilder.AddColumn<int>(
                name: "BatleId",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_BatleId",
                table: "Heroes",
                column: "BatleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Batles_BatleId",
                table: "Heroes",
                column: "BatleId",
                principalTable: "Batles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
