using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class phiemuon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "loaisachs",
                keyColumn: "MaLoai",
                keyValue: "Cuoc song");

            migrationBuilder.DeleteData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "loaisachs",
                keyColumn: "MaLoai",
                keyValue: "Cong nghe thong tin");

            migrationBuilder.DeleteData(
                table: "loaisachs",
                keyColumn: "MaLoai",
                keyValue: "Triet hoc");

            migrationBuilder.CreateTable(
                name: "phieuMuons",
                columns: table => new
                {
                    MaPhieuMuon = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NgayMuon = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MaDocGia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phieuMuons", x => x.MaPhieuMuon);
                    table.ForeignKey(
                        name: "FK_phieuMuons_docGias_MaDocGia",
                        column: x => x.MaDocGia,
                        principalTable: "docGias",
                        principalColumn: "MaDocGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_phieuMuons_MaDocGia",
                table: "phieuMuons",
                column: "MaDocGia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "phieuMuons");

            migrationBuilder.InsertData(
                table: "loaisachs",
                columns: new[] { "MaLoai", "tenLoai" },
                values: new object[,]
                {
                    { "Cong nghe thong tin", "Công nghệ thông tin" },
                    { "Cuoc song", "Cuộc sống" },
                    { "Triet hoc", "Triết học" }
                });

            migrationBuilder.InsertData(
                table: "sachs",
                columns: new[] { "MaSach", "MaLoai", "SoLuong", "TenSach", "namXuatBan", "ngayNhap", "tacgia" },
                values: new object[,]
                {
                    { 1, "Cong nghe thong tin", 20, "Java cơ bản 1", 2023, new DateTime(2023, 12, 23, 15, 39, 32, 659, DateTimeKind.Local).AddTicks(2471), "Van Hoang" },
                    { 2, "Triet hoc", 20, "Triết học mác lê nin", 2023, new DateTime(2023, 12, 23, 15, 39, 32, 659, DateTimeKind.Local).AddTicks(2482), "Van Hoang" },
                    { 3, "Cong nghe thong tin", 20, "Cấu trúc dữ liệu và giải thuật", 2023, new DateTime(2023, 12, 23, 15, 39, 32, 659, DateTimeKind.Local).AddTicks(2484), "Van Hoang" }
                });
        }
    }
}
