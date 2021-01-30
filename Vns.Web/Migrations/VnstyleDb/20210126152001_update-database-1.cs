using Microsoft.EntityFrameworkCore.Migrations;

namespace Vns.Web.Migrations.VnstyleDb
{
    public partial class updatedatabase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageDescription",
                table: "Images",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageDescription",
                table: "Images");
        }
    }
}
