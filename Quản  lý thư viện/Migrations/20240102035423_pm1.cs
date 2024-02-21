using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class pm1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuon",
                table: "ChiTietPhieuMuon");

            migrationBuilder.RenameTable(
                name: "ChiTietPhieuMuon",
                newName: "ctpms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ctpms",
                table: "ctpms",
                column: "maCTPM");

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 2, 10, 54, 23, 803, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 10, 54, 23, 803, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 10, 54, 23, 803, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 10, 54, 23, 803, DateTimeKind.Local).AddTicks(7590));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ctpms",
                table: "ctpms");

            migrationBuilder.RenameTable(
                name: "ctpms",
                newName: "ChiTietPhieuMuon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuon",
                table: "ChiTietPhieuMuon",
                column: "maCTPM");

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 2, 10, 21, 53, 43, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 10, 21, 53, 43, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 10, 21, 53, 43, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 2, 10, 21, 53, 43, DateTimeKind.Local).AddTicks(1603));
        }
    }
}
