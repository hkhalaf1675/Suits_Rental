using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suits_Rental.Migrations
{
    /// <inheritdoc />
    public partial class updateSuit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Suits",
                newName: "Size8");

            migrationBuilder.AddColumn<int>(
                name: "Size1",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size2",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size3",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size4",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size5",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size6",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size7",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size1",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size2",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size3",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size4",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size5",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size6",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size7",
                table: "Suits");

            migrationBuilder.RenameColumn(
                name: "Size8",
                table: "Suits",
                newName: "Size");
        }
    }
}
