using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updatePhieuTra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaPhieuMuon",
                table: "phieuTras");

            migrationBuilder.AddColumn<int>(
                name: "MaPhieuMuon",
                table: "chiTietPhieuTras",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaPhieuMuon",
                table: "chiTietPhieuTras");

            migrationBuilder.AddColumn<int>(
                name: "MaPhieuMuon",
                table: "phieuTras",
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
    }
}
