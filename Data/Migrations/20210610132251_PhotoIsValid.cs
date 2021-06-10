using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class PhotoIsValid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Groups_GroupName",
                table: "Connections");

            migrationBuilder.AddColumn<bool>(
                name: "isApproved",
                table: "Photos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Groups_GroupName",
                table: "Connections",
                column: "GroupName",
                principalTable: "Groups",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Groups_GroupName",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "isApproved",
                table: "Photos");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Groups_GroupName",
                table: "Connections",
                column: "GroupName",
                principalTable: "Groups",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
