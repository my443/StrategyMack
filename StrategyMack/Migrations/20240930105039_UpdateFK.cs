using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrategyMack.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttributeId",
                table: "AttributeDetail");

            migrationBuilder.AddColumn<int>(
                name: "AttributeDetailsId",
                table: "InitiativeAttribute",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttributeDetailsId",
                table: "InitiativeAttribute");

            migrationBuilder.AddColumn<int>(
                name: "AttributeId",
                table: "AttributeDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
