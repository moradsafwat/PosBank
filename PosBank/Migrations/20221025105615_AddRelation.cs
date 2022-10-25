using Microsoft.EntityFrameworkCore.Migrations;

namespace PosBank.Migrations
{
    public partial class AddRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsDetails_Products_ProductId1",
                table: "ProductsDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductsDetails_ProductId1",
                table: "ProductsDetails");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "ProductsDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "ProductsDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDetails_ProductId1",
                table: "ProductsDetails",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsDetails_Products_ProductId1",
                table: "ProductsDetails",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
