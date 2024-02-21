using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updatePhieuMuon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuTra",
                table: "PhieuTra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuTra",
                table: "ChiTietPhieuTra");

            migrationBuilder.RenameTable(
                name: "PhieuTra",
                newName: "phieuTras");

            migrationBuilder.RenameTable(
                name: "ChiTietPhieuTra",
                newName: "chiTietPhieuTras");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "phieuMuons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_phieuTras",
                table: "phieuTras",
                column: "MaPhieuTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chiTietPhieuTras",
                table: "chiTietPhieuTras",
                column: "MaCTPT");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_phieuTras",
                table: "phieuTras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chiTietPhieuTras",
                table: "chiTietPhieuTras");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "phieuMuons");

            migrationBuilder.RenameTable(
                name: "phieuTras",
                newName: "PhieuTra");

            migrationBuilder.RenameTable(
                name: "chiTietPhieuTras",
                newName: "ChiTietPhieuTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuTra",
                table: "PhieuTra",
                column: "MaPhieuTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuTra",
                table: "ChiTietPhieuTra",
                column: "MaCTPT");

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 2, 16, 7, 31, 566, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 16, 7, 31, 566, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 16, 7, 31, 566, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 16, 7, 31, 566, DateTimeKind.Local).AddTicks(5482));
        }
    }
}
