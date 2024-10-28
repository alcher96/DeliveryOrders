using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterToDelivery.Migrations
{
    /// <inheritdoc />
    public partial class SecondInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderWeight = table.Column<int>(type: "INTEGER", nullable: false),
                    CityDistrict = table.Column<string>(type: "TEXT", nullable: false),
                    DeliveryTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CityDistrict", "DeliveryTime", "OrderWeight" },
                values: new object[,]
                {
                    { new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de111"), "Северный", new DateTime(2024, 11, 22, 17, 38, 12, 0, DateTimeKind.Unspecified), 12 },
                    { new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de112"), "Восточный", new DateTime(2024, 11, 23, 17, 38, 12, 0, DateTimeKind.Unspecified), 12 },
                    { new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de113"), "Центральный", new DateTime(2024, 11, 24, 17, 38, 12, 0, DateTimeKind.Unspecified), 12 },
                    { new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de114"), "Центральный", new DateTime(2024, 11, 25, 17, 38, 12, 0, DateTimeKind.Unspecified), 12 },
                    { new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de115"), "Центральный", new DateTime(2024, 11, 26, 17, 38, 12, 0, DateTimeKind.Unspecified), 12 },
                    { new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de704"), "Центральный", new DateTime(2024, 10, 22, 17, 38, 12, 0, DateTimeKind.Unspecified), 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
