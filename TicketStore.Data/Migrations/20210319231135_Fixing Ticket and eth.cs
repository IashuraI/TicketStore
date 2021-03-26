using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketStore.Data.Migrations
{
    public partial class FixingTicketandeth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountOfTickets",
                table: "TicketsInfos");

            migrationBuilder.DropColumn(
                name: "AvailabilityStatus",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "AmountOfTickets",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountOfTickets",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "AmountOfTickets",
                table: "TicketsInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AvailabilityStatus",
                table: "Tickets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
