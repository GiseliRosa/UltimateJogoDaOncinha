using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogoDaOncinha.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Finalizada",
                table: "Apostas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Resultado",
                table: "Apostas",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finalizada",
                table: "Apostas");

            migrationBuilder.DropColumn(
                name: "Resultado",
                table: "Apostas");
        }
    }
}
