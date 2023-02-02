﻿// <auto-generated />
using System;
using EmmaProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmmaProject.Data.EmmaMigrations
{
    [DbContext(typeof(EmmaProjectContext))]
    partial class EmmaProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.13");

            modelBuilder.Entity("EmmaProject.Models.Customer", b =>
                {
                    b.Property<int>("CustID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("CustCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("CustFirst")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("CustLast")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("CustPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("CustPostal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustProvince")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.HasKey("CustID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EmmaProject.Models.EmpLogin", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmpID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SignIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SignOut")
                        .HasColumnType("TEXT");

                    b.HasKey("LogID");

                    b.HasIndex("EmpID");

                    b.ToTable("EmpLogins");
                });

            modelBuilder.Entity("EmmaProject.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmpFirst")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("EmpLast")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("EmpPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmpUserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmpID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmmaProject.Models.EmployeePosition", b =>
                {
                    b.Property<int>("EmpID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PosID")
                        .HasColumnType("TEXT");

                    b.HasKey("EmpID", "PosID");

                    b.HasIndex("PosID");

                    b.ToTable("EmployeePositions");
                });

            modelBuilder.Entity("EmmaProject.Models.Inventory", b =>
                {
                    b.Property<string>("UPC_ID")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("InvAdjustedPrice")
                        .HasColumnType("TEXT");

                    b.Property<char>("InvCurrent")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("InvMarkupPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("InvQuantity")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("InvSize")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UPC_ID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("EmmaProject.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Appreciation")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("EmpID")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("InvoiceDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("InvoiceSubtotal")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceID");

                    b.HasIndex("EmpID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("EmmaProject.Models.InvoiceLine", b =>
                {
                    b.Property<int>("InvoiceID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UPC_ID")
                        .HasColumnType("TEXT");

                    b.Property<int>("OtQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("OtSalePrice")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceID", "UPC_ID");

                    b.HasIndex("InvoiceID")
                        .IsUnique();

                    b.HasIndex("UPC_ID")
                        .IsUnique();

                    b.ToTable("InvoiceLines");
                });

            modelBuilder.Entity("EmmaProject.Models.InvoicePayment", b =>
                {
                    b.Property<int>("InvoiceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("InvoiceID", "PaymentID");

                    b.HasIndex("PaymentID");

                    b.ToTable("InvoicePayments");
                });

            modelBuilder.Entity("EmmaProject.Models.OrderRequest", b =>
                {
                    b.Property<int>("OrderRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExternalOrderNum")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("OReqReceiveData")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("OReqSendData")
                        .HasColumnType("TEXT");

                    b.Property<string>("ORequestDesc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("OrderRequestID");

                    b.HasIndex("CustID");

                    b.ToTable("OrderRequests");
                });

            modelBuilder.Entity("EmmaProject.Models.OrderRequestInventory", b =>
                {
                    b.Property<int>("OrderRequestID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UPC_ID")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderRequestID", "UPC_ID");

                    b.HasIndex("UPC_ID");

                    b.ToTable("OrderRequestInventories");
                });

            modelBuilder.Entity("EmmaProject.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OtherDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("PaymentID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("EmmaProject.Models.Position", b =>
                {
                    b.Property<string>("PosTitle")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PosID")
                        .HasColumnType("INTEGER");

                    b.HasKey("PosTitle");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("EmmaProject.Models.Price", b =>
                {
                    b.Property<int>("PriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriceCount")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PricePurchasedCost")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("PricePurchasedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SupID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UPC_ID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PriceID");

                    b.HasIndex("SupID");

                    b.HasIndex("UPC_ID");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("EmmaProject.Models.Supplier", b =>
                {
                    b.Property<int>("SupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SupAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SupCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("SupEmail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("SupName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("SupPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("SupPostal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SupProvince")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.HasKey("SupID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("EmmaProject.Models.EmpLogin", b =>
                {
                    b.HasOne("EmmaProject.Models.Employee", "Employee")
                        .WithMany("EmpLogins")
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmmaProject.Models.EmployeePosition", b =>
                {
                    b.HasOne("EmmaProject.Models.Employee", "Employee")
                        .WithMany("EmployeePositions")
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmmaProject.Models.Position", "Position")
                        .WithMany("EmployeePositions")
                        .HasForeignKey("PosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("EmmaProject.Models.Invoice", b =>
                {
                    b.HasOne("EmmaProject.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmmaProject.Models.Employee", "Employee")
                        .WithMany("Invoices")
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmmaProject.Models.InvoiceLine", b =>
                {
                    b.HasOne("EmmaProject.Models.Invoice", "Invoice")
                        .WithOne("InvoiceLine")
                        .HasForeignKey("EmmaProject.Models.InvoiceLine", "InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmmaProject.Models.Inventory", "Inventory")
                        .WithOne("InvoiceLine")
                        .HasForeignKey("EmmaProject.Models.InvoiceLine", "UPC_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("EmmaProject.Models.InvoicePayment", b =>
                {
                    b.HasOne("EmmaProject.Models.Invoice", "Invoice")
                        .WithMany("InvoicePayments")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmmaProject.Models.Payment", "Payment")
                        .WithMany("InvoicePayments")
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("EmmaProject.Models.OrderRequest", b =>
                {
                    b.HasOne("EmmaProject.Models.Customer", "Customer")
                        .WithMany("OrderRequests")
                        .HasForeignKey("CustID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EmmaProject.Models.OrderRequestInventory", b =>
                {
                    b.HasOne("EmmaProject.Models.OrderRequest", "OrderRequest")
                        .WithMany("OrderRequestInventories")
                        .HasForeignKey("OrderRequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmmaProject.Models.Inventory", "Inventory")
                        .WithMany("OrderRequestInventories")
                        .HasForeignKey("UPC_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("OrderRequest");
                });

            modelBuilder.Entity("EmmaProject.Models.Price", b =>
                {
                    b.HasOne("EmmaProject.Models.Supplier", "Supplier")
                        .WithMany("Prices")
                        .HasForeignKey("SupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmmaProject.Models.Inventory", "Inventory")
                        .WithMany("Prices")
                        .HasForeignKey("UPC_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("EmmaProject.Models.Customer", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("OrderRequests");
                });

            modelBuilder.Entity("EmmaProject.Models.Employee", b =>
                {
                    b.Navigation("EmpLogins");

                    b.Navigation("EmployeePositions");

                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("EmmaProject.Models.Inventory", b =>
                {
                    b.Navigation("InvoiceLine");

                    b.Navigation("OrderRequestInventories");

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("EmmaProject.Models.Invoice", b =>
                {
                    b.Navigation("InvoiceLine");

                    b.Navigation("InvoicePayments");
                });

            modelBuilder.Entity("EmmaProject.Models.OrderRequest", b =>
                {
                    b.Navigation("OrderRequestInventories");
                });

            modelBuilder.Entity("EmmaProject.Models.Payment", b =>
                {
                    b.Navigation("InvoicePayments");
                });

            modelBuilder.Entity("EmmaProject.Models.Position", b =>
                {
                    b.Navigation("EmployeePositions");
                });

            modelBuilder.Entity("EmmaProject.Models.Supplier", b =>
                {
                    b.Navigation("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}
