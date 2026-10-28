using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class AjouterIsDisponibleZombieType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDisponible",
                table: "ZombieTypes",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "isDisponible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "isDisponible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "isDisponible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "isDisponible",
                value: true);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "isDisponible",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDisponible",
                table: "ZombieTypes");
        }
    }
}
