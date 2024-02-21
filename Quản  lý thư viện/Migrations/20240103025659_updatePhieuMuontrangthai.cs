using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updatePhieuMuontrangthai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "phieuMuons");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "ctpms",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 3, 9, 56, 59, 810, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 9, 56, 59, 810, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 9, 56, 59, 810, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 9, 56, 59, 810, DateTimeKind.Local).AddTicks(9808));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "ctpms");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "phieuMuons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                columns: new[] { "NgayMuon", "TrangThai" },
                values: new object[] { new DateTime(2024, 1, 3, 9, 53, 6, 882, DateTimeKind.Local).AddTicks(4324), 1 });

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 9, 53, 6, 882, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 9, 53, 6, 882, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 3, 9, 53, 6, 882, DateTimeKind.Local).AddTicks(4229));
        }
    }
}
