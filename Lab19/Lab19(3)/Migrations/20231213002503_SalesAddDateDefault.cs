using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab19_3_.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-5522-0303-5753", "Emmett_Hayes@hotmail.com", "Emmett Hayes" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "4210-6494-9713-1518", "Clinton_Kunze@yahoo.com", "Clinton Kunze" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6771-8933-2473-6760", "Mike.Fay59@yahoo.com", "Mike Fay" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6011-0973-4619-4608", "Calvin93@gmail.com", "Calvin Carter" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-3052-1548-1899", "Gloria.OKon@yahoo.com", "Gloria O'Kon" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6381-6364-3299-3746", "Duane70@gmail.com", "Duane Schultz" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "4519484841312", "Carl_Wiza@gmail.com", "Carl Wiza" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-1674-0188-9289", "Kellie.Lindgren@yahoo.com", "Kellie Lindgren" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6372-8278-5979-5737", "Dallas_Nicolas@gmail.com", "Dallas Nicolas" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3528-0212-2851-8984", "Johnny36@hotmail.com", "Johnny Sporer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Licensed Rubber Computer", 246.38681f, 55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Wooden Ball", 743.9417f, 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Wooden Mouse", 189.6792f, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Metal Shoes", 616.309f, 51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Soft Bacon", 95.58535f, 87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Description", "Price", "Quantity" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 74.35718f, 87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Concrete Shirt", 198.99988f, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Plastic Ball", 786.77374f, 66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Concrete Table", 472.4277f, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Rubber Shoes", 717.15326f, 43 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 7, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 6, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "ProductId", "StoreId" },
                values: new object[] { 10, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 11,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 12,
                columns: new[] { "CustomerId", "StoreId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 13,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 6, 9, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 14,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 7, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 15,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 6, 8, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 16,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 6, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 17,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 5, 9, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 18,
                columns: new[] { "ProductId", "StoreId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 19,
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 20,
                column: "ProductId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 21,
                columns: new[] { "CustomerId", "StoreId" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 22,
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 23,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 10, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 24,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 4, 7, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 25,
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Friesen, Bechtelar and Glover");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Rolfson - Turner");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "White, Gutmann and Ortiz");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Braun Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Corkery, Conroy and Hackett");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6759-7268-2746-1555-306", "Ernesto88@yahoo.com", "Ernesto Kohler" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5038-5699-9887-5024", "Jeffrey.Botsford@gmail.com", "Jeffrey Botsford" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6371-9631-6316-8138", "Jeffery28@gmail.com", "Jeffery Larkin" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6378-6532-2355-2149", "Brad_Swift@hotmail.com", "Brad Swift" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5020083282003590", "Hope.Huels51@gmail.com", "Hope Huels" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5323-3053-8882-7687", "Candace_McKenzie@yahoo.com", "Candace McKenzie" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6011-3205-2791-9266", "Dale.Hahn17@yahoo.com", "Dale Hahn" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6504-6233-9334-5001-6106", "Alyssa6@yahoo.com", "Alyssa Ortiz" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5402-8853-7201-9262", "Manuel.Mills@gmail.com", "Manuel Mills" });

            migrationBuilder.UpdateData(
                table: "Customets",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6771263691340622", "Jean.Wunsch@gmail.com", "Jean Wunsch" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Awesome Concrete Bike", 854.48083f, 74 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Frozen Gloves", 269.22134f, 48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Fresh Chair", 688.27606f, 97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Fresh Gloves", 367.18387f, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Soft Keyboard", 757.8459f, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Description", "Price", "Quantity" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 724.5819f, 98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Wooden Bacon", 593.89404f, 39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Wooden Chair", 202.80696f, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Steel Mouse", 38.69035f, 97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Soft Pants", 966.2812f, 19 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 3, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 5, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 7, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[] { 6, 10 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "ProductId", "StoreId" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 11,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 7, 9, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 12,
                columns: new[] { "CustomerId", "StoreId" },
                values: new object[] { 10, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 13,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 14,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 15,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 5, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 16,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 17,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 2, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 18,
                columns: new[] { "ProductId", "StoreId" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 19,
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 20,
                column: "ProductId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 21,
                columns: new[] { "CustomerId", "StoreId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 22,
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 23,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 24,
                columns: new[] { "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 9, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 25,
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[] { 6, 10 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Anderson, Corkery and Williamson");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Kohler, Glover and Leffler");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Kris, Lynch and Crooks");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Kohler and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "McLaughlin Inc");
        }
    }
}
