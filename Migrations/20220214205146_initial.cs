using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class initial : Migration
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reviews_restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "Cleveland", "McDonalds" });

            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 2, "Cleveland", "Wendys" });

            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 3, "Cleveland", "Chick-Fil-A" });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "Id", "Content", "Name", "RestaurantId" },
                values: new object[] { 1, "Absolutely the worst restaurant!Always short staffed...", "Sue", 1 });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "Id", "Content", "Name", "RestaurantId" },
                values: new object[] { 2, "Overrated!", "Leah", 2 });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "Id", "Content", "Name", "RestaurantId" },
                values: new object[] { 3, "Very Meeeeeeh!", "Poppy", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_reviews_RestaurantId",
                table: "reviews",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "restaurants");
        }
    }
}
