using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loaisachs_sachs_sachMaSach",
                table: "loaisachs");

            migrationBuilder.DropIndex(
                name: "IX_loaisachs_sachMaSach",
                table: "loaisachs");

            migrationBuilder.DropColumn(
                name: "sachMaSach",
                table: "loaisachs");

            migrationBuilder.AddColumn<string>(
                name: "loaisachMaLoai",
                table: "loaisachs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "loaisachs",
                keyColumn: "MaLoai",
                keyValue: "Cong nghe thong tin",
                column: "loaisachMaLoai",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_loaisachs_loaisachMaLoai",
                table: "loaisachs",
                column: "loaisachMaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_loaisachs_loaisachs_loaisachMaLoai",
                table: "loaisachs",
                column: "loaisachMaLoai",
                principalTable: "loaisachs",
                principalColumn: "MaLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loaisachs_loaisachs_loaisachMaLoai",
                table: "loaisachs");

            migrationBuilder.DropIndex(
                name: "IX_loaisachs_loaisachMaLoai",
                table: "loaisachs");

            migrationBuilder.DropColumn(
                name: "loaisachMaLoai",
                table: "loaisachs");

            migrationBuilder.AddColumn<int>(
                name: "sachMaSach",
                table: "loaisachs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "loaisachs",
                keyColumn: "MaLoai",
                keyValue: "Cong nghe thong tin",
                column: "sachMaSach",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_loaisachs_sachMaSach",
                table: "loaisachs",
                column: "sachMaSach");

            migrationBuilder.AddForeignKey(
                name: "FK_loaisachs_sachs_sachMaSach",
                table: "loaisachs",
                column: "sachMaSach",
                principalTable: "sachs",
                principalColumn: "MaSach");
        }
    }
}
