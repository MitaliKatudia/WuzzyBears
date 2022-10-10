using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WuzzyBears.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WuzzyBear",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeddySerialNumber = table.Column<string>(nullable: true),
                    TypeOfTeddy = table.Column<string>(nullable: true),
                    MaterialOfTeddy = table.Column<string>(nullable: true),
                    Manufactured = table.Column<DateTime>(nullable: false),
                    SizeOfTeddy = table.Column<int>(nullable: false),
                    CostOfTeddy = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WuzzyBear", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WuzzyBear");
        }
    }
}
