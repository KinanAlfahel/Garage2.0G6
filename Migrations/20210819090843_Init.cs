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
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                values: new object[] { 1, new DateTime(2021, 8, 19, 11, 8, 42, 564, DateTimeKind.Local).AddTicks(4041), "Volvo", "red", "X3", "123ABC", "A", 4 });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Arrivaldate", "Brand", "Color", "Model", "Regnum", "Type", "Wheel" },
                values: new object[] { 2, new DateTime(2021, 8, 19, 11, 8, 42, 567, DateTimeKind.Local).AddTicks(9474), "Volvo", "red", "X3", "125ABC", "A", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
