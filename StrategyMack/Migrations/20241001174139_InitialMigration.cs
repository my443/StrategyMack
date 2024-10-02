using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrategyMack.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsAcive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Initiative",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Initiative", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InitiativeAttribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasMultipleDetails = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AttributeDetailsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitiativeAttribute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InitiativeId = table.Column<int>(type: "int", nullable: false),
                    InitiativeAttributeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeDetail_InitiativeAttribute_InitiativeAttributeId",
                        column: x => x.InitiativeAttributeId,
                        principalTable: "InitiativeAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AttributeDetail_InitiativeAttributeId",
                table: "AttributeDetail",
                column: "InitiativeAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeDetailMultiple_InitiativeAttributeId",
                table: "AttributeDetailMultiple",
                column: "InitiativeAttributeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "AttributeDetail");

            migrationBuilder.DropTable(
                name: "AttributeDetailMultiple");

            migrationBuilder.DropTable(
                name: "Initiative");

            migrationBuilder.DropTable(
                name: "InitiativeAttribute");
        }
    }
}
