﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Suits_Rental.Contexts;

#nullable disable

namespace Suits_Rental.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240302093439_initialCreateDatabase")]
    partial class initialCreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Suits_Rental.Models.Attachment_Sizes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttachmentId")
                        .HasColumnType("int");

                    b.Property<bool>("AvailableStatus")
                        .HasColumnType("bit");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentId");

                    b.ToTable("Attachment_Sizes");
                });

            modelBuilder.Entity("Suits_Rental.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Suits_Rental.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BetAttachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("ItemsCount")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("RemainAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RentDays")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Suits_Rental.Models.OrderAttachmentSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AttachmentId")
                        .HasColumnType("int");

                    b.Property<int?>("AttachmentSizeId")
                        .HasColumnType("int");

                    b.Property<int>("SuitOrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentId");

                    b.HasIndex("AttachmentSizeId");

                    b.HasIndex("SuitOrderId");

                    b.ToTable("OrderAttachmentSizes");
                });

            modelBuilder.Entity("Suits_Rental.Models.Suit", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("AvailableCounter")
                        .HasColumnType("int");

                    b.Property<decimal?>("RentalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Suits");
                });

            modelBuilder.Entity("Suits_Rental.Models.SuitOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("SuitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SuitId");

                    b.ToTable("SuitOrders");
                });

            modelBuilder.Entity("Suits_Rental.Models.Suit_Attachments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AttachmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuitId");

                    b.ToTable("Suit_Attachments");
                });

            modelBuilder.Entity("Suits_Rental.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Suits_Rental.Models.Attachment_Sizes", b =>
                {
                    b.HasOne("Suits_Rental.Models.Suit_Attachments", "Attachment")
                        .WithMany("Attachment_Sizes")
                        .HasForeignKey("AttachmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attachment");
                });

            modelBuilder.Entity("Suits_Rental.Models.Order", b =>
                {
                    b.HasOne("Suits_Rental.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Suits_Rental.Models.OrderAttachmentSize", b =>
                {
                    b.HasOne("Suits_Rental.Models.Suit_Attachments", "Attachment")
                        .WithMany("OrderAttachmentSizes")
                        .HasForeignKey("AttachmentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Suits_Rental.Models.Attachment_Sizes", "Attachment_Size")
                        .WithMany("OrderAttachmentSizes")
                        .HasForeignKey("AttachmentSizeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Suits_Rental.Models.SuitOrder", "SuitOrder")
                        .WithMany("OrderAttachmentSizes")
                        .HasForeignKey("SuitOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attachment");

                    b.Navigation("Attachment_Size");

                    b.Navigation("SuitOrder");
                });

            modelBuilder.Entity("Suits_Rental.Models.SuitOrder", b =>
                {
                    b.HasOne("Suits_Rental.Models.Order", "Order")
                        .WithMany("OrderSuits")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Suits_Rental.Models.Suit", "Suit")
                        .WithMany("OrderSuits")
                        .HasForeignKey("SuitId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Order");

                    b.Navigation("Suit");
                });

            modelBuilder.Entity("Suits_Rental.Models.Suit_Attachments", b =>
                {
                    b.HasOne("Suits_Rental.Models.Suit", "Suit")
                        .WithMany("Attachments")
                        .HasForeignKey("SuitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Suit");
                });

            modelBuilder.Entity("Suits_Rental.Models.Attachment_Sizes", b =>
                {
                    b.Navigation("OrderAttachmentSizes");
                });

            modelBuilder.Entity("Suits_Rental.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Suits_Rental.Models.Order", b =>
                {
                    b.Navigation("OrderSuits");
                });

            modelBuilder.Entity("Suits_Rental.Models.Suit", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("OrderSuits");
                });

            modelBuilder.Entity("Suits_Rental.Models.SuitOrder", b =>
                {
                    b.Navigation("OrderAttachmentSizes");
                });

            modelBuilder.Entity("Suits_Rental.Models.Suit_Attachments", b =>
                {
                    b.Navigation("Attachment_Sizes");

                    b.Navigation("OrderAttachmentSizes");
                });
#pragma warning restore 612, 618
        }
    }
}