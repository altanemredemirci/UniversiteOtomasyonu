using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversiteOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BolumId",
                table: "OgretimGorevlisis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FakulteId",
                table: "Bolums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OgretimGorevlisis_BolumId",
                table: "OgretimGorevlisis",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Bolums_FakulteId",
                table: "Bolums",
                column: "FakulteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bolums_Fakultes_FakulteId",
                table: "Bolums",
                column: "FakulteId",
                principalTable: "Fakultes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgretimGorevlisis_Bolums_BolumId",
                table: "OgretimGorevlisis",
                column: "BolumId",
                principalTable: "Bolums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bolums_Fakultes_FakulteId",
                table: "Bolums");

            migrationBuilder.DropForeignKey(
                name: "FK_OgretimGorevlisis_Bolums_BolumId",
                table: "OgretimGorevlisis");

            migrationBuilder.DropIndex(
                name: "IX_OgretimGorevlisis_BolumId",
                table: "OgretimGorevlisis");

            migrationBuilder.DropIndex(
                name: "IX_Bolums_FakulteId",
                table: "Bolums");

            migrationBuilder.DropColumn(
                name: "BolumId",
                table: "OgretimGorevlisis");

            migrationBuilder.DropColumn(
                name: "FakulteId",
                table: "Bolums");
        }
    }
}
