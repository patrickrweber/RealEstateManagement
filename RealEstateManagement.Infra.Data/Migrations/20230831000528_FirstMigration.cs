using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoomsNumber = table.Column<int>(type: "int", nullable: false),
                    BathRoomsNumber = table.Column<int>(type: "int", nullable: false),
                    HaveLaundry = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HaveGarage = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ZipCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    District = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AdressNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RentValue = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WaterBill = table.Column<double>(type: "double", nullable: false),
                    EnergyBill = table.Column<double>(type: "double", nullable: false),
                    TotalValue = table.Column<double>(type: "double", nullable: false),
                    WattsSpent = table.Column<double>(type: "double", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    HouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdentificationCard = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "House",
                columns: new[] { "Id", "Address", "AdressNumber", "BathRoomsNumber", "City", "Country", "District", "HaveGarage", "HaveLaundry", "RentValue", "RoomsNumber", "State", "ZipCode" },
                values: new object[] { 1, "Leopoldo Haerchen", "658", 1, "Blumenau", "Brasil", "Badenfurt", true, true, 650.0, 2, "Santa Catarina", "89072040" });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "Id", "EnergyBill", "HouseId", "Month", "PaidDate", "TotalValue", "WaterBill", "WattsSpent", "Year" },
                values: new object[] { 1, 150.0, 1, 8, new DateTime(2023, 8, 30, 21, 5, 28, 185, DateTimeKind.Local).AddTicks(4844), 850.0, 50.0, 1000.0, 2023 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "Email", "HouseId", "IdentificationCard", "Name", "PhoneNumber" },
                values: new object[] { 1, 21, "patrick@gmail.com", 1, "06262485902", "Patrick", "47989098585" });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_HouseId",
                table: "Bill",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_HouseId",
                table: "Person",
                column: "HouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "House");
        }
    }
}
