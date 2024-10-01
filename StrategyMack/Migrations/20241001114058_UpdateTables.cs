using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrategyMack.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeDetail_InitiativeAttribute_InitiativeAttributeId",
                table: "AttributeDetail");

            migrationBuilder.AlterColumn<int>(
                name: "InitiativeAttributeId",
                table: "AttributeDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InitiativeId",
                table: "AttributeDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeDetail_InitiativeAttribute_InitiativeAttributeId",
                table: "AttributeDetail",
                column: "InitiativeAttributeId",
                principalTable: "InitiativeAttribute",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeDetail_InitiativeAttribute_InitiativeAttributeId",
                table: "AttributeDetail");

            migrationBuilder.DropColumn(
                name: "InitiativeId",
                table: "AttributeDetail");

            migrationBuilder.AlterColumn<int>(
                name: "InitiativeAttributeId",
                table: "AttributeDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeDetail_InitiativeAttribute_InitiativeAttributeId",
                table: "AttributeDetail",
                column: "InitiativeAttributeId",
                principalTable: "InitiativeAttribute",
                principalColumn: "Id");
        }
    }
}
