using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpacebookAPI.Migrations
{
    public partial class segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "viagem_url",
                table: "Viagem",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "viagem_url",
                table: "Viagem");
        }
    }
}
