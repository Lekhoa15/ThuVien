using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "loaisachMaLoai",
                table: "sachs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_sachs_loaisachMaLoai",
                table: "sachs",
                column: "loaisachMaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_sachs_loaisachs_loaisachMaLoai",
                table: "sachs",
                column: "loaisachMaLoai",
                principalTable: "loaisachs",
                principalColumn: "MaLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sachs_loaisachs_loaisachMaLoai",
                table: "sachs");

            migrationBuilder.DropIndex(
                name: "IX_sachs_loaisachMaLoai",
                table: "sachs");

            migrationBuilder.DropColumn(
                name: "loaisachMaLoai",
                table: "sachs");

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
    }
}
