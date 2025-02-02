using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversiteOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Derss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fakultes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakultes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yetki = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinif", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FakulteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bolums_Fakultes_FakulteId",
                        column: x => x.FakulteId,
                        principalTable: "Fakultes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BolumDers",
                columns: table => new
                {
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BolumDers", x => new { x.DersId, x.BolumId });
                    table.ForeignKey(
                        name: "FK_BolumDers_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BolumDers_Derss_DersId",
                        column: x => x.DersId,
                        principalTable: "Derss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgretimGorevlisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimGorevlisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgretimGorevlisis_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notlars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Not = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notlars_Derss_DersId",
                        column: x => x.DersId,
                        principalTable: "Derss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notlars_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BolumDers_BolumId",
                table: "BolumDers",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Bolums_FakulteId",
                table: "Bolums",
                column: "FakulteId");

            migrationBuilder.CreateIndex(
                name: "IX_Notlars_DersId",
                table: "Notlars",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Notlars_OgrenciId",
                table: "Notlars",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_BolumId",
                table: "Ogrencis",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimGorevlisis_BolumId",
                table: "OgretimGorevlisis",
                column: "BolumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BolumDers");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Notlars");

            migrationBuilder.DropTable(
                name: "OgretimGorevlisis");

            migrationBuilder.DropTable(
                name: "Sinif");

            migrationBuilder.DropTable(
                name: "Derss");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Bolums");

            migrationBuilder.DropTable(
                name: "Fakultes");
        }
    }
}
