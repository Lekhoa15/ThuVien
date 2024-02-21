using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SachMaSach",
                table: "sachs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_sachs_SachMaSach",
                table: "sachs",
                column: "SachMaSach");

            migrationBuilder.AddForeignKey(
                name: "FK_sachs_sachs_SachMaSach",
                table: "sachs",
                column: "SachMaSach",
                principalTable: "sachs",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sachs_sachs_SachMaSach",
                table: "sachs");

            migrationBuilder.DropIndex(
                name: "IX_sachs_SachMaSach",
                table: "sachs");

            migrationBuilder.DropColumn(
                name: "SachMaSach",
                table: "sachs");
        }
    }
}
