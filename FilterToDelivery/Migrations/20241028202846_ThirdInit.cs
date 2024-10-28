using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterToDelivery.Migrations
{
    /// <inheritdoc />
    public partial class ThirdInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CityDistrict", "DeliveryTime", "OrderWeight" },
                values: new object[,]
                {
                    { new Guid("4978799c-f114-46a0-bf6e-21d14e5c5bff"), "Западный", new DateTime(2024, 10, 26, 17, 28, 12, 0, DateTimeKind.Unspecified), 16 },
                    { new Guid("78e03122-7e4e-44f0-ad11-5fe56a2669dd"), "Западный", new DateTime(2024, 10, 22, 17, 38, 12, 0, DateTimeKind.Unspecified), 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("4978799c-f114-46a0-bf6e-21d14e5c5bff"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("78e03122-7e4e-44f0-ad11-5fe56a2669dd"));
        }
    }
}
