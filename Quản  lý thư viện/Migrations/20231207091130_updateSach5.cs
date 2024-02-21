using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updateSach5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "loaisachs",
                columns: new[] { "MaLoai", "tenLoai" },
                values: new object[,]
                {
                    { "Cuoc song", "Cuộc sống" },
                    { "Triet hoc", "Triết học" }
                });

            migrationBuilder.InsertData(
                table: "sachs",
                columns: new[] { "MaSach", "MaLoai", "SoLuong", "TenSach" },
                values: new object[,]
                {
                    { 3, "Cong nghe thong tin", 20, "Cấu trúc dữ liệu và giải thuật" },
                    { 2, "Triet hoc", 20, "Triết học mác lê nin" }
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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "loaisachs",
                keyColumn: "MaLoai",
                keyValue: "Triet hoc");
        }
    }
}
