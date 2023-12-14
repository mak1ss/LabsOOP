using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab22.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Copies = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    EditionType = table.Column<int>(type: "int", nullable: false),
                    AgeRestriction = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Svarovski" },
                    { 2, null, "Markoni" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Horror" },
                    { 2, "Detective" },
                    { 3, "Drama" },
                    { 4, "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AgeRestriction", "AuthorId", "Copies", "Description", "EditionType", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 2, 1, 100, "A great Book", 2, 159.99f, new DateOnly(2023, 12, 12), "Horror of London" },
                    { 2, 1, 1, 10, "Another great Book", 1, 159.99f, new DateOnly(2024, 2, 12), "Drama of London" },
                    { 3, 0, 2, 10, "An Ok Book", 1, 159.99f, new DateOnly(2020, 2, 12), "Detective of Chernivtsi" },
                    { 4, 2, 1, 50, "A suspenseful thriller", 0, 129.99f, new DateOnly(2022, 10, 15), "Thriller in Paris" },
                    { 5, 1, 1, 30, "Unravel the secrets of the haunted mansion", 2, 179.99f, new DateOnly(2023, 5, 20), "Mystery Mansion" },
                    { 6, 0, 2, 20, "Embark on a thrilling jungle adventure", 1, 99.99f, new DateOnly(2023, 8, 5), "Adventure in the Jungle" },
                    { 7, 2, 2, 40, "Explore the rich history of ancient civilizations", 0, 139.99f, new DateOnly(2022, 12, 1), "Historical Chronicles" },
                    { 8, 1, 1, 25, "Laugh out loud with hilarious comedy tales", 2, 119.99f, new DateOnly(2024, 3, 10), "Comedy Club Chronicles" },
                    { 9, 2, 2, 15, "Experience the magic of love in exotic locations", 2, 149.99f, new DateOnly(2021, 7, 22), "Romantic Getaway" },
                    { 10, 1, 1, 35, "Embark on an intergalactic journey", 0, 169.99f, new DateOnly(2022, 5, 18), "Sci-Fi Odyssey" },
                    { 11, 1, 1, 1, "ooooold boook", 0, 0f, new DateOnly(2009, 5, 18), "Old book" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 2 },
                    { 4, 4 },
                    { 5, 1 },
                    { 6, 3 },
                    { 7, 1 },
                    { 8, 4 },
                    { 9, 3 },
                    { 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_CategoryId",
                table: "BookCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
