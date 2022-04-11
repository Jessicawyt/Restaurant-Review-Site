using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class addedImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRINiC0VEj69xrRNKl52hIhXR82J5_iOZ2S3n3w_SIUwARJHL9t");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Restaurants");
        }
    }
}
