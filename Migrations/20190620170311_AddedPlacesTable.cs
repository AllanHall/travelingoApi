using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace travelingoapi.Migrations
{
  public partial class AddedPlacesTable : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Places",
          columns: table => new
          {
            id = table.Column<int>(nullable: false)
                  .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
            FirstName = table.Column<string>(nullable: true),
            LastName = table.Column<string>(nullable: true),
            Location = table.Column<string>(nullable: true),
            Address = table.Column<string>(nullable: true),
            Language = table.Column<string>(nullable: true),
            WebsiteUrl = table.Column<string>(nullable: true),
            Description = table.Column<string>(nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Places", x => x.id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Places");
    }
  }
}
