using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurants", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Address", "Name", "Review" },
                values: new object[] { 1, "Cleveland", "McDonalds", "Love it!" });

            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Address", "Name", "Review" },
                values: new object[] { 2, "Cleveland", "Wendys", "Better than Mcd!" });

            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Address", "Name", "Review" },
                values: new object[] { 3, "Cleveland", "Chick-Fil-A", "Overrated!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "restaurants");
        }
    }
}
