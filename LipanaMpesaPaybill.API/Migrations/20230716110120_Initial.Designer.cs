﻿// <auto-generated />
using LipanaMpesaPaybill.API.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LipanaMpesaPaybill.API.Migrations
{
    [DbContext(typeof(PaybillDbContext))]
    [Migration("20230716110120_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LipanaMpesaPaybill.API.Core.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("BillRefNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessShortCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MSISDN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgAccountBalance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPartyTransID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TransTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TransID")
                        .IsUnique()
                        .HasFilter("[TransID] IS NOT NULL");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}