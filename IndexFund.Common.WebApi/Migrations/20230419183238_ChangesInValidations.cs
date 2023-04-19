using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndexFund.Common.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Funds",
                type: "decimal(7,3)",
                precision: 7,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "MinimalPayment",
                table: "Funds",
                type: "decimal(7,3)",
                precision: 7,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "ManagementFee",
                table: "Funds",
                type: "decimal(7,3)",
                precision: 7,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "HandlingFee",
                table: "Funds",
                type: "decimal(7,3)",
                precision: 7,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "FirstMinimalPayment",
                table: "Funds",
                type: "decimal(7,3)",
                precision: 7,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 1,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 20, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 2,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 20, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 3,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 24, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 4,
                column: "FundStartDate",
                value: new DateTime(2023, 1, 9, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 5,
                column: "FundStartDate",
                value: new DateTime(2023, 1, 9, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 6,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 20, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 7,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 20, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 8,
                column: "FundStartDate",
                value: new DateTime(2021, 1, 2, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 9,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 20, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 10,
                column: "FundStartDate",
                value: new DateTime(2022, 4, 17, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 11,
                column: "FundStartDate",
                value: new DateTime(2021, 5, 29, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 12,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 11, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 13,
                column: "FundStartDate",
                value: new DateTime(2021, 11, 5, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 14,
                column: "FundStartDate",
                value: new DateTime(2021, 4, 19, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 15,
                column: "FundStartDate",
                value: new DateTime(2021, 11, 5, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 16,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 24, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 17,
                column: "FundStartDate",
                value: new DateTime(2021, 8, 27, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 18,
                column: "FundStartDate",
                value: new DateTime(2022, 6, 23, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 19,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 24, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 20,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 25, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 21,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 26, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 22,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 27, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 23,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 28, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 24,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 29, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 25,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 30, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 26,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 31, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 27,
                column: "FundStartDate",
                value: new DateTime(2020, 8, 1, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 28,
                column: "FundStartDate",
                value: new DateTime(2020, 8, 2, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 29,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 4, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 30,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 5, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 31,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 6, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 32,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 7, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 33,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 8, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 34,
                column: "FundStartDate",
                value: new DateTime(2021, 3, 30, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 35,
                column: "FundStartDate",
                value: new DateTime(2021, 3, 29, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 36,
                column: "FundStartDate",
                value: new DateTime(2021, 3, 28, 20, 32, 38, 64, DateTimeKind.Local).AddTicks(9008));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Funds",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,3)",
                oldPrecision: 7,
                oldScale: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "MinimalPayment",
                table: "Funds",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,3)",
                oldPrecision: 7,
                oldScale: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "ManagementFee",
                table: "Funds",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,3)",
                oldPrecision: 7,
                oldScale: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "HandlingFee",
                table: "Funds",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,3)",
                oldPrecision: 7,
                oldScale: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "FirstMinimalPayment",
                table: "Funds",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,3)",
                oldPrecision: 7,
                oldScale: 3);

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 1,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 2,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 3,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 20, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 4,
                column: "FundStartDate",
                value: new DateTime(2023, 1, 5, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 5,
                column: "FundStartDate",
                value: new DateTime(2023, 1, 5, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 6,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 7,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 8,
                column: "FundStartDate",
                value: new DateTime(2020, 12, 29, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 9,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 16, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 10,
                column: "FundStartDate",
                value: new DateTime(2022, 4, 13, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 11,
                column: "FundStartDate",
                value: new DateTime(2021, 5, 25, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 12,
                column: "FundStartDate",
                value: new DateTime(2023, 3, 7, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 13,
                column: "FundStartDate",
                value: new DateTime(2021, 11, 1, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 14,
                column: "FundStartDate",
                value: new DateTime(2021, 4, 15, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 15,
                column: "FundStartDate",
                value: new DateTime(2021, 11, 1, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 16,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 20, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 17,
                column: "FundStartDate",
                value: new DateTime(2021, 8, 23, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 18,
                column: "FundStartDate",
                value: new DateTime(2022, 6, 19, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 19,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 20, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 20,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 21, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 21,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 22, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 22,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 23, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 23,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 24, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 24,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 25, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 25,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 26, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 26,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 27, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 27,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 28, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 28,
                column: "FundStartDate",
                value: new DateTime(2020, 7, 29, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 29,
                column: "FundStartDate",
                value: new DateTime(2022, 4, 30, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 30,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 1, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 31,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 2, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 32,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 3, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 33,
                column: "FundStartDate",
                value: new DateTime(2022, 5, 4, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 34,
                column: "FundStartDate",
                value: new DateTime(2021, 3, 26, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 35,
                column: "FundStartDate",
                value: new DateTime(2021, 3, 25, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: 36,
                column: "FundStartDate",
                value: new DateTime(2021, 3, 24, 18, 10, 6, 777, DateTimeKind.Local).AddTicks(8981));
        }
    }
}
