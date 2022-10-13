using Microsoft.EntityFrameworkCore.Migrations;

namespace WuzzyBears.Data.Migrations
{
    public partial class CustomerRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CostOfTeddy",
                table: "WuzzyBear",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "CustomerRating",
                table: "WuzzyBear",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerRating",
                table: "WuzzyBear");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostOfTeddy",
                table: "WuzzyBear",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
