using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 789m },
                    { 72, "Description for product 72", "Product 72", 814m },
                    { 71, "Description for product 71", "Product 71", 167m },
                    { 70, "Description for product 70", "Product 70", 336m },
                    { 69, "Description for product 69", "Product 69", 387m },
                    { 68, "Description for product 68", "Product 68", 245m },
                    { 67, "Description for product 67", "Product 67", 735m },
                    { 66, "Description for product 66", "Product 66", 364m },
                    { 65, "Description for product 65", "Product 65", 516m },
                    { 64, "Description for product 64", "Product 64", 507m },
                    { 63, "Description for product 63", "Product 63", 344m },
                    { 62, "Description for product 62", "Product 62", 540m },
                    { 61, "Description for product 61", "Product 61", 981m },
                    { 60, "Description for product 60", "Product 60", 826m },
                    { 59, "Description for product 59", "Product 59", 539m },
                    { 58, "Description for product 58", "Product 58", 965m },
                    { 57, "Description for product 57", "Product 57", 962m },
                    { 56, "Description for product 56", "Product 56", 483m },
                    { 55, "Description for product 55", "Product 55", 331m },
                    { 54, "Description for product 54", "Product 54", 842m },
                    { 53, "Description for product 53", "Product 53", 778m },
                    { 52, "Description for product 52", "Product 52", 100m },
                    { 73, "Description for product 73", "Product 73", 575m },
                    { 51, "Description for product 51", "Product 51", 928m },
                    { 74, "Description for product 74", "Product 74", 269m },
                    { 76, "Description for product 76", "Product 76", 660m },
                    { 97, "Description for product 97", "Product 97", 715m },
                    { 96, "Description for product 96", "Product 96", 768m },
                    { 95, "Description for product 95", "Product 95", 903m },
                    { 94, "Description for product 94", "Product 94", 956m },
                    { 93, "Description for product 93", "Product 93", 343m },
                    { 92, "Description for product 92", "Product 92", 162m },
                    { 91, "Description for product 91", "Product 91", 448m },
                    { 90, "Description for product 90", "Product 90", 295m },
                    { 89, "Description for product 89", "Product 89", 444m },
                    { 88, "Description for product 88", "Product 88", 726m },
                    { 87, "Description for product 87", "Product 87", 449m },
                    { 86, "Description for product 86", "Product 86", 803m },
                    { 85, "Description for product 85", "Product 85", 157m },
                    { 84, "Description for product 84", "Product 84", 636m },
                    { 83, "Description for product 83", "Product 83", 889m },
                    { 82, "Description for product 82", "Product 82", 866m },
                    { 81, "Description for product 81", "Product 81", 878m },
                    { 80, "Description for product 80", "Product 80", 956m },
                    { 79, "Description for product 79", "Product 79", 651m },
                    { 78, "Description for product 78", "Product 78", 876m },
                    { 77, "Description for product 77", "Product 77", 989m },
                    { 75, "Description for product 75", "Product 75", 315m },
                    { 98, "Description for product 98", "Product 98", 908m },
                    { 50, "Description for product 50", "Product 50", 864m },
                    { 48, "Description for product 48", "Product 48", 813m },
                    { 22, "Description for product 22", "Product 22", 405m },
                    { 21, "Description for product 21", "Product 21", 620m },
                    { 20, "Description for product 20", "Product 20", 524m },
                    { 19, "Description for product 19", "Product 19", 155m },
                    { 18, "Description for product 18", "Product 18", 357m },
                    { 17, "Description for product 17", "Product 17", 596m },
                    { 16, "Description for product 16", "Product 16", 195m },
                    { 15, "Description for product 15", "Product 15", 648m },
                    { 14, "Description for product 14", "Product 14", 966m },
                    { 13, "Description for product 13", "Product 13", 821m },
                    { 12, "Description for product 12", "Product 12", 304m },
                    { 11, "Description for product 11", "Product 11", 492m },
                    { 10, "Description for product 10", "Product 10", 320m },
                    { 9, "Description for product 9", "Product 9", 494m },
                    { 8, "Description for product 8", "Product 8", 745m },
                    { 7, "Description for product 7", "Product 7", 459m },
                    { 6, "Description for product 6", "Product 6", 662m },
                    { 5, "Description for product 5", "Product 5", 238m },
                    { 4, "Description for product 4", "Product 4", 304m },
                    { 3, "Description for product 3", "Product 3", 687m },
                    { 2, "Description for product 2", "Product 2", 975m },
                    { 23, "Description for product 23", "Product 23", 112m },
                    { 49, "Description for product 49", "Product 49", 129m },
                    { 24, "Description for product 24", "Product 24", 721m },
                    { 26, "Description for product 26", "Product 26", 412m },
                    { 47, "Description for product 47", "Product 47", 533m },
                    { 46, "Description for product 46", "Product 46", 808m },
                    { 45, "Description for product 45", "Product 45", 170m },
                    { 44, "Description for product 44", "Product 44", 236m },
                    { 43, "Description for product 43", "Product 43", 416m },
                    { 42, "Description for product 42", "Product 42", 959m },
                    { 41, "Description for product 41", "Product 41", 308m },
                    { 40, "Description for product 40", "Product 40", 885m },
                    { 39, "Description for product 39", "Product 39", 782m },
                    { 38, "Description for product 38", "Product 38", 782m },
                    { 37, "Description for product 37", "Product 37", 127m },
                    { 36, "Description for product 36", "Product 36", 411m },
                    { 35, "Description for product 35", "Product 35", 679m },
                    { 34, "Description for product 34", "Product 34", 676m },
                    { 33, "Description for product 33", "Product 33", 569m },
                    { 32, "Description for product 32", "Product 32", 227m },
                    { 31, "Description for product 31", "Product 31", 804m },
                    { 30, "Description for product 30", "Product 30", 986m },
                    { 29, "Description for product 29", "Product 29", 501m },
                    { 28, "Description for product 28", "Product 28", 919m },
                    { 27, "Description for product 27", "Product 27", 680m },
                    { 25, "Description for product 25", "Product 25", 764m },
                    { 99, "Description for product 99", "Product 99", 719m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 11 },
                    { 72, 72, 16 },
                    { 71, 71, 18 },
                    { 70, 70, 9 },
                    { 69, 69, 6 },
                    { 68, 68, 16 },
                    { 67, 67, 17 },
                    { 66, 66, 15 },
                    { 65, 65, 11 },
                    { 64, 64, 19 },
                    { 63, 63, 3 },
                    { 62, 62, 9 },
                    { 61, 61, 18 },
                    { 60, 60, 5 },
                    { 59, 59, 2 },
                    { 58, 58, 3 },
                    { 57, 57, 19 },
                    { 56, 56, 1 },
                    { 55, 55, 0 },
                    { 54, 54, 13 },
                    { 53, 53, 9 },
                    { 52, 52, 3 },
                    { 73, 73, 2 },
                    { 51, 51, 4 },
                    { 74, 74, 6 },
                    { 76, 76, 17 },
                    { 97, 97, 5 },
                    { 96, 96, 14 },
                    { 95, 95, 16 },
                    { 94, 94, 3 },
                    { 93, 93, 13 },
                    { 92, 92, 19 },
                    { 91, 91, 3 },
                    { 90, 90, 6 },
                    { 89, 89, 10 },
                    { 88, 88, 7 },
                    { 87, 87, 2 },
                    { 86, 86, 4 },
                    { 85, 85, 4 },
                    { 84, 84, 1 },
                    { 83, 83, 10 },
                    { 82, 82, 17 },
                    { 81, 81, 13 },
                    { 80, 80, 19 },
                    { 79, 79, 10 },
                    { 78, 78, 5 },
                    { 77, 77, 4 },
                    { 75, 75, 0 },
                    { 98, 98, 5 },
                    { 50, 50, 4 },
                    { 48, 48, 0 },
                    { 22, 22, 9 },
                    { 21, 21, 6 },
                    { 20, 20, 4 },
                    { 19, 19, 1 },
                    { 18, 18, 11 },
                    { 17, 17, 12 },
                    { 16, 16, 1 },
                    { 15, 15, 12 },
                    { 14, 14, 14 },
                    { 13, 13, 6 },
                    { 12, 12, 18 },
                    { 11, 11, 7 },
                    { 10, 10, 19 },
                    { 9, 9, 7 },
                    { 8, 8, 9 },
                    { 7, 7, 3 },
                    { 6, 6, 15 },
                    { 5, 5, 17 },
                    { 4, 4, 3 },
                    { 3, 3, 16 },
                    { 2, 2, 3 },
                    { 23, 23, 4 },
                    { 49, 49, 3 },
                    { 24, 24, 13 },
                    { 26, 26, 12 },
                    { 47, 47, 19 },
                    { 46, 46, 0 },
                    { 45, 45, 2 },
                    { 44, 44, 18 },
                    { 43, 43, 5 },
                    { 42, 42, 9 },
                    { 41, 41, 3 },
                    { 40, 40, 15 },
                    { 39, 39, 9 },
                    { 38, 38, 16 },
                    { 37, 37, 3 },
                    { 36, 36, 2 },
                    { 35, 35, 8 },
                    { 34, 34, 10 },
                    { 33, 33, 0 },
                    { 32, 32, 11 },
                    { 31, 31, 7 },
                    { 30, 30, 8 },
                    { 29, 29, 5 },
                    { 28, 28, 14 },
                    { 27, 27, 17 },
                    { 25, 25, 0 },
                    { 99, 99, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
