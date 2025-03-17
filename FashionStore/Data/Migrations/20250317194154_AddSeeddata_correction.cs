using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeddata_correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1039,
                column: "ImageUrl",
                value: "/images/sw_ADRO.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1041,
                column: "ImageUrl",
                value: "/images/sw_GRECIILOOKS.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1116,
                column: "ImageUrl",
                value: "/images/12_Woodland.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1255,
                column: "ImageUrl",
                value: " /images/36_boAt.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1039,
                column: "ImageUrl",
                value: "/images/sw_ADRO  .jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1041,
                column: "ImageUrl",
                value: "/images/sw_GRECIILOOKS .jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1116,
                column: "ImageUrl",
                value: "/images/12_Woodland .jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1255,
                column: "ImageUrl",
                value: " / images / 36_boAt.jpg");
        }
    }
}
