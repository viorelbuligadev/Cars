using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cars.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    VIN = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "Model", "VIN", "Year" },
                values: new object[,]
                {
                    { 1, "Toyota", "Red", "Camry", "1HGBH41JXMN109186", 2020 },
                    { 2, "Ford", "Blue", "Mustang", "1HGBH41JXMN109187", 2021 },
                    { 3, "Chevrolet", "Black", "Camaro", "1HGBH41JXMN109188", 2019 },
                    { 4, "Tesla", "White", "Model S", "1HGBH41JXMN109189", 2022 },
                    { 5, "Nissan", "Grey", "Altima", "1HGBH41JXMN109190", 2018 },
                    { 6, "Honda", "Silver", "Civic", "1HGBH41JXMN109191", 2020 },
                    { 7, "BMW", "Blue", "3 Series", "1HGBH41JXMN109192", 2021 },
                    { 8, "Audi", "White", "A4", "1HGBH41JXMN109193", 2019 },
                    { 9, "Mercedes-Benz", "Black", "C-Class", "1HGBH41JXMN109194", 2022 },
                    { 10, "Volkswagen", "Red", "Golf", "1HGBH41JXMN109195", 2018 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
