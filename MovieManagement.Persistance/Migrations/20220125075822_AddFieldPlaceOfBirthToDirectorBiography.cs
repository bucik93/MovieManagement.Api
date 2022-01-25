using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieManagement.Persistance.Migrations
{
    public partial class AddFieldPlaceOfBirthToDirectorBiography : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlaceOfBirth",
                table: "DirectorBiographies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 1, 25, 8, 58, 21, 737, DateTimeKind.Local).AddTicks(9035));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceOfBirth",
                table: "DirectorBiographies");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 1, 24, 9, 9, 44, 515, DateTimeKind.Local).AddTicks(9400));
        }
    }
}
