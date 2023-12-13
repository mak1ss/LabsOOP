using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab19_3_.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAddColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "No description");


            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6759977435253900", "Mabel0@hotmail.com", "Mabel Steuber" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6011-3298-1327-5473", "Edna_Mante@hotmail.com", "Edna Mante" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6376-9629-4830-2256", "Antonia_Ferry71@hotmail.com", "Antonia Ferry" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6706624395792725", "Jerome.Roob@gmail.com", "Jerome Roob" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3528-2810-9415-4708", "Hilda66@yahoo.com", "Hilda Price" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5434-0702-3690-1565", "Jeanette.Conroy53@gmail.com", "Jeanette Conroy" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6709662648398699", "Miriam.Treutel@gmail.com", "Miriam Treutel" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6388-0700-5431-3327", "Chelsea67@hotmail.com", "Chelsea Runolfsson" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3574-7545-8367-3415", "Lynn.Waelchi@hotmail.com", "Lynn Waelchi" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6763988180751478200", "Victoria_Gislason4@gmail.com", "Victoria Gislason" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Practical Soft Sausages", 545.5936f, 88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Practical Cotton Shirt", 853.9472f, 46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Intelligent Granite Computer", 343.28452f, 43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Licensed Rubber Bacon", 584.2415f, 93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Fantastic Plastic Computer", 187.06796f, 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Awesome Soft Pants", 421.91278f, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Practical Cotton Towels", 350.6449f, 57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Licensed Steel Mouse", 745.66693f, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Gorgeous Metal Chicken", 553.50635f, 97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Awesome Granite Car", 253.09038f, 92 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 10, new DateOnly(2023, 12, 12), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 6, new DateOnly(2023, 12, 12), 3, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 2, new DateOnly(2023, 12, 13), 10, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 8, 10, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateOnly(2023, 12, 12), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 11,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 5, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 12,
                columns: new[] { "CustomerId", "Date", "ProductId" },
                values: new object[] { 5, new DateOnly(2023, 12, 12), 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 13,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 1, new DateOnly(2023, 12, 12), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 14,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 2, new DateOnly(2023, 12, 13), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 15,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 1, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 16,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 17,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 1, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 18,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 6, new DateOnly(2023, 12, 13), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 19,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 9, 8, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 20,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 1, new DateOnly(2023, 12, 12), 8, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 21,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 8, 9, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 22,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 3, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 23,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 1, 10, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 24,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateOnly(2023, 12, 13), 8, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 25,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 3, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Toy - Borer");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Schowalter and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Brekke, Kilback and Harvey");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Block, Green and Gulgowski");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Funk, Hermann and Gaylord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3665-075320-3041", "Laverne70@hotmail.com", "Laverne Brown" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3450-315947-76584", "Perry19@hotmail.com", "Perry Kunze" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6759-2990-9150-0940", "Tracey82@gmail.com", "Tracey Miller" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "630434157621006921", "Carole.Daniel1@hotmail.com", "Carole Daniel" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5893-5886-0787-2507", "Lionel_Ondricka50@yahoo.com", "Lionel Ondricka" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3528-1076-3172-2576", "Lance36@gmail.com", "Lance Wilkinson" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6759-2594-5719-8816-832", "Warren65@hotmail.com", "Warren Auer" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6304578302259881516", "Ernesto.Jenkins87@hotmail.com", "Ernesto Jenkins" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5893-5043-2454-2430", "Johnathan_Nienow44@hotmail.com", "Johnathan Nienow" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6759-0926-9514-3124-106", "Iris35@gmail.com", "Iris Jones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Practical Concrete Ball", 854.9404f, 79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Rustic Wooden Salad", 933.5612f, 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Tasty Granite Car", 858.21014f, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Incredible Wooden Hat", 100.47606f, 63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Fantastic Granite Shoes", 193.91866f, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Fantastic Cotton Bacon", 484.18298f, 57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Unbranded Fresh Shoes", 994.6787f, 79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Sleek Frozen Bacon", 924.1591f, 76 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Sleek Fresh Pants", 355.43805f, 76 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Gorgeous Soft Keyboard", 197.98871f, 62 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateOnly(2023, 12, 13), 8, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 5, new DateOnly(2023, 12, 13), 4, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 3, new DateOnly(2023, 12, 12), 8, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 7, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 2, new DateOnly(2023, 12, 13), 3, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 11,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 12,
                columns: new[] { "CustomerId", "Date", "ProductId" },
                values: new object[] { 8, new DateOnly(2023, 12, 13), 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 13,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 4, new DateOnly(2023, 12, 13), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 14,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateOnly(2023, 12, 12), 9, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 15,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 5, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 16,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 10, 9, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 17,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 6, 7, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 18,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 1, new DateOnly(2023, 12, 12), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 19,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 8, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 20,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 6, new DateOnly(2023, 12, 13), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 21,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 22,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 10, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 23,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 10, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 24,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 4, new DateOnly(2023, 12, 12), 6, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 25,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 1, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Klein and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Wilkinson - White");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Herman - Borer");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Rempel - Tromp");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Heaney, Leannon and Robel");
        }
    }
}
