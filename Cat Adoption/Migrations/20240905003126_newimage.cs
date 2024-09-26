using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cat_Adoption.Migrations
{
    /// <inheritdoc />
    public partial class newimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "CatsForAdoption",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url",
                table: "CatsForAdoption");
        }
    }
}
