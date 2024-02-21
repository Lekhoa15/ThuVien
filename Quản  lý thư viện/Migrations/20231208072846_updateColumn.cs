using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "namXuatBan",
                table: "sachs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ngayNhap",
                table: "sachs",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "tacgia",
                table: "sachs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                columns: new[] { "namXuatBan", "ngayNhap", "tacgia" },
                values: new object[] { 2023, new DateTime(2023, 12, 8, 14, 28, 46, 357, DateTimeKind.Local).AddTicks(2585), "Van Hoang" });

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                columns: new[] { "namXuatBan", "ngayNhap", "tacgia" },
                values: new object[] { 2023, new DateTime(2023, 12, 8, 14, 28, 46, 357, DateTimeKind.Local).AddTicks(2598), "Van Hoang" });

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                columns: new[] { "namXuatBan", "ngayNhap", "tacgia" },
                values: new object[] { 2023, new DateTime(2023, 12, 8, 14, 28, 46, 357, DateTimeKind.Local).AddTicks(2600), "Van Hoang" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "namXuatBan",
                table: "sachs");

            migrationBuilder.DropColumn(
                name: "ngayNhap",
                table: "sachs");

            migrationBuilder.DropColumn(
                name: "tacgia",
                table: "sachs");
        }
    }
}
