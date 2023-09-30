using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTermProject.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BookFormat = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorName", "BookFormat", "BookTitle", "Genre" },
                values: new object[] { 1, "JK Rowling", 2, "Harry Potter and the Sorcerer's Stone", "Fantasy" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorName", "BookFormat", "BookTitle", "Genre" },
                values: new object[] { 2, "James Clear", 0, "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", "Self-Help" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorName", "BookFormat", "BookTitle", "Genre" },
                values: new object[] { 3, "Kristin Hannah", null, "Night Road", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
