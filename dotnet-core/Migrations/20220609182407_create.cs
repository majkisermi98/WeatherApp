using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace startup_kit_api.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 9, 20, 24, 7, 180, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 9, 20, 24, 7, 180, DateTimeKind.Local).AddTicks(9091));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 9, 20, 19, 9, 430, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 9, 20, 19, 9, 430, DateTimeKind.Local).AddTicks(5553));
        }
    }
}
