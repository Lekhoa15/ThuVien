using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updatebookcount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "dem",
                table: "sachs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 8, 11, 59, 45, 201, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                columns: new[] { "dem", "ngayNhap" },
                values: new object[] { 0, new DateTime(2024, 1, 8, 11, 59, 45, 201, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                columns: new[] { "dem", "ngayNhap" },
                values: new object[] { 0, new DateTime(2024, 1, 8, 11, 59, 45, 201, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                columns: new[] { "dem", "ngayNhap" },
                values: new object[] { 0, new DateTime(2024, 1, 8, 11, 59, 45, 201, DateTimeKind.Local).AddTicks(3580) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dem",
                table: "sachs");

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 4, 16, 30, 58, 345, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 4, 16, 30, 58, 345, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 4, 16, 30, 58, 345, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 4, 16, 30, 58, 345, DateTimeKind.Local).AddTicks(903));
        }
    }
}
