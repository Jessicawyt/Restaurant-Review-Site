using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class updatedPNG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://flyclipart.com/thumb2/wendys-logo-png-transparent-wendys-logo-images-252225.png");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://logos-world.net/wp-content/uploads/2021/08/Chick-fil-A-Emblem.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRINiC0VEj69xrRNKl52hIhXR82J5_iOZ2S3n3w_SIUwARJHL9t");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://pbs.twimg.com/profile_images/1148729107406041088/emlH0Rv4_400x400.png");
        }
    }
}
