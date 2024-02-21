using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updateSach4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "sachs",
                columns: new[] { "MaSach", "MaLoai", "SoLuong", "TenSach" },
                values: new object[] { 1, "Cong nghe thong tin", 20, "Java cơ bản 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1);
        }
    }
}
