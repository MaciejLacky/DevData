using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table_A",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Col_A1 = table.Column<int>(type: "int", nullable: false),
                    Col_A2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Col_A3 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_A", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table_B",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Col_B1 = table.Column<int>(type: "int", nullable: false),
                    Col_B2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Col_B3 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table_C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Col_C1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Col_C2 = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Col_C3 = table.Column<int>(type: "int", nullable: false),
                    Col_C4 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_C", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_A");

            migrationBuilder.DropTable(
                name: "Table_B");

            migrationBuilder.DropTable(
                name: "Table_C");
        }
    }
}
