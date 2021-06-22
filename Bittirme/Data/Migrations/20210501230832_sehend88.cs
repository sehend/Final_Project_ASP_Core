using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class sehend88 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ekrankarti",
                columns: table => new
                {
                    ekrankartıd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ekrankarti", x => x.ekrankartıd);
                });

            migrationBuilder.CreateTable(
                name: "mouse",
                columns: table => new
                {
                    mouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mouse", x => x.mouseId);
                });

            migrationBuilder.CreateTable(
                name: "ram",
                columns: table => new
                {
                    ramıd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ram", x => x.ramıd);
                });

            migrationBuilder.CreateTable(
                name: "ssd",
                columns: table => new
                {
                    ssdıd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ssd", x => x.ssdıd);
                });

            migrationBuilder.CreateTable(
                name: "TblSatis",
                columns: table => new
                {
                    KardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KartNo = table.Column<int>(type: "int", nullable: true),
                    SonKulanma = table.Column<int>(type: "int", nullable: true),
                    Cvv = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSatis", x => x.KardId);
                });

            migrationBuilder.CreateTable(
                name: "TblUrunlers",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ramıd = table.Column<int>(type: "int", nullable: true),
                    ssdıd = table.Column<int>(type: "int", nullable: true),
                    mouseId = table.Column<int>(type: "int", nullable: true),
                    ekrankartııd = table.Column<int>(type: "int", nullable: true),
                    ramıd1 = table.Column<int>(type: "int", nullable: true),
                    ssdıd1 = table.Column<int>(type: "int", nullable: true),
                    Xiaomiekrankartıd = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUrunlers", x => x.UrunId);
                    table.ForeignKey(
                        name: "FK_TblUrunlers_Ekrankarti_Xiaomiekrankartıd",
                        column: x => x.Xiaomiekrankartıd,
                        principalTable: "Ekrankarti",
                        principalColumn: "ekrankartıd",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblUrunlers_mouse_mouseId",
                        column: x => x.mouseId,
                        principalTable: "mouse",
                        principalColumn: "mouseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblUrunlers_ram_ramıd1",
                        column: x => x.ramıd1,
                        principalTable: "ram",
                        principalColumn: "ramıd",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblUrunlers_ssd_ssdıd1",
                        column: x => x.ssdıd1,
                        principalTable: "ssd",
                        principalColumn: "ssdıd",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblMudurs",
                columns: table => new
                {
                    Müdürıd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tc = table.Column<int>(type: "int", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MüdürMaaş = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Urunıd = table.Column<int>(type: "int", nullable: true),
                    Adminıd = table.Column<int>(type: "int", nullable: true),
                    Müşıd = table.Column<int>(type: "int", nullable: true),
                    UrunıdNavigationUrunId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMudurs", x => x.Müdürıd);
                    table.ForeignKey(
                        name: "FK_TblMudurs_TblUrunlers_UrunıdNavigationUrunId",
                        column: x => x.UrunıdNavigationUrunId,
                        principalTable: "TblUrunlers",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblMusteris",
                columns: table => new
                {
                    Müşıd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tc = table.Column<int>(type: "int", nullable: false),
                    Tel = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Urunıd = table.Column<int>(type: "int", nullable: true),
                    TblMudurNavigationMüdürıd = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMusteris", x => x.Müşıd);
                    table.ForeignKey(
                        name: "FK_TblMusteris_TblMudurs_TblMudurNavigationMüdürıd",
                        column: x => x.TblMudurNavigationMüdürıd,
                        principalTable: "TblMudurs",
                        principalColumn: "Müdürıd",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblPersonels",
                columns: table => new
                {
                    Personelıd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tc = table.Column<int>(type: "int", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelMaas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Müdürıd = table.Column<int>(type: "int", nullable: true),
                    Kategoriıd = table.Column<int>(type: "int", nullable: true),
                    MüdürıdNavigationMüdürıd = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPersonels", x => x.Personelıd);
                    table.ForeignKey(
                        name: "FK_TblPersonels_TblMudurs_MüdürıdNavigationMüdürıd",
                        column: x => x.MüdürıdNavigationMüdürıd,
                        principalTable: "TblMudurs",
                        principalColumn: "Müdürıd",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblMudurs_UrunıdNavigationUrunId",
                table: "TblMudurs",
                column: "UrunıdNavigationUrunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblMusteris_TblMudurNavigationMüdürıd",
                table: "TblMusteris",
                column: "TblMudurNavigationMüdürıd");

            migrationBuilder.CreateIndex(
                name: "IX_TblPersonels_MüdürıdNavigationMüdürıd",
                table: "TblPersonels",
                column: "MüdürıdNavigationMüdürıd");

            migrationBuilder.CreateIndex(
                name: "IX_TblUrunlers_mouseId",
                table: "TblUrunlers",
                column: "mouseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblUrunlers_ramıd1",
                table: "TblUrunlers",
                column: "ramıd1");

            migrationBuilder.CreateIndex(
                name: "IX_TblUrunlers_ssdıd1",
                table: "TblUrunlers",
                column: "ssdıd1");

            migrationBuilder.CreateIndex(
                name: "IX_TblUrunlers_Xiaomiekrankartıd",
                table: "TblUrunlers",
                column: "Xiaomiekrankartıd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblMusteris");

            migrationBuilder.DropTable(
                name: "TblPersonels");

            migrationBuilder.DropTable(
                name: "TblSatis");

            migrationBuilder.DropTable(
                name: "TblMudurs");

            migrationBuilder.DropTable(
                name: "TblUrunlers");

            migrationBuilder.DropTable(
                name: "Ekrankarti");

            migrationBuilder.DropTable(
                name: "mouse");

            migrationBuilder.DropTable(
                name: "ram");

            migrationBuilder.DropTable(
                name: "ssd");
        }
    }
}
