using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suits_Rental.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AvailableCounter = table.Column<int>(type: "int", nullable: false),
                    RentalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentDays = table.Column<int>(type: "int", nullable: false),
                    ItemsCount = table.Column<int>(type: "int", nullable: false),
                    BetAttachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RemainAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Suit_Attachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suit_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suit_Attachments_Suits_SuitId",
                        column: x => x.SuitId,
                        principalTable: "Suits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "SuitOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuitId = table.Column<int>(type: "int", nullable: true),
                    SuitSize = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuitOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuitOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuitOrders_Suits_SuitId",
                        column: x => x.SuitId,
                        principalTable: "Suits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Attachment_Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false),
                    AvailableStatus = table.Column<int>(type: "int", nullable: false),
                    AttachmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_Sizes_Suit_Attachments_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Suit_Attachments",
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
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    SuitSizeId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuitBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuitBooks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_SuitBooks_SuitSizes_SuitSizeId",
                        column: x => x.SuitSizeId,
                        principalTable: "SuitSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderAttachmentSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuitBookId = table.Column<int>(type: "int", nullable: false),
                    AttachmentSizeId = table.Column<int>(type: "int", nullable: true),
                    Suit_AttachmentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAttachmentSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderAttachmentSizes_Attachment_Sizes_AttachmentSizeId",
                        column: x => x.AttachmentSizeId,
                        principalTable: "Attachment_Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderAttachmentSizes_SuitBooks_SuitBookId",
                        column: x => x.SuitBookId,
                        principalTable: "SuitBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderAttachmentSizes_Suit_Attachments_Suit_AttachmentsId",
                        column: x => x.Suit_AttachmentsId,
                        principalTable: "Suit_Attachments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_Sizes_AttachmentId",
                table: "Attachment_Sizes",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttachmentSizes_AttachmentSizeId",
                table: "OrderAttachmentSizes",
                column: "AttachmentSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttachmentSizes_Suit_AttachmentsId",
                table: "OrderAttachmentSizes",
                column: "Suit_AttachmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttachmentSizes_SuitBookId",
                table: "OrderAttachmentSizes",
                column: "SuitBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Suit_Attachments_SuitId",
                table: "Suit_Attachments",
                column: "SuitId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitBooks_OrderId",
                table: "SuitBooks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitBooks_SuitSizeId",
                table: "SuitBooks",
                column: "SuitSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitOrders_OrderId",
                table: "SuitOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitOrders_SuitId",
                table: "SuitOrders",
                column: "SuitId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitSizes_SuitId",
                table: "SuitSizes",
                column: "SuitId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderAttachmentSizes");

            migrationBuilder.DropTable(
                name: "SuitOrders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Attachment_Sizes");

            migrationBuilder.DropTable(
                name: "SuitBooks");

            migrationBuilder.DropTable(
                name: "Suit_Attachments");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SuitSizes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suits");
        }
    }
}
