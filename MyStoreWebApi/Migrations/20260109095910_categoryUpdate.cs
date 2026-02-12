using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyStoreWebApi.Migrations
{
    /// <inheritdoc />
    public partial class categoryUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_products_ProductId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Category_CategoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "productsImage");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "categories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductId",
                table: "productsImage",
                newName: "IX_productsImage_ProductId");

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                table: "productsImage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_productsImage",
                table: "productsImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productsImage_products_ProductId",
                table: "productsImage",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_productsImage_products_ProductId",
                table: "productsImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productsImage",
                table: "productsImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "IsPrimary",
                table: "productsImage");

            migrationBuilder.RenameTable(
                name: "productsImage",
                newName: "ProductImage");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_productsImage_ProductId",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_products_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Category_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
