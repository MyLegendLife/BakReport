using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bak.Report.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_ReportCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ReportCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_ReportInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Introduction = table.Column<string>(maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DocUri = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ReportInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ReportInfo_T_ReportCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "T_ReportCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ReportImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sort = table.Column<int>(nullable: false),
                    Uri = table.Column<string>(maxLength: 200, nullable: false),
                    ReportInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ReportImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ReportImage_T_ReportInfo_ReportInfoId",
                        column: x => x.ReportInfoId,
                        principalTable: "T_ReportInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ReportImage_ReportInfoId",
                table: "T_ReportImage",
                column: "ReportInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ReportInfo_CategoryId",
                table: "T_ReportInfo",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_ReportImage");

            migrationBuilder.DropTable(
                name: "T_ReportInfo");

            migrationBuilder.DropTable(
                name: "T_ReportCategory");
        }
    }
}
