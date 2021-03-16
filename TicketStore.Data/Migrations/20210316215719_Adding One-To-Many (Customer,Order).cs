using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketStore.Data.Migrations
{
    public partial class AddingOneToManyCustomerOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Orders_OrdersId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_OrdersId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Tickets");

            migrationBuilder.CreateTable(
                name: "OrderTicket",
                columns: table => new
                {
                    OrdersOrderId = table.Column<int>(type: "int", nullable: false),
                    TicketsTicketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTicket", x => new { x.OrdersOrderId, x.TicketsTicketId });
                    table.ForeignKey(
                        name: "FK_OrderTicket_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderTicket_Tickets_TicketsTicketId",
                        column: x => x.TicketsTicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderTicket_TicketsTicketId",
                table: "OrderTicket",
                column: "TicketsTicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderTicket");

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OrdersId",
                table: "Tickets",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Orders_OrdersId",
                table: "Tickets",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
