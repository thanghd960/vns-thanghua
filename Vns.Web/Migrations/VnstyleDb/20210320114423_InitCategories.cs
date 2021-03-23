using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vns.Web.Migrations.VnstyleDb
{
    public partial class InitCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ApprovedBy", "ApprovedDate", "CreatedBy", "CreatedDate", "Description", "Index", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(1810), "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2350), "Hình Xăm", 1, "TA", true },
                    { 2, "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2450), "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2460), "Xỏ khuyên", 2, "PI", true },
                    { 3, "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2470), "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2470), "Artist", 3, "PF", true },
                    { 4, "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2470), "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2470), "Sự kiện", 4, "EV", true },
                    { 5, "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2480), "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2480), "Khoá học", 5, "CO", true },
                    { 6, "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2490), "admin", new DateTime(2021, 3, 20, 18, 44, 22, 619, DateTimeKind.Local).AddTicks(2490), "Giới thiệu", 6, "IN", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
