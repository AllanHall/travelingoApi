using Microsoft.EntityFrameworkCore.Migrations;

namespace travelingoapi.Migrations
{
    public partial class AddedMoreColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Places",
                table: "Places");

            migrationBuilder.RenameTable(
                name: "Places",
                newName: "Sites");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Sites",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Sites",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Sites",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "Sites",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Sites",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sites",
                table: "Sites",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sites",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Sites");

            migrationBuilder.RenameTable(
                name: "Sites",
                newName: "Places");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Places",
                newName: "Location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Places",
                table: "Places",
                column: "id");
        }
    }
}
