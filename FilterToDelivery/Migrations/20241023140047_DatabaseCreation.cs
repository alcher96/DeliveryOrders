using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterToDelivery.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oreders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomerIpAddress = table.Column<string>(type: "TEXT", nullable: false),
                    OrderWeight = table.Column<int>(type: "INTEGER", nullable: false),
                    CityDistrict = table.Column<string>(type: "TEXT", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeliveryTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oreders", x => x.OrderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oreders");
        }
    }
}
