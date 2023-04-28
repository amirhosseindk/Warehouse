using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class makingchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTurnovers_MadeinCountries_MadeinCountryCountryID",
                table: "InventoryTurnovers");

            migrationBuilder.DropIndex(
                name: "IX_InventoryTurnovers_MadeinCountryCountryID",
                table: "InventoryTurnovers");

            migrationBuilder.RenameColumn(
                name: "MadeinCountryCountryID",
                table: "InventoryTurnovers",
                newName: "RemindeStock");

            migrationBuilder.AddColumn<int>(
                name: "ConsumerID",
                table: "InventoryTurnovers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocTypeID",
                table: "InventoryTurnovers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AgentName",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MadeinCountryCountryID",
                table: "Commodities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DocType",
                columns: table => new
                {
                    DocTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocType", x => x.DocTypeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTurnovers_ConsumerID",
                table: "InventoryTurnovers",
                column: "ConsumerID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTurnovers_DocTypeID",
                table: "InventoryTurnovers",
                column: "DocTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_MadeinCountryCountryID",
                table: "Commodities",
                column: "MadeinCountryCountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodities_MadeinCountries_MadeinCountryCountryID",
                table: "Commodities",
                column: "MadeinCountryCountryID",
                principalTable: "MadeinCountries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTurnovers_Consumers_ConsumerID",
                table: "InventoryTurnovers",
                column: "ConsumerID",
                principalTable: "Consumers",
                principalColumn: "ConsumerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTurnovers_DocType_DocTypeID",
                table: "InventoryTurnovers",
                column: "DocTypeID",
                principalTable: "DocType",
                principalColumn: "DocTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commodities_MadeinCountries_MadeinCountryCountryID",
                table: "Commodities");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTurnovers_Consumers_ConsumerID",
                table: "InventoryTurnovers");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTurnovers_DocType_DocTypeID",
                table: "InventoryTurnovers");

            migrationBuilder.DropTable(
                name: "DocType");

            migrationBuilder.DropIndex(
                name: "IX_InventoryTurnovers_ConsumerID",
                table: "InventoryTurnovers");

            migrationBuilder.DropIndex(
                name: "IX_InventoryTurnovers_DocTypeID",
                table: "InventoryTurnovers");

            migrationBuilder.DropIndex(
                name: "IX_Commodities_MadeinCountryCountryID",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "ConsumerID",
                table: "InventoryTurnovers");

            migrationBuilder.DropColumn(
                name: "DocTypeID",
                table: "InventoryTurnovers");

            migrationBuilder.DropColumn(
                name: "AgentName",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "MadeinCountryCountryID",
                table: "Commodities");

            migrationBuilder.RenameColumn(
                name: "RemindeStock",
                table: "InventoryTurnovers",
                newName: "MadeinCountryCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTurnovers_MadeinCountryCountryID",
                table: "InventoryTurnovers",
                column: "MadeinCountryCountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTurnovers_MadeinCountries_MadeinCountryCountryID",
                table: "InventoryTurnovers",
                column: "MadeinCountryCountryID",
                principalTable: "MadeinCountries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
