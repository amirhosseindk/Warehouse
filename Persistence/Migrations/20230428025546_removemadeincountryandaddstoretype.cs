using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class removemadeincountryandaddstoretype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTurnovers_Countries_MadeinCountryCountryID",
                table: "InventoryTurnovers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "MadeinCountries",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "StoreTypeID",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_StoreTypeID",
                table: "Stores",
                column: "StoreTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTurnovers_MadeinCountries_MadeinCountryCountryID",
                table: "InventoryTurnovers",
                column: "MadeinCountryCountryID",
                principalTable: "MadeinCountries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_StoreTypes_StoreTypeID",
                table: "Stores",
                column: "StoreTypeID",
                principalTable: "StoreTypes",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTurnovers_MadeinCountries_MadeinCountryCountryID",
                table: "InventoryTurnovers");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_StoreTypes_StoreTypeID",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_StoreTypeID",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "StoreTypeID",
                table: "Stores");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MadeinCountries",
                newName: "CountryName");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTurnovers_Countries_MadeinCountryCountryID",
                table: "InventoryTurnovers",
                column: "MadeinCountryCountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
