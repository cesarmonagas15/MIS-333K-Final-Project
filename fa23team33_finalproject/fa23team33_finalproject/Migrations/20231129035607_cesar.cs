using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa23team33_finalproject.Migrations
{
    /// <inheritdoc />
    public partial class cesar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_Transactions_TransactionsTransactionID",
                table: "TransactionDetails");

            migrationBuilder.RenameColumn(
                name: "TransactionsTransactionID",
                table: "TransactionDetails",
                newName: "TransactionID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionDetails_TransactionsTransactionID",
                table: "TransactionDetails",
                newName: "IX_TransactionDetails_TransactionID");

            migrationBuilder.AlterColumn<bool>(
                name: "TuesdayDiscount",
                table: "TransactionDetails",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "SeniorDiscount",
                table: "TransactionDetails",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "TransactionDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Movie",
                table: "TransactionDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PopcornPoints",
                table: "TransactionDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Theater",
                table: "TransactionDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TicketPrice",
                table: "TransactionDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_Transactions_TransactionID",
                table: "TransactionDetails",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_Transactions_TransactionID",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "Movie",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "PopcornPoints",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "Theater",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "TransactionDetails");

            migrationBuilder.RenameColumn(
                name: "TransactionID",
                table: "TransactionDetails",
                newName: "TransactionsTransactionID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionDetails_TransactionID",
                table: "TransactionDetails",
                newName: "IX_TransactionDetails_TransactionsTransactionID");

            migrationBuilder.AlterColumn<bool>(
                name: "TuesdayDiscount",
                table: "TransactionDetails",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SeniorDiscount",
                table: "TransactionDetails",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_Transactions_TransactionsTransactionID",
                table: "TransactionDetails",
                column: "TransactionsTransactionID",
                principalTable: "Transactions",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
