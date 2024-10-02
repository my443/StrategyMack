using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrategyMack.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeDetailMultiple_InitiativeAttribute_InitiativeAttributeId",
                table: "AttributeDetailMultiple");

            migrationBuilder.DropIndex(
                name: "IX_AttributeDetailMultiple_InitiativeAttributeId",
                table: "AttributeDetailMultiple");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "AttributeDetailMultiple",
                newName: "InitiativeId");

            migrationBuilder.AlterColumn<decimal>(
                name: "SeptemberValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OctoberValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NovemberValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MayValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MarchValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "JuneValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "JulyValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FebruaryValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DecemberValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AugustValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AprilValue",
                table: "AttributeDetailMultiple",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FiscalYear",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiscalYear",
                table: "AttributeDetailMultiple");

            migrationBuilder.RenameColumn(
                name: "InitiativeId",
                table: "AttributeDetailMultiple",
                newName: "Year");

            migrationBuilder.AlterColumn<string>(
                name: "SeptemberValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "OctoberValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "NovemberValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "MayValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "MarchValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "JuneValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "JulyValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "FebruaryValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "DecemberValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "AugustValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "AprilValue",
                table: "AttributeDetailMultiple",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeDetailMultiple_InitiativeAttributeId",
                table: "AttributeDetailMultiple",
                column: "InitiativeAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeDetailMultiple_InitiativeAttribute_InitiativeAttributeId",
                table: "AttributeDetailMultiple",
                column: "InitiativeAttributeId",
                principalTable: "InitiativeAttribute",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
