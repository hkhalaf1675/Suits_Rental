using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suits_Rental.Migrations
{
    /// <inheritdoc />
    public partial class addSuitBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderAttachmentSizes_SuitOrders_SuitOrderId",
                table: "OrderAttachmentSizes");

            migrationBuilder.DropColumn(
                name: "ReservedSizes",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size1",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size2",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size3",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size4",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size5",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size6",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size7",
                table: "Suits");

            migrationBuilder.DropColumn(
                name: "Size8",
                table: "Suits");

            migrationBuilder.RenameColumn(
                name: "SuitOrderId",
                table: "OrderAttachmentSizes",
                newName: "SuitBookId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderAttachmentSizes_SuitOrderId",
                table: "OrderAttachmentSizes",
                newName: "IX_OrderAttachmentSizes_SuitBookId");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RentDays",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RemainAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PaidAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemsCount",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AvailableStatus",
                table: "Attachment_Sizes",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateTable(
                name: "SuitSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false),
                    AvailableStatus = table.Column<int>(type: "int", nullable: false),
                    SuitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuitSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuitSizes_Suits_SuitId",
                        column: x => x.SuitId,
                        principalTable: "Suits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuitBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuitSizeId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuitBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuitBooks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuitBooks_SuitSizes_SuitSizeId",
                        column: x => x.SuitSizeId,
                        principalTable: "SuitSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuitBooks_OrderId",
                table: "SuitBooks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitBooks_SuitSizeId",
                table: "SuitBooks",
                column: "SuitSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitSizes_SuitId",
                table: "SuitSizes",
                column: "SuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderAttachmentSizes_SuitBooks_SuitBookId",
                table: "OrderAttachmentSizes",
                column: "SuitBookId",
                principalTable: "SuitBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderAttachmentSizes_SuitBooks_SuitBookId",
                table: "OrderAttachmentSizes");

            migrationBuilder.DropTable(
                name: "SuitBooks");

            migrationBuilder.DropTable(
                name: "SuitSizes");

            migrationBuilder.RenameColumn(
                name: "SuitBookId",
                table: "OrderAttachmentSizes",
                newName: "SuitOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderAttachmentSizes_SuitBookId",
                table: "OrderAttachmentSizes",
                newName: "IX_OrderAttachmentSizes_SuitOrderId");

            migrationBuilder.AddColumn<string>(
                name: "ReservedSizes",
                table: "Suits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size1",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size2",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size3",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size4",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size5",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size6",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size7",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size8",
                table: "Suits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "RentDays",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "RemainAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PaidAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "ItemsCount",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "AvailableStatus",
                table: "Attachment_Sizes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderAttachmentSizes_SuitOrders_SuitOrderId",
                table: "OrderAttachmentSizes",
                column: "SuitOrderId",
                principalTable: "SuitOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
