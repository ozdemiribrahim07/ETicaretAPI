using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ETicaret.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitFirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedTime", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "Jewelery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), false },
                    { 2, "Jewelery & Beauty", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, "Shoes & Automotive", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), false },
                    { 4, "Jewelery & Baby", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedTime", "IsDeleted", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, "Elektronik", new DateTime(2024, 1, 16, 13, 36, 3, 499, DateTimeKind.Local).AddTicks(9798), false, 0, 1 },
                    { 2, "Ev, Yaşam", new DateTime(2024, 1, 16, 13, 36, 3, 499, DateTimeKind.Local).AddTicks(9802), false, 0, 2 },
                    { 3, "Bilgisayar", new DateTime(2024, 1, 16, 13, 36, 3, 499, DateTimeKind.Local).AddTicks(9805), false, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CategoryId", "CreatedTime", "DetailDesc", "DetailTitle", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 16, 13, 36, 3, 510, DateTimeKind.Local).AddTicks(7715), "Repellat provident quas iure commodi mollitia.", "Voluptas debitis quis quibusdam ipsam quasi recusandae suscipit minima non.", false },
                    { 2, 1, new DateTime(2024, 1, 16, 13, 36, 3, 510, DateTimeKind.Local).AddTicks(7954), "Sapiente eum quae pariatur nihil voluptates.", "Mollitia in sint et.", false },
                    { 3, 2, new DateTime(2024, 1, 16, 13, 36, 3, 510, DateTimeKind.Local).AddTicks(8073), "Eum aut reprehenderit eaque repudiandae occaecati.", "Sint magni pariatur eligendi explicabo ut ducimus.", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedTime", "IsDeleted", "ProductDesc", "ProductDiscount", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 16, 13, 36, 3, 504, DateTimeKind.Local).AddTicks(6291), false, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7.287012184123090m, "Licensed Wooden Keyboard", 283.34m },
                    { 2, 2, new DateTime(2024, 1, 16, 13, 36, 3, 504, DateTimeKind.Local).AddTicks(6556), false, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 9.916602247358470m, "Practical Frozen Keyboard", 1277.00m },
                    { 3, 1, new DateTime(2024, 1, 16, 13, 36, 3, 504, DateTimeKind.Local).AddTicks(6617), false, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3.063177130208790m, "Licensed Soft Shirt", 1365.03m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_CategoryId",
                table: "ProductDetails",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
