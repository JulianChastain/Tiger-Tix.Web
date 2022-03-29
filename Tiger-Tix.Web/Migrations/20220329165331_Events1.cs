using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiger_Tix.Web.Migrations
{
    public partial class Events1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EventModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RemainingTickets",
                table: "EventModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "EventModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "EventModel");

            migrationBuilder.DropColumn(
                name: "RemainingTickets",
                table: "EventModel");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "EventModel");
        }
    }
}
