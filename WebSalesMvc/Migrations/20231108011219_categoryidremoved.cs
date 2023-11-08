using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSalesMvc.Migrations
{
    public partial class categoryidremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Category",
                nullable: false,
                defaultValue: 0);
        }
    }
}
