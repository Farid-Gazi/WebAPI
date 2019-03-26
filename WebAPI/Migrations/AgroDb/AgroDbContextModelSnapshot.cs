﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.DAL;

namespace WebAPI.Migrations.AgroDb
{
    [DbContext(typeof(AgroDbContext))]
    partial class AgroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models_Table.Farmer_List", b =>
                {
                    b.Property<int>("Farmer_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Farmer_Name");

                    b.Property<string>("Phone");

                    b.HasKey("Farmer_ID");

                    b.ToTable("Farmer_List");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Imported_Product_Source", b =>
                {
                    b.Property<int>("Imported_Product_Source_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Custom_Tax");

                    b.Property<decimal>("Imported_Product_Buying_Cost");

                    b.Property<decimal>("Importers_WholeSale_Price");

                    b.Property<int>("Product_ID");

                    b.Property<decimal>("Shipment_Cost");

                    b.Property<decimal>("Storing_Cost");

                    b.Property<decimal>("Total_Cost");

                    b.Property<decimal>("Transportation_Cost");

                    b.HasKey("Imported_Product_Source_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Imported_Product_Source");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Local_Product_Source", b =>
                {
                    b.Property<int>("Local_Product_Source_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Farmer_ID");

                    b.Property<decimal>("Labour_Cost");

                    b.Property<decimal>("Ploughing_Cost");

                    b.Property<decimal>("Processing_Cost");

                    b.Property<int>("Product_ID");

                    b.Property<decimal>("Seeding_Cost");

                    b.Property<decimal>("Total_Production_Cost");

                    b.Property<decimal>("Watering_Cost");

                    b.HasKey("Local_Product_Source_ID");

                    b.HasIndex("Farmer_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Local_Product_Source");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Local_Trader_Order_Details", b =>
                {
                    b.Property<int>("Local_Trader_Order_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Local_Trader_ID");

                    b.Property<int>("Product_ID");

                    b.HasKey("Local_Trader_Order_ID");

                    b.HasIndex("Local_Trader_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Local_Trader_Order_Details");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Local_Traders_Details", b =>
                {
                    b.Property<int>("Local_Trader_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Local_Buying_Price");

                    b.Property<string>("Local_Trader_Name");

                    b.Property<decimal>("Storing_Cost");

                    b.Property<decimal>("Total_Cost");

                    b.Property<decimal>("Transportation_Cost");

                    b.HasKey("Local_Trader_ID");

                    b.ToTable("Local_Traders_Details");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Market_List", b =>
                {
                    b.Property<int>("Market_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country_Name");

                    b.Property<string>("District");

                    b.Property<string>("Market_Address");

                    b.Property<string>("Market_Name");

                    b.Property<string>("Post_Code");

                    b.HasKey("Market_ID");

                    b.ToTable("Market_List");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Product_Category", b =>
                {
                    b.Property<int>("Product_Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Product_Category_Name");

                    b.HasKey("Product_Category_ID");

                    b.ToTable("Product_Category");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Product_Unit", b =>
                {
                    b.Property<int>("Product_Unit_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Product_Unit_Quantity");

                    b.HasKey("Product_Unit_ID");

                    b.ToTable("Product_Unit");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Products", b =>
                {
                    b.Property<int>("Product_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details");

                    b.Property<int>("Market_ID");

                    b.Property<int?>("Product_Category_ID");

                    b.Property<string>("Product_Name");

                    b.Property<string>("Product_Source");

                    b.Property<int?>("Product_Unit_ID");

                    b.HasKey("Product_ID");

                    b.HasIndex("Market_ID");

                    b.HasIndex("Product_Category_ID");

                    b.HasIndex("Product_Unit_ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Retailer_Order_Details", b =>
                {
                    b.Property<int>("Retailer_Order_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Product_ID");

                    b.Property<int>("Retailer_ID");

                    b.HasKey("Retailer_Order_ID");

                    b.HasIndex("Product_ID");

                    b.HasIndex("Retailer_ID");

                    b.ToTable("Retailers_Order_Details");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Retailers_Details", b =>
                {
                    b.Property<int>("Retailer_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Retailer_Name");

                    b.Property<decimal>("Retailer_Selling_Price");

                    b.Property<decimal>("Retailers_Buying_Price");

                    b.Property<decimal>("Total_Cost_PerUnit");

                    b.Property<decimal>("Transportation_Cost");

                    b.HasKey("Retailer_ID");

                    b.ToTable("Retailers_Details");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Trader_Category", b =>
                {
                    b.Property<int>("Trader_Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Trader_Category_Name");

                    b.HasKey("Trader_Category_ID");

                    b.ToTable("Trader_Category");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Traders_List", b =>
                {
                    b.Property<int>("Trader_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Market_ID");

                    b.Property<string>("Trader_Address");

                    b.Property<int?>("Trader_Category_ID");

                    b.Property<string>("Trader_Name");

                    b.HasKey("Trader_ID");

                    b.HasIndex("Market_ID");

                    b.HasIndex("Trader_Category_ID");

                    b.ToTable("Traders_List");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Whole_Saler_Order_Details", b =>
                {
                    b.Property<int>("Order_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Product_ID");

                    b.Property<int?>("Whole_Saler_ID");

                    b.HasKey("Order_ID");

                    b.HasIndex("Product_ID");

                    b.HasIndex("Whole_Saler_ID");

                    b.ToTable("Whole_Saler_Order_Details");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Whole_Salers", b =>
                {
                    b.Property<int>("Whole_Saler_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Whole_Saler_Buying_Cost");

                    b.Property<string>("Whole_Saler_Name");

                    b.Property<decimal>("Whole_Saler_Selling_Price");

                    b.Property<decimal>("Whole_Saler_Storing_Cost");

                    b.Property<decimal>("Whole_Saler_Total_Cost");

                    b.Property<decimal>("Whole_Saler_Transportation_Cost");

                    b.HasKey("Whole_Saler_ID");

                    b.ToTable("Whole_Salers");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Imported_Product_Source", b =>
                {
                    b.HasOne("WebAPI.Models_Table.Products", "Products")
                        .WithMany()
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models_Table.Local_Product_Source", b =>
                {
                    b.HasOne("WebAPI.Models_Table.Farmer_List", "FarmerList")
                        .WithMany()
                        .HasForeignKey("Farmer_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models_Table.Products", "Products")
                        .WithMany()
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models_Table.Local_Trader_Order_Details", b =>
                {
                    b.HasOne("WebAPI.Models_Table.Local_Traders_Details", "Local_Traders_Details")
                        .WithMany()
                        .HasForeignKey("Local_Trader_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models_Table.Products", "Products")
                        .WithMany()
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models_Table.Products", b =>
                {
                    b.HasOne("WebAPI.Models_Table.Market_List", "MarketList")
                        .WithMany("Products")
                        .HasForeignKey("Market_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models_Table.Product_Category", "Product_Category")
                        .WithMany("Products")
                        .HasForeignKey("Product_Category_ID");

                    b.HasOne("WebAPI.Models_Table.Product_Unit", "Product_Unit")
                        .WithMany("Products")
                        .HasForeignKey("Product_Unit_ID");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Retailer_Order_Details", b =>
                {
                    b.HasOne("WebAPI.Models_Table.Products", "Products")
                        .WithMany()
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models_Table.Retailers_Details", "Retailers_Details")
                        .WithMany()
                        .HasForeignKey("Retailer_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models_Table.Traders_List", b =>
                {
                    b.HasOne("WebAPI.Models_Table.Market_List", "Market_List")
                        .WithMany("Traders_List")
                        .HasForeignKey("Market_ID");

                    b.HasOne("WebAPI.Models_Table.Trader_Category", "Trader_Category")
                        .WithMany("Traders_List")
                        .HasForeignKey("Trader_Category_ID");
                });

            modelBuilder.Entity("WebAPI.Models_Table.Whole_Saler_Order_Details", b =>
                {
                    b.HasOne("WebAPI.Models_Table.Products", "Products")
                        .WithMany()
                        .HasForeignKey("Product_ID");

                    b.HasOne("WebAPI.Models_Table.Whole_Salers", "Whole_Salers")
                        .WithMany()
                        .HasForeignKey("Whole_Saler_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
