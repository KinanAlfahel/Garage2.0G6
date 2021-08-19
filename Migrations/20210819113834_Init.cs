using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garage2._0G6.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Regnum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wheel = table.Column<int>(type: "int", nullable: false),
                    Arrivaldate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Arrivaldate", "Brand", "Color", "Model", "Regnum", "Type", "Wheel" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 19, 13, 38, 34, 405, DateTimeKind.Local).AddTicks(5251), "Volvo", "red", "X3", "123ABC", 3, 4 },
                    { 2, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4314), "Toyota", "red", "Corolla", "125ABC", 3, 4 },
                    { 3, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4358), "Volvo", "blue", "XC60", "226ABC", 3, 4 },
                    { 4, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4364), "Volvo", "black", "X3", "122ABC", 3, 4 },
                    { 5, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4369), "Harley Davidson", "black", "Street 750", "225ABC", 4, 2 },
                    { 6, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4373), "Yamaha", "red", "Bolt", "115ABC", 4, 2 },
                    { 7, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4377), "Volvo", "white", "Epic V8", "112ABC", 1, 0 },
                    { 8, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4381), "Toyota", "red", "Epic SX", "321ABC", 1, 0 },
                    { 9, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4385), "Volvo", "blue", "X4", "322ABC", 2, 6 },
                    { 10, new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4389), "Yamaha", "white", "Revell", "331ABC", 0, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
