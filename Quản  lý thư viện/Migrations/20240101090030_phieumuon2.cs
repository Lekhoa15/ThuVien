using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class phieumuon2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "phieuMuons",
                columns: new[] { "MaPhieuMuon", "MaDocGia", "NgayMuon" },
                values: new object[] { 1, 3, new DateTime(2024, 1, 1, 16, 0, 29, 991, DateTimeKind.Local).AddTicks(5581) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "phieuMuons",
                keyColumn: "MaPhieuMuon",
                keyValue: 1);
        }
    }
}
