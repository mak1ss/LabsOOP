using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab19_3_.Migrations
{
    /// <inheritdoc />
    public partial class SeedingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Products",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Customets",
                columns: new[] { "CustomerId", "CreditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "3665-075320-3041", "Laverne70@hotmail.com", "Laverne Brown" },
                    { 2, "3450-315947-76584", "Perry19@hotmail.com", "Perry Kunze" },
                    { 3, "6759-2990-9150-0940", "Tracey82@gmail.com", "Tracey Miller" },
                    { 4, "630434157621006921", "Carole.Daniel1@hotmail.com", "Carole Daniel" },
                    { 5, "5893-5886-0787-2507", "Lionel_Ondricka50@yahoo.com", "Lionel Ondricka" },
                    { 6, "3528-1076-3172-2576", "Lance36@gmail.com", "Lance Wilkinson" },
                    { 7, "6759-2594-5719-8816-832", "Warren65@hotmail.com", "Warren Auer" },
                    { 8, "6304578302259881516", "Ernesto.Jenkins87@hotmail.com", "Ernesto Jenkins" },
                    { 9, "5893-5043-2454-2430", "Johnathan_Nienow44@hotmail.com", "Johnathan Nienow" },
                    { 10, "6759-0926-9514-3124-106", "Iris35@gmail.com", "Iris Jones" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Practical Concrete Ball", 854.9404f, 79 },
                    { 2, "Rustic Wooden Salad", 933.5612f, 95 },
                    { 3, "Tasty Granite Car", 858.21014f, 18 },
                    { 4, "Incredible Wooden Hat", 100.47606f, 63 },
                    { 5, "Fantastic Granite Shoes", 193.91866f, 17 },
                    { 6, "Fantastic Cotton Bacon", 484.18298f, 57 },
                    { 7, "Unbranded Fresh Shoes", 994.6787f, 79 },
                    { 8, "Sleek Frozen Bacon", 924.1591f, 76 },
                    { 9, "Sleek Fresh Pants", 355.43805f, 76 },
                    { 10, "Gorgeous Soft Keyboard", 197.98871f, 62 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { 1, "Klein and Sons" },
                    { 2, "Wilkinson - White" },
                    { 3, "Herman - Borer" },
                    { 4, "Rempel - Tromp" },
                    { 5, "Heaney, Leannon and Robel" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { 6, 8, new DateOnly(2023, 12, 13), 8, 4 },
                    { 7, 5, new DateOnly(2023, 12, 13), 4, 4 },
                    { 8, 3, new DateOnly(2023, 12, 12), 8, 3 },
                    { 9, 7, new DateOnly(2023, 12, 13), 2, 2 },
                    { 10, 2, new DateOnly(2023, 12, 13), 3, 2 },
                    { 11, 4, new DateOnly(2023, 12, 13), 3, 3 },
                    { 12, 8, new DateOnly(2023, 12, 13), 3, 5 },
                    { 13, 4, new DateOnly(2023, 12, 13), 7, 2 },
                    { 14, 8, new DateOnly(2023, 12, 12), 9, 4 },
                    { 15, 5, new DateOnly(2023, 12, 13), 7, 1 },
                    { 16, 10, new DateOnly(2023, 12, 12), 9, 3 },
                    { 17, 6, new DateOnly(2023, 12, 12), 7, 5 },
                    { 18, 1, new DateOnly(2023, 12, 12), 9, 2 },
                    { 19, 8, new DateOnly(2023, 12, 12), 3, 4 },
                    { 20, 6, new DateOnly(2023, 12, 13), 5, 1 },
                    { 21, 2, new DateOnly(2023, 12, 13), 4, 4 },
                    { 22, 10, new DateOnly(2023, 12, 13), 2, 5 },
                    { 23, 10, new DateOnly(2023, 12, 12), 1, 4 },
                    { 24, 4, new DateOnly(2023, 12, 12), 6, 4 },
                    { 25, 1, new DateOnly(2023, 12, 12), 6, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
