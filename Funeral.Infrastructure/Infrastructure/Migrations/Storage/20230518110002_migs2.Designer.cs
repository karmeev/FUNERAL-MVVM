﻿// <auto-generated />
using Infrastructure.Context.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations.Storage
{
    [DbContext(typeof(StorageContext))]
    [Migration("20230518110002_migs2")]
    partial class migs2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3");

            modelBuilder.Entity("Infrastructure.Model.Storage.StorageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Infrastructure.Model.Storage.StorageItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Procent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShopNameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ZakupPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ShopNameId");

                    b.ToTable("StorageItems");
                });

            modelBuilder.Entity("Infrastructure.Model.Storage.StorageItemEntity", b =>
                {
                    b.HasOne("Infrastructure.Model.Storage.StorageEntity", "ShopName")
                        .WithMany()
                        .HasForeignKey("ShopNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShopName");
                });
#pragma warning restore 612, 618
        }
    }
}
