using Microsoft.EntityFrameworkCore.Migrations;

namespace PosBank.Migrations
{
    public partial class alterTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_ProductDetails_OrderItems_ProductDetailsId",
                table: "OrderItem_ProductDetails");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductDetails_OrderItemId",
                table: "OrderItem_ProductDetails",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_ProductDetails_OrderItems_OrderItemId",
                table: "OrderItem_ProductDetails",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_ProductDetails_OrderItems_OrderItemId",
                table: "OrderItem_ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductDetails_OrderItemId",
                table: "OrderItem_ProductDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_ProductDetails_OrderItems_ProductDetailsId",
                table: "OrderItem_ProductDetails",
                column: "ProductDetailsId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
