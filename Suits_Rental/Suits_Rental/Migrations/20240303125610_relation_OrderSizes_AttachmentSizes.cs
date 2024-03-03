using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suits_Rental.Migrations
{
    /// <inheritdoc />
    public partial class relation_OrderSizes_AttachmentSizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderAttachmentSizes_Attachment_Sizes_AttachmentSizeId",
                table: "OrderAttachmentSizes");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderAttachmentSizes_Attachment_Sizes_AttachmentSizeId",
                table: "OrderAttachmentSizes",
                column: "AttachmentSizeId",
                principalTable: "Attachment_Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderAttachmentSizes_Attachment_Sizes_AttachmentSizeId",
                table: "OrderAttachmentSizes");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderAttachmentSizes_Attachment_Sizes_AttachmentSizeId",
                table: "OrderAttachmentSizes",
                column: "AttachmentSizeId",
                principalTable: "Attachment_Sizes",
                principalColumn: "Id");
        }
    }
}
