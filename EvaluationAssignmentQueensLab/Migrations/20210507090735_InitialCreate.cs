using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EvaluationAssignmentQueensLab.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnterExit",
                columns: table => new
                {
                    EnterExitID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnterExit", x => x.EnterExitID);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopID);
                });

            migrationBuilder.CreateTable(
                name: "sections",
                columns: table => new
                {
                    SectionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorAmount = table.Column<int>(type: "int", nullable: true),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sections", x => x.SectionID);
                    table.ForeignKey(
                        name: "FK_sections_Shops_ShopID",
                        column: x => x.ShopID,
                        principalTable: "Shops",
                        principalColumn: "ShopID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visitors",
                columns: table => new
                {
                    VisitorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VisitorEntered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShopID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnterExitID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitors", x => x.VisitorID);
                    table.ForeignKey(
                        name: "FK_visitors_EnterExit_EnterExitID",
                        column: x => x.EnterExitID,
                        principalTable: "EnterExit",
                        principalColumn: "EnterExitID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitors_sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "sections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitors_Shops_ShopID",
                        column: x => x.ShopID,
                        principalTable: "Shops",
                        principalColumn: "ShopID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sections_ShopID",
                table: "sections",
                column: "ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_visitors_EnterExitID",
                table: "visitors",
                column: "EnterExitID");

            migrationBuilder.CreateIndex(
                name: "IX_visitors_SectionID",
                table: "visitors",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_visitors_ShopID",
                table: "visitors",
                column: "ShopID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "visitors");

            migrationBuilder.DropTable(
                name: "EnterExit");

            migrationBuilder.DropTable(
                name: "sections");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
