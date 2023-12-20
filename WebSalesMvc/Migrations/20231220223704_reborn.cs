using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSalesMvc.Migrations
{
    public partial class reborn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "SalesRecord",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Product",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SalesRecordId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_SalesRecordId",
                table: "Product",
                column: "SalesRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SalesRecord_SalesRecordId",
                table: "Product",
                column: "SalesRecordId",
                principalTable: "SalesRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_SalesRecord_SalesRecordId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_SalesRecordId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SalesRecordId",
                table: "Product");
        }
    }
}
