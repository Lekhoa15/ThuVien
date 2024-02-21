using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updatePhieuTra1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 3, 10, 18, 53, 880, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 10, 18, 53, 880, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 10, 18, 53, 880, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 10, 18, 53, 880, DateTimeKind.Local).AddTicks(4750));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 3, 10, 18, 0, 481, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 10, 18, 0, 481, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 10, 18, 0, 481, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 10, 18, 0, 481, DateTimeKind.Local).AddTicks(4842));
        }
    }
}
