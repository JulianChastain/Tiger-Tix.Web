using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiger_Tix.Web.Migrations
{
    public partial class KeyProblems2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemainingTickets = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserViewModelId = table.Column<int>(type: "int", nullable: true),
                    UserViewModelId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventModel_Users_UserViewModelId",
                        column: x => x.UserViewModelId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventModel_Users_UserViewModelId1",
                        column: x => x.UserViewModelId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventModel_UserViewModelId",
                table: "EventModel",
                column: "UserViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EventModel_UserViewModelId1",
                table: "EventModel",
                column: "UserViewModelId1");
        }
    }
}
