using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FashionStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class testseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 9998, 12, "A6", "/images/audi.jpg", "Audi", 2022m },
                    { 9999, 11, "V90", "/images/volvo.jpg", "Volvo", 2021m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9998);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9999);
        }
    }
}
