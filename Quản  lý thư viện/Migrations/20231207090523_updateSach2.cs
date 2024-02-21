using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class updateSach2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sachs_loaisachs_loaisachMaLoai",
                table: "sachs");

            migrationBuilder.DropForeignKey(
                name: "FK_sachs_sachs_SachMaSach",
                table: "sachs");

            migrationBuilder.DropIndex(
                name: "IX_sachs_loaisachMaLoai",
                table: "sachs");

            migrationBuilder.DropIndex(
                name: "IX_sachs_SachMaSach",
                table: "sachs");

            migrationBuilder.DropColumn(
                name: "SachMaSach",
                table: "sachs");

            migrationBuilder.DropColumn(
                name: "loaisachMaLoai",
                table: "sachs");

            migrationBuilder.CreateIndex(
                name: "IX_sachs_MaLoai",
                table: "sachs",
                column: "MaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_sachs_loaisachs_MaLoai",
                table: "sachs",
                column: "MaLoai",
                principalTable: "loaisachs",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sachs_loaisachs_MaLoai",
                table: "sachs");

            migrationBuilder.DropIndex(
                name: "IX_sachs_MaLoai",
                table: "sachs");

            migrationBuilder.AddColumn<int>(
                name: "SachMaSach",
                table: "sachs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "loaisachMaLoai",
                table: "sachs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_sachs_loaisachMaLoai",
                table: "sachs",
                column: "loaisachMaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_sachs_SachMaSach",
                table: "sachs",
                column: "SachMaSach");

            migrationBuilder.AddForeignKey(
                name: "FK_sachs_loaisachs_loaisachMaLoai",
                table: "sachs",
                column: "loaisachMaLoai",
                principalTable: "loaisachs",
                principalColumn: "MaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_sachs_sachs_SachMaSach",
                table: "sachs",
                column: "SachMaSach",
                principalTable: "sachs",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
