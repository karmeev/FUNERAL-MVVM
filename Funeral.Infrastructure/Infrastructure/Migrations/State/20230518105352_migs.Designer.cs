﻿// <auto-generated />
using System;
using Infrastructure.Context.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations.State
{
    [DbContext(typeof(StateContext))]
    [Migration("20230518105352_migs")]
    partial class migs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3");

            modelBuilder.Entity("Domain.Complect.ItemComplectEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Money")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Procent")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StateEntityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StateEntityId");

                    b.ToTable("ItemComplectEntity");
                });

            modelBuilder.Entity("Domain.Order.Config.ClientOrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cemetry")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateCreation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateToday")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DeliveryPlace")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telegram")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ThirdName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ClientOrderEntity");
                });

            modelBuilder.Entity("Domain.Order.Config.FlowershedEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NoInstal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FlowershedEntity");
                });

            modelBuilder.Entity("Domain.Order.Config.FuneralBaseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryFuneral")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Looks")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModelFuneral")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rock")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FuneralBaseEntity");
                });

            modelBuilder.Entity("Domain.Order.Config.FuneralEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DownPart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Epitafia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Other")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UpPart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FuneralEntity");
                });

            modelBuilder.Entity("Domain.Order.Config.InstalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Idicate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InstalPrice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("InstalEntity");
                });

            modelBuilder.Entity("Domain.Order.Config.StandEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StandEntity");
                });

            modelBuilder.Entity("Domain.Order.DeadModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Death")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Life")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrderEntityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ThirdName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderEntityId");

                    b.ToTable("DeadModel");
                });

            modelBuilder.Entity("Domain.Order.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientOrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeadassCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FlowershedId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FuneralId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Polishing")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Prepayment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Remainder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StelaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BaseId");

                    b.HasIndex("ClientOrderId");

                    b.HasIndex("FlowershedId");

                    b.HasIndex("FuneralId");

                    b.HasIndex("InstalId");

                    b.HasIndex("StandId");

                    b.HasIndex("StelaId");

                    b.ToTable("OrderEntity");
                });

            modelBuilder.Entity("Domain.Order.Stela.StelaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StelaEntity");
                });

            modelBuilder.Entity("Domain.Services.Entity.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Money")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("StateEntityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StateEntityId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Infrastructure.Model.ComplexMongo.StateEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("Domain.Complect.ItemComplectEntity", b =>
                {
                    b.HasOne("Infrastructure.Model.ComplexMongo.StateEntity", null)
                        .WithMany("Complect")
                        .HasForeignKey("StateEntityId");
                });

            modelBuilder.Entity("Domain.Order.DeadModel", b =>
                {
                    b.HasOne("Domain.Order.OrderEntity", null)
                        .WithMany("Deadass")
                        .HasForeignKey("OrderEntityId");
                });

            modelBuilder.Entity("Domain.Order.OrderEntity", b =>
                {
                    b.HasOne("Domain.Order.Config.FuneralBaseEntity", "Base")
                        .WithMany()
                        .HasForeignKey("BaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Order.Config.ClientOrderEntity", "ClientOrder")
                        .WithMany()
                        .HasForeignKey("ClientOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Order.Config.FlowershedEntity", "Flowershed")
                        .WithMany()
                        .HasForeignKey("FlowershedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Order.Config.FuneralEntity", "Funeral")
                        .WithMany()
                        .HasForeignKey("FuneralId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Order.Config.InstalEntity", "Instal")
                        .WithMany()
                        .HasForeignKey("InstalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Order.Config.StandEntity", "Stand")
                        .WithMany()
                        .HasForeignKey("StandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Order.Stela.StelaEntity", "Stela")
                        .WithMany()
                        .HasForeignKey("StelaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Base");

                    b.Navigation("ClientOrder");

                    b.Navigation("Flowershed");

                    b.Navigation("Funeral");

                    b.Navigation("Instal");

                    b.Navigation("Stand");

                    b.Navigation("Stela");
                });

            modelBuilder.Entity("Domain.Services.Entity.Service", b =>
                {
                    b.HasOne("Infrastructure.Model.ComplexMongo.StateEntity", null)
                        .WithMany("Services")
                        .HasForeignKey("StateEntityId");
                });

            modelBuilder.Entity("Infrastructure.Model.ComplexMongo.StateEntity", b =>
                {
                    b.HasOne("Domain.Order.OrderEntity", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Domain.Order.OrderEntity", b =>
                {
                    b.Navigation("Deadass");
                });

            modelBuilder.Entity("Infrastructure.Model.ComplexMongo.StateEntity", b =>
                {
                    b.Navigation("Complect");

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}