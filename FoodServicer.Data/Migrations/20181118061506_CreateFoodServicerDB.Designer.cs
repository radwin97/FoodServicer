﻿// <auto-generated />
using System;
using FoodServicer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodServicer.Data.Migrations
{
    [DbContext(typeof(FoodServicerContext))]
    [Migration("20181118061506_CreateFoodServicerDB")]
    partial class CreateFoodServicerDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FoodServicer.Data.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressTypeId");

                    b.Property<string>("City");

                    b.Property<long?>("CustomerId");

                    b.Property<string>("PostalCode");

                    b.Property<string>("State");

                    b.Property<string>("Street1");

                    b.Property<string>("Street2");

                    b.HasKey("Id");

                    b.HasIndex("AddressTypeId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.AddressType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("AddressTypes");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Conversion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("FromId");

                    b.Property<long>("ToId");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("Conversions");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Suffix");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.EmailAddress", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<long?>("CustomerId");

                    b.Property<long>("EmailAddressTypeId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmailAddressTypeId");

                    b.ToTable("EmailAddresses");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.EmailAddressType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("EmailAddressTypes");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Ingredient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Meal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ReheatInstructions");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Measurement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("EndDate");

                    b.Property<DateTime?>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.MenuItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("Cost");

                    b.Property<long>("MealId");

                    b.Property<long>("MenuId");

                    b.Property<decimal?>("Price");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ContactEmailId");

                    b.Property<long?>("ContactPhoneId");

                    b.Property<long>("CustomerId");

                    b.Property<long>("DeliveryAddressId");

                    b.Property<long>("MenuId");

                    b.Property<long>("OrderStatusId");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.HasIndex("ContactEmailId");

                    b.HasIndex("ContactPhoneId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliveryAddressId");

                    b.HasIndex("MenuId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("MenuItemId");

                    b.Property<long?>("OrderId");

                    b.Property<string>("SpecialInstructions");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.OrderStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.PhoneNumber", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CustomerId");

                    b.Property<bool>("IsPrimary");

                    b.Property<string>("Number");

                    b.Property<long>("PhoneNumberTypeId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PhoneNumberTypeId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.PhoneNumberType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("PhoneNumberTypes");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Address", b =>
                {
                    b.HasOne("FoodServicer.Data.Entities.AddressType", "Type")
                        .WithMany()
                        .HasForeignKey("AddressTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodServicer.Data.Entities.Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Conversion", b =>
                {
                    b.HasOne("FoodServicer.Data.Entities.Measurement", "From")
                        .WithMany()
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodServicer.Data.Entities.Measurement", "To")
                        .WithMany()
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.EmailAddress", b =>
                {
                    b.HasOne("FoodServicer.Data.Entities.Customer")
                        .WithMany("EmailAddresses")
                        .HasForeignKey("CustomerId");

                    b.HasOne("FoodServicer.Data.Entities.EmailAddressType", "Type")
                        .WithMany()
                        .HasForeignKey("EmailAddressTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.MenuItem", b =>
                {
                    b.HasOne("FoodServicer.Data.Entities.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodServicer.Data.Entities.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.Order", b =>
                {
                    b.HasOne("FoodServicer.Data.Entities.EmailAddress", "ContactEmail")
                        .WithMany()
                        .HasForeignKey("ContactEmailId");

                    b.HasOne("FoodServicer.Data.Entities.PhoneNumber", "ContactPhone")
                        .WithMany()
                        .HasForeignKey("ContactPhoneId");

                    b.HasOne("FoodServicer.Data.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodServicer.Data.Entities.Address", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodServicer.Data.Entities.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodServicer.Data.Entities.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.OrderItem", b =>
                {
                    b.HasOne("FoodServicer.Data.Entities.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodServicer.Data.Entities.Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("FoodServicer.Data.Entities.PhoneNumber", b =>
                {
                    b.HasOne("FoodServicer.Data.Entities.Customer")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("CustomerId");

                    b.HasOne("FoodServicer.Data.Entities.PhoneNumberType", "Type")
                        .WithMany()
                        .HasForeignKey("PhoneNumberTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
