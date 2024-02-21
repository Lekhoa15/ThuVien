using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class ctpm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuon",
                columns: table => new
                {
                    maCTPM = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaPhieuMuon = table.Column<int>(type: "INTEGER", nullable: false),
                    MaSach = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuon", x => x.maCTPM);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuon");

            migrationBuilder.UpdateData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1,
                column: "NgayMuon",
                value: new DateTime(2024, 1, 1, 16, 22, 6, 937, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 1, 16, 22, 6, 937, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 1, 16, 22, 6, 937, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2024, 1, 1, 16, 22, 6, 937, DateTimeKind.Local).AddTicks(2101));
        }
    }
}
