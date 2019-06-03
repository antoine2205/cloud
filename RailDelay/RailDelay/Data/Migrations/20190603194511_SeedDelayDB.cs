using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RailDelay.Data.Migrations
{
    public partial class SeedDelayDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TicketName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Delay",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TravelDate = table.Column<DateTime>(nullable: false),
                    TicketID = table.Column<int>(nullable: false),
                    TicketNumber = table.Column<string>(maxLength: 13, nullable: true),
                    LastDateOfUse = table.Column<DateTime>(nullable: false),
                    DepartureTrainStationID = table.Column<string>(nullable: true),
                    DestinationTrainStationID = table.Column<string>(nullable: true),
                    TransferTrainStationID = table.Column<string>(nullable: true),
                    PlannedDepartureTime = table.Column<DateTime>(nullable: false),
                    PlannedArrivalTime = table.Column<DateTime>(nullable: false),
                    PlannedTrain1Number = table.Column<string>(maxLength: 4, nullable: true),
                    PlannedTrain2Number = table.Column<string>(maxLength: 4, nullable: true),
                    ActualDepartureTime = table.Column<DateTime>(nullable: false),
                    ActualArrivalTime = table.Column<DateTime>(nullable: false),
                    ActualTrain1Number = table.Column<string>(maxLength: 4, nullable: true),
                    ActualTrain2Number = table.Column<string>(maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delay", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Delay_Ticket_TicketID",
                        column: x => x.TicketID,
                        principalTable: "Ticket",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "TicketName" },
                values: new object[,]
                {
                    { 1, "Biljet" },
                    { 2, "Treinkaart" },
                    { 3, "Campus" },
                    { 4, "Halftijdse Treinkaart" },
                    { 5, "Pass" },
                    { 6, "Kaart" },
                    { 7, "MOBIB Kaart" }
                });

            migrationBuilder.InsertData(
                table: "Delay",
                columns: new[] { "ID", "ActualArrivalTime", "ActualDepartureTime", "ActualTrain1Number", "ActualTrain2Number", "DepartureTrainStationID", "DestinationTrainStationID", "LastDateOfUse", "PlannedArrivalTime", "PlannedDepartureTime", "PlannedTrain1Number", "PlannedTrain2Number", "TicketID", "TicketNumber", "TransferTrainStationID", "TravelDate" },
                values: new object[] { 1, new DateTime(2019, 4, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), "6543", "", "", "", new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), "1234", "", 1, "", "", new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Delay",
                columns: new[] { "ID", "ActualArrivalTime", "ActualDepartureTime", "ActualTrain1Number", "ActualTrain2Number", "DepartureTrainStationID", "DestinationTrainStationID", "LastDateOfUse", "PlannedArrivalTime", "PlannedDepartureTime", "PlannedTrain1Number", "PlannedTrain2Number", "TicketID", "TicketNumber", "TransferTrainStationID", "TravelDate" },
                values: new object[] { 2, new DateTime(2019, 5, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), "6543", "", "", "", new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), "1234", "", 1, "", "", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Delay_TicketID",
                table: "Delay",
                column: "TicketID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delay");

            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
