using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrategyMack.Migrations
{
    /// <inheritdoc />
    public partial class AddMultiple : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "AttributeDetail");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "AttributeDetail");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "AttributeDetail");

            migrationBuilder.CreateTable(
                name: "AttributeDetailMultiple",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    District = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    JanuaryValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FebruaryValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarchValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AprilValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MayValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuneValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JulyValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AugustValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeptemberValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OctoberValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NovemberValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecemberValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InitiativeAttributeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeDetailMultiple", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeDetailMultiple_InitiativeAttribute_InitiativeAttributeId",
                        column: x => x.InitiativeAttributeId,
                        principalTable: "InitiativeAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeDetailMultiple_InitiativeAttributeId",
                table: "AttributeDetailMultiple",
                column: "InitiativeAttributeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeDetailMultiple");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "AttributeDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "AttributeDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "AttributeDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
