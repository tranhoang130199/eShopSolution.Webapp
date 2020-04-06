using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowHome", "SortOrder" },
                values: new object[] { 1, true, 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowHome", "SortOrder" },
                values: new object[] { 2, false, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ViewCount" },
                values: new object[] { 1, 10000m, 1000 });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
