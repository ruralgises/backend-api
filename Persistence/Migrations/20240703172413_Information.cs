using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Information : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "informationDatabases",
                columns: table => new
                {
                    Entity = table.Column<int>(type: "integer", nullable: false),
                    DatabaseName = table.Column<string>(type: "text", nullable: false),
                    LastUpdate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsOfficial = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_informationDatabases", x => x.Entity);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "informationDatabases");
        }
    }
}
