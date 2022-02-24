using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class updatedWendysPng : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://freepikpsd.com/file/2019/11/wendys-logo-transparent-png-2-Images.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://flyclipart.com/thumb2/wendys-logo-png-transparent-wendys-logo-images-252225.png");
        }
    }
}
