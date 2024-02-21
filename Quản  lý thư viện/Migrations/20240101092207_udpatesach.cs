using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class udpatesach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "loaisachs",
                columns: new[] { "MaLoai", "tenLoai" },
                values: new object[,]
                {
                    { "Cong nghe thong tin", "Công nghệ thông tin" },
                    { "Cuoc song", "Cuộc sống" },
                    { "Triet hoc", "Triết học" }
                });

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 1, 16, 22, 6, 937, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.InsertData(
                table: "sachs",
                columns: new[] { "MaSach", "MaLoai", "SoLuong", "TenSach", "namXuatBan", "ngayNhap", "tacgia" },
                values: new object[,]
                {
                    { 1, "Cong nghe thong tin", 20, "Java cơ bản 1", 2023, new DateTime(2024, 1, 1, 16, 22, 6, 937, DateTimeKind.Local).AddTicks(2084), "Van Hoang" },
                    { 2, "Triet hoc", 20, "Triết học mác lê nin", 2023, new DateTime(2024, 1, 1, 16, 22, 6, 937, DateTimeKind.Local).AddTicks(2100), "Van Hoang" },
                    { 3, "Cong nghe thong tin", 20, "Cấu trúc dữ liệu và giải thuật", 2023, new DateTime(2024, 1, 1, 16, 22, 6, 937, DateTimeKind.Local).AddTicks(2101), "Van Hoang" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 1, 16, 0, 29, 991, DateTimeKind.Local).AddTicks(5581));
        }
    }
}
