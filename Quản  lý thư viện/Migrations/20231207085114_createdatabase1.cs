using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sachs",
                columns: table => new
                {
                    MaSach = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenSach = table.Column<string>(type: "TEXT", nullable: false),
                    MaLoai = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuong = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sachs", x => x.MaSach);
                });

            migrationBuilder.CreateTable(
                name: "loaisachs",
                columns: table => new
                {
                    MaLoai = table.Column<string>(type: "TEXT", nullable: false),
                    tenLoai = table.Column<string>(type: "TEXT", nullable: false),
                    sachMaSach = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaisachs", x => x.MaLoai);
                    table.ForeignKey(
                        name: "FK_loaisachs_sachs_sachMaSach",
                        column: x => x.sachMaSach,
                        principalTable: "sachs",
                        principalColumn: "MaSach");
                });

            migrationBuilder.InsertData(
                table: "loaisachs",
                columns: new[] { "MaLoai", "sachMaSach", "tenLoai" },
                values: new object[] { "Cong nghe thong tin", null, "Công nghệ thông tin" });

            migrationBuilder.CreateIndex(
                name: "IX_loaisachs_sachMaSach",
                table: "loaisachs",
                column: "sachMaSach");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loaisachs");

            migrationBuilder.DropTable(
                name: "sachs");
        }
    }
}
