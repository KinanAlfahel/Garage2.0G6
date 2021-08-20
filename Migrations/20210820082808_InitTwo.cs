using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garage2._0G6.Migrations
{
    public partial class InitTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Regnum",
                table: "Vehicle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 12, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 20, 10, 28, 8, 16, DateTimeKind.Local).AddTicks(6566));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Regnum",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 405, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10,
                column: "Arrivaldate",
                value: new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4389));
        }
    }
}
