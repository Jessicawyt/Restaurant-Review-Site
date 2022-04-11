using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class AddedMcdonaldsImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://th.bing.com/th/id/R.a7030fb5624db3715b9a0b0698b1352f?rik=qMWOVvISFUC9Ig&riu=http%3a%2f%2fpngimg.com%2fuploads%2fmcdonalds%2fmcdonalds_PNG19.png&ehk=DcGet8JyK0nOmVYPW80XxvGb5RhYzJs4JLr%2fCOBW8Wk%3d&risl=&pid=ImgRaw&r=0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRINiC0VEj69xrRNKl52hIhXR82J5_iOZ2S3n3w_SIUwARJHL9t");
        }
    }
}
