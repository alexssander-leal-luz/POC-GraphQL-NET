using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQL.Example.Migrations
{
  public partial class InitialCreation : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AlterDatabase()
        .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.CreateTable(
          name: "reg_notes",
          columns: table => new
          {
            Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            message = table.Column<string>(type: "varchar(100)", nullable: false)
              .Annotation("MySql:CharSet", "utf8mb4"),
            Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
            DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_reg_notes", x => x.Id);
          })
          .Annotation("MySql:CharSet", "utf8mb4");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
        name: "reg_notes");
    }
  }
}
