﻿// <auto-generated />
using System;
using Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infra.Migrations
{
    [DbContext(typeof(RmContext))]
    [Migration("20220602135047_Create missing tables")]
    partial class Createmissingtables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BudgetParts", b =>
                {
                    b.Property<int>("BudgetsId")
                        .HasColumnType("integer");

                    b.Property<int>("PartsId")
                        .HasColumnType("integer");

                    b.HasKey("BudgetsId", "PartsId");

                    b.HasIndex("PartsId");

                    b.ToTable("BudgetParts");
                });

            modelBuilder.Entity("Domain.Entities.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool?>("Authorized")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("BudgetDelivered")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("BudgetDeliveryDeadline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("Finalized")
                        .HasColumnType("boolean");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("RepairBy")
                        .HasColumnType("integer");

                    b.Property<decimal?>("TotalValue")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("RepairBy");

                    b.ToTable("Budget");
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PeopleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PeopleId")
                        .IsUnique();

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("SupplierId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Domain.Entities.Parts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Name")
                        .HasColumnType("integer");

                    b.Property<int>("SupplierId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("Domain.Entities.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Domain.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("Domain.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cnpj")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("Domain.Entities.Technician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset?>("FiredIn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("HiredIn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PeopleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PeopleId")
                        .IsUnique();

                    b.ToTable("Technician");
                });

            modelBuilder.Entity("OrderParts", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<int>("PartsId")
                        .HasColumnType("integer");

                    b.HasKey("OrdersId", "PartsId");

                    b.HasIndex("PartsId");

                    b.ToTable("OrderParts");
                });

            modelBuilder.Entity("BudgetParts", b =>
                {
                    b.HasOne("Domain.Entities.Budget", null)
                        .WithMany()
                        .HasForeignKey("BudgetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Parts", null)
                        .WithMany()
                        .HasForeignKey("PartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Budget", b =>
                {
                    b.HasOne("Domain.Entities.Client", "Client")
                        .WithMany("Budgets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Technician", "TechnicianWhoCreated")
                        .WithMany("Budgets")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ProductType", "ProductType")
                        .WithMany("Budgets")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Technician", "TechnicianWhoRepair")
                        .WithMany("Repairs")
                        .HasForeignKey("RepairBy");

                    b.Navigation("Client");

                    b.Navigation("ProductType");

                    b.Navigation("TechnicianWhoCreated");

                    b.Navigation("TechnicianWhoRepair");
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.HasOne("Domain.Entities.People", "People")
                        .WithOne("Client")
                        .HasForeignKey("Domain.Entities.Client", "PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("People");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.HasOne("Domain.Entities.Supplier", "Supplier")
                        .WithMany("Orders")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Domain.Entities.Parts", b =>
                {
                    b.HasOne("Domain.Entities.Supplier", "Supplier")
                        .WithMany("Parts")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Domain.Entities.Technician", b =>
                {
                    b.HasOne("Domain.Entities.People", "People")
                        .WithOne("Technician")
                        .HasForeignKey("Domain.Entities.Technician", "PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("People");
                });

            modelBuilder.Entity("OrderParts", b =>
                {
                    b.HasOne("Domain.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Parts", null)
                        .WithMany()
                        .HasForeignKey("PartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.Navigation("Budgets");
                });

            modelBuilder.Entity("Domain.Entities.People", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Technician");
                });

            modelBuilder.Entity("Domain.Entities.ProductType", b =>
                {
                    b.Navigation("Budgets");
                });

            modelBuilder.Entity("Domain.Entities.Supplier", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Parts");
                });

            modelBuilder.Entity("Domain.Entities.Technician", b =>
                {
                    b.Navigation("Budgets");

                    b.Navigation("Repairs");
                });
#pragma warning restore 612, 618
        }
    }
}
