using Microsoft.EntityFrameworkCore.Migrations;

namespace Vns.Web.Migrations.VnstyleDb
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionShort",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeature",
                table: "Articles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHomePage",
                table: "Articles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTrendingNow",
                table: "Articles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "View",
                table: "Articles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "DescriptionShort",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "IsFeature",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "IsHomePage",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "IsTrendingNow",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "View",
                table: "Articles");
        }
    }
}
