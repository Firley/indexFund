using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndexFund.Common.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Benchmark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiskLevel = table.Column<int>(type: "int", nullable: false),
                    FirstMinimalPayment = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    MinimalPayment = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    ManagementFee = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    HandlingFee = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    InternalCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExternalCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayoutCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FundStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funds_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Polish stocks" },
                    { 2, "Foreign stocks" },
                    { 3, "Polish bonds" },
                    { 4, "Foreign bonds" },
                    { 5, "Mixed funds" },
                    { 6, "Commodities" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Normal" },
                    { 2, "Moderator" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "Benchmark", "CategoryId", "ExternalCurrency", "FirstMinimalPayment", "FundStartDate", "HandlingFee", "InternalCurrency", "IsActive", "ManagementFee", "MinimalPayment", "Name", "PayoutCurrency", "RiskLevel", "ShortName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Vanguard S&P 500 ETF", 2, "USD", 500m, new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8691), 1m, "PLN", true, 0.5m, 100m, "Index Fund S&P500 Vanguard QQQ USD", "PLN", 3, "S&P500 Vanguard QQQ USD", 100m },
                    { 2, "SSPDR S&P 500 ETF Trust", 2, "USD", 100m, new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8749), 1m, "PLN", true, 0.7m, 100m, "Index Fund SSPDR S&P 500 ETF Trust", "PLN", 3, "SSPDR S&P 500 ETF Trust", 200m },
                    { 3, "iShares Core S&P 500 ETF USD", 2, "USD", 100m, new DateTime(2022, 5, 20, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8754), 1m, "PLN", true, 0.55m, 100m, "Index Fund iShares Core S&P 500 ETF", "PLN", 5, "iShares Core S&P 500 ETF", 100m },
                    { 4, "iShares Core S&P 500 ETF USD", 2, "USD", 500m, new DateTime(2023, 1, 5, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8758), 1m, "PLN", true, 0.75m, 50m, "Index Fund iShares Core S&P 500 ETF QQQ USD", "PLN", 5, "iShares Core S&P 500 ETF QQQ", 100m },
                    { 5, "Vanguard S&P 500 ETF (VOO)", 2, "PLN", 100m, new DateTime(2023, 1, 5, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8762), 1m, "PLN", false, 1m, 100m, "Index Fund Vanguard S&P 500 ETF (VOO)", "PLN", 2, "S&P 500 ETF (VOO)", 100m },
                    { 6, "iShares U.S. Treasury Bond ETF", 4, "USD", 500m, new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8767), 0.1m, "USD", false, 0.2m, 100m, "Index Fund U.S. Treasury Bond EF", "USD", 1, "U.S. Treasury Bond", 100m },
                    { 7, "iShares World Treasury Bond ETF", 4, "USD", 500m, new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8771), 0.15m, "USD", false, 0.2m, 100m, "Index Fund World Treasury Bond ETF", "USD", 1, "World Treasury Bond", 100m },
                    { 8, "iShares Europe Treasury Bond ETF", 4, "EUR", 500m, new DateTime(2020, 12, 29, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8776), 0.15m, "PLN", false, 0.2m, 100m, "Index Fund Europe Treasury Bond ETF", "EUR", 1, "Europe Treasury Bond", 100m },
                    { 9, "iShares UE Treasury Bond ETF", 4, "USD", 500m, new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8779), 0.10m, "USD", false, 0.2m, 100m, "Index Fund UE Treasury Bond ETF", "USD", 1, "UE Treasury Bond", 100m },
                    { 10, "iShares Corporate Treasury Bond ETF", 4, "USD", 500m, new DateTime(2022, 4, 13, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8784), 0.10m, "USD", false, 0.2m, 100m, "Index Fund UE Corporate Bond ETF", "USD", 2, "UECorporate Bond", 100m },
                    { 11, "Schwab U.S. Dividend Equity ETF", 2, "PLN", 500m, new DateTime(2021, 5, 25, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8788), 0.5m, "PLN", false, 0.5m, 100m, "Index Fund Schwab U.S. Dividend Equity ETF", "PLN", 1, "Dividend Equity ETF", 100m },
                    { 12, "Optimum Yield Diversified Commodity Strategy", 6, "PLN", 500m, new DateTime(2023, 3, 7, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8791), 1m, "PLN", false, 1m, 100m, "Index Fund Invesco Optimum Yield Diversified Commodity Strategy", "PLN", 4, "Optimum Yield Diversified Commodity Strategy", 100m },
                    { 13, "SPDR SWIG100 ETF Trust", 1, "PLN", 100m, new DateTime(2021, 11, 1, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8796), 1m, "PLN", false, 1m, 100m, "Index Fund SPDR SWIG100 ETF Trust", "PLN", 1, "SPDR SWIG100", 100m },
                    { 14, "Schwab POL Dividend Equity", 1, "PLN", 100m, new DateTime(2021, 4, 15, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8799), 1m, "PLN", false, 1m, 100m, "Index Fund Schwab POL Dividend Equity", "PLN", 1, "Schwab POL Dividend Equity", 100m },
                    { 15, "iShares Treasury Polish bond", 3, "PLN", 100m, new DateTime(2021, 11, 1, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8802), 1m, "PLN", false, 1m, 100m, "Index Fund Treasury Polish bond", "PLN", 1, "Treasury Polish bond", 100m },
                    { 16, "iShares Mixed funds", 5, "PLN", 100m, new DateTime(2022, 5, 20, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8806), 1m, "PLN", false, 1m, 100m, "Index Fund Mixed funds Total Return", "PLN", 1, "iShares Mixed funds TR", 100m },
                    { 17, "iShares", 1, "PLN", 100m, new DateTime(2021, 8, 23, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8809), 1m, "PLN", false, 1m, 100m, "Index Fund Polish stocks Test", "PLN", 1, "Polish stocks iShares", 100m },
                    { 18, "iShares World Commodities", 6, "PLN", 100m, new DateTime(2022, 6, 19, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8814), 1m, "PLN", false, 1m, 100m, "Index Fund World Commodities", "PLN", 1, "World Commodities", 100m },
                    { 19, "Vanguard S&P 500 ETF0", 1, "USD", 500m, new DateTime(2020, 7, 20, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8846), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 0", "PLN", 3, "Index Polish stocks 0", 100m },
                    { 20, "Vanguard S&P 500 ETF1", 1, "USD", 500m, new DateTime(2020, 7, 21, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8879), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 1", "PLN", 3, "Index Polish stocks 1", 100m },
                    { 21, "Vanguard S&P 500 ETF2", 1, "USD", 500m, new DateTime(2020, 7, 22, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8884), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 2", "PLN", 3, "Index Polish stocks 2", 100m },
                    { 22, "Vanguard S&P 500 ETF3", 1, "USD", 500m, new DateTime(2020, 7, 23, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8889), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 3", "PLN", 3, "Index Polish stocks 3", 100m },
                    { 23, "Vanguard S&P 500 ETF4", 1, "USD", 500m, new DateTime(2020, 7, 24, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8894), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 4", "PLN", 3, "Index Polish stocks 4", 100m },
                    { 24, "Vanguard S&P 500 ETF5", 1, "USD", 500m, new DateTime(2020, 7, 25, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8899), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 5", "PLN", 3, "Index Polish stocks 5", 100m },
                    { 25, "Vanguard S&P 500 ETF6", 1, "USD", 500m, new DateTime(2020, 7, 26, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8905), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 6", "PLN", 3, "Index Polish stocks 6", 100m },
                    { 26, "Vanguard S&P 500 ETF7", 1, "USD", 500m, new DateTime(2020, 7, 27, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8910), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 7", "PLN", 3, "Index Polish stocks 7", 100m },
                    { 27, "Vanguard S&P 500 ETF8", 1, "USD", 500m, new DateTime(2020, 7, 28, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8915), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 8", "PLN", 3, "Index Polish stocks 8", 100m },
                    { 28, "Vanguard S&P 500 ETF9", 1, "USD", 500m, new DateTime(2020, 7, 29, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8921), 1m, "PLN", true, 0.5m, 100m, "Index Fund Polish stocks 9", "PLN", 3, "Index Polish stocks 9", 100m },
                    { 29, "Foreign bonds ETF0", 5, "PLN", 100m, new DateTime(2022, 4, 30, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8931), 1m, "PLN", true, 0.25m, 100m, "Index Fund Mixed funds 0", "PLN", 2, "Index Mixed funds 0", 100m },
                    { 30, "Foreign bonds ETF1", 5, "PLN", 100m, new DateTime(2022, 5, 1, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8937), 1m, "PLN", true, 0.25m, 100m, "Index Fund Mixed funds 1", "PLN", 2, "Index Mixed funds 1", 100m },
                    { 31, "Foreign bonds ETF2", 5, "PLN", 100m, new DateTime(2022, 5, 2, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8943), 1m, "PLN", true, 0.25m, 100m, "Index Fund Mixed funds 2", "PLN", 2, "Index Mixed funds 2", 100m },
                    { 32, "Foreign bonds ETF3", 5, "PLN", 100m, new DateTime(2022, 5, 3, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8949), 1m, "PLN", true, 0.25m, 100m, "Index Fund Mixed funds 3", "PLN", 2, "Index Mixed funds 3", 100m },
                    { 33, "Foreign bonds ETF4", 5, "PLN", 100m, new DateTime(2022, 5, 4, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8955), 1m, "PLN", true, 0.25m, 100m, "Index Fund Mixed funds 4", "PLN", 2, "Index Mixed funds 4", 100m },
                    { 34, "Foreign bonds ETF0", 4, "PLN", 100m, new DateTime(2021, 3, 26, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8967), 1m, "PLN", true, 0.1m, 100m, "Index Fund Foreign bonds 0", "PLN", 2, "Index Foreign bonds 0", 100m },
                    { 35, "Foreign bonds ETF1", 4, "PLN", 100m, new DateTime(2021, 3, 25, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8974), 1m, "PLN", true, 0.1m, 100m, "Index Fund Foreign bonds 1", "PLN", 2, "Index Foreign bonds 1", 100m },
                    { 36, "Foreign bonds ETF2", 4, "PLN", 100m, new DateTime(2021, 3, 24, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8981), 1m, "PLN", true, 0.1m, 100m, "Index Fund Foreign bonds 2", "PLN", 2, "Index Foreign bonds 2", 100m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funds_CategoryId",
                table: "Funds",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funds");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
