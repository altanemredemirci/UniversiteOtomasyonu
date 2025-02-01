using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversiteOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DersOgrenci",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "int", nullable: false),
                    OgrencisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersOgrenci", x => new { x.DersId, x.OgrencisId });
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Derss_DersId",
                        column: x => x.DersId,
                        principalTable: "Derss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Ogrencis_OgrencisId",
                        column: x => x.OgrencisId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersOgrenci_OgrencisId",
                table: "DersOgrenci",
                column: "OgrencisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersOgrenci");
        }
    }
}
