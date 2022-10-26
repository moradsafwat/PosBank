using Microsoft.EntityFrameworkCore.Migrations;

namespace PosBank.Migrations
{
    public partial class createOrderItemTblWithRela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "ProductsDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderItem_ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    ProductDetailsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_ProductDetails_OrderItems_ProductDetailsId",
                        column: x => x.ProductDetailsId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_ProductDetails_ProductsDetails_ProductDetailsId",
                        column: x => x.ProductDetailsId,
                        principalTable: "ProductsDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDetails_OrderItemId",
                table: "ProductsDetails",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductDetails_ProductDetailsId",
                table: "OrderItem_ProductDetails",
                column: "ProductDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsDetails_OrderItems_OrderItemId",
                table: "ProductsDetails",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsDetails_OrderItems_OrderItemId",
                table: "ProductsDetails");

            migrationBuilder.DropTable(
                name: "OrderItem_ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductsDetails_OrderItemId",
                table: "ProductsDetails");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "ProductsDetails");
        }
    }
}
