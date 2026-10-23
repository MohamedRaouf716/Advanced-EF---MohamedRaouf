using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" },
                    { 3, "Clothing" },
                    { 4, "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "15-inch laptop, 16GB RAM", "Laptop", 25000.00m, 15 },
                    { 2, 1, "Ergonomic wireless mouse", "Wireless Mouse", 350.00m, 50 },
                    { 3, 1, "RGB mechanical keyboard", "Mechanical Keyboard", 1200.00m, 30 },
                    { 4, 2, "Robert C. Martin - Software craftsmanship", "Clean Code", 450.00m, 20 },
                    { 5, 2, "Gang of Four - classic book", "Design Patterns", 520.00m, 12 },
                    { 6, 2, "Hunt & Thomas", "The Pragmatic Programmer", 480.00m, 18 },
                    { 7, 3, "Cotton t-shirt, size L", "T-Shirt", 200.00m, 100 },
                    { 8, 3, "Denim jeans, size 32", "Jeans", 650.00m, 40 },
                    { 9, 4, "Lightweight running shoes", "Running Shoes", 1800.00m, 25 },
                    { 10, 4, "Non-slip yoga mat 6mm", "Yoga Mat", 300.00m, 60 },
                    { 11, 4, "Adjustable dumbbells 20kg", "Dumbbells Set", 1500.00m, 10 },
                    { 12, 1, "7-in-1 USB-C hub", "USB-C Hub", 420.00m, 35 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
