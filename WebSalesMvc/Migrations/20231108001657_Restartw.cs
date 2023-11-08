using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSalesMvc.Migrations
{
    public partial class Restartw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Department_DepartmentId",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Category",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Department_DepartmentId",
                table: "Category",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Department_DepartmentId",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Category",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Department_DepartmentId",
                table: "Category",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
