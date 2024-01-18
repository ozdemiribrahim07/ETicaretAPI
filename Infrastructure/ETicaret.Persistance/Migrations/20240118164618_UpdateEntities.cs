using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaret.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandName", "CreatedTime" },
                values: new object[] { "Baby", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandName", "CreatedTime" },
                values: new object[] { "Games, Computers & Toys", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandName", "CreatedTime" },
                values: new object[] { "Books & Baby", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandName", "CreatedTime" },
                values: new object[] { "Games, Clothing & Industrial", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 18, 19, 46, 17, 295, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 18, 19, 46, 17, 295, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 18, 19, 46, 17, 295, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "DetailDesc", "DetailTitle" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 46, 17, 308, DateTimeKind.Local).AddTicks(3386), "Non ut amet repellendus magni odit.", "Quas quaerat quam odio reiciendis aut et sed nihil." });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "DetailDesc", "DetailTitle" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 46, 17, 308, DateTimeKind.Local).AddTicks(3470), "Voluptate saepe ullam et culpa maxime.", "Eum fuga quis sint aut fugit qui." });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "DetailDesc", "DetailTitle" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 46, 17, 308, DateTimeKind.Local).AddTicks(3542), "Est sunt eius aut et quasi.", "Voluptatum voluptatem occaecati nesciunt quo voluptas." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedTime", "ProductDesc", "ProductDiscount", "ProductName", "ProductPrice" },
                values: new object[] { null, new DateTime(2024, 1, 18, 19, 46, 17, 302, DateTimeKind.Local).AddTicks(6800), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0.7467474026736730m, "Small Steel Shoes", 472.92m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedTime", "ProductDesc", "ProductDiscount", "ProductName", "ProductPrice" },
                values: new object[] { null, new DateTime(2024, 1, 18, 19, 46, 17, 302, DateTimeKind.Local).AddTicks(7028), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2.775587319993520m, "Ergonomic Rubber Chicken", 220.05m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedTime", "ProductDesc", "ProductDiscount", "ProductName", "ProductPrice" },
                values: new object[] { null, new DateTime(2024, 1, 18, 19, 46, 17, 302, DateTimeKind.Local).AddTicks(7070), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 7.289052186462670m, "Tasty Fresh Sausages", 511.56m });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandName", "CreatedTime" },
                values: new object[] { "Jewelery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandName", "CreatedTime" },
                values: new object[] { "Jewelery & Beauty", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandName", "CreatedTime" },
                values: new object[] { "Shoes & Automotive", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandName", "CreatedTime" },
                values: new object[] { "Jewelery & Baby", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 16, 13, 36, 3, 499, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 16, 13, 36, 3, 499, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 16, 13, 36, 3, 499, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "DetailDesc", "DetailTitle" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 36, 3, 510, DateTimeKind.Local).AddTicks(7715), "Repellat provident quas iure commodi mollitia.", "Voluptas debitis quis quibusdam ipsam quasi recusandae suscipit minima non." });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "DetailDesc", "DetailTitle" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 36, 3, 510, DateTimeKind.Local).AddTicks(7954), "Sapiente eum quae pariatur nihil voluptates.", "Mollitia in sint et." });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "DetailDesc", "DetailTitle" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 36, 3, 510, DateTimeKind.Local).AddTicks(8073), "Eum aut reprehenderit eaque repudiandae occaecati.", "Sint magni pariatur eligendi explicabo ut ducimus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ProductDesc", "ProductDiscount", "ProductName", "ProductPrice" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 36, 3, 504, DateTimeKind.Local).AddTicks(6291), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7.287012184123090m, "Licensed Wooden Keyboard", 283.34m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ProductDesc", "ProductDiscount", "ProductName", "ProductPrice" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 36, 3, 504, DateTimeKind.Local).AddTicks(6556), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 9.916602247358470m, "Practical Frozen Keyboard", 1277.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ProductDesc", "ProductDiscount", "ProductName", "ProductPrice" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 36, 3, 504, DateTimeKind.Local).AddTicks(6617), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3.063177130208790m, "Licensed Soft Shirt", 1365.03m });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
