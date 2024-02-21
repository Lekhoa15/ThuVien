using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class addDocGia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "docGias",
                columns: table => new
                {
                    MaDocGia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenDocGia = table.Column<string>(type: "TEXT", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false),
                    SDT = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_docGias", x => x.MaDocGia);
                });

            migrationBuilder.InsertData(
                table: "docGias",
                columns: new[] { "MaDocGia", "DiaChi", "NgaySinh", "SDT", "TenDocGia" },
                values: new object[] { 1, "Thừa Thiên Huế", new DateTime(2002, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "0898160444", "Lê Văn Hoàng" });

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2023, 12, 23, 15, 39, 32, 659, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2023, 12, 23, 15, 39, 32, 659, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2023, 12, 23, 15, 39, 32, 659, DateTimeKind.Local).AddTicks(2484));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "docGias");

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                column: "ngayNhap",
                value: new DateTime(2023, 12, 8, 14, 28, 46, 357, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                column: "ngayNhap",
                value: new DateTime(2023, 12, 8, 14, 28, 46, 357, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "sachs",
                keyColumn: "MaSach",
                keyValue: 3,
                column: "ngayNhap",
                value: new DateTime(2023, 12, 8, 14, 28, 46, 357, DateTimeKind.Local).AddTicks(2600));
        }
    }
}
