﻿// <auto-generated />
using TorgObject.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TorgObject.WebService.Migrations
{
    [DbContext(typeof(TorgContext))]
    [Migration("20200515180141_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("TorgObject.DomainObjects.PechatProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Area")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Period")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacilityArea")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameOfBusinessEntity")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PechatProducts");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            District = "СЗАО",
                            Name = @"НТО ул. Авиационная, вл.68",
                            Area = "Щукино",
                            Address = "город Москва, Авиационная улица, дом 68",
                            Period = "с 1 января по 31 декабря",
                            Number = "НТО-09-02-002652",
                            FacilityArea = "9",
                            NameOfBusinessEntity = "Компания ФРЕГАТ"
                        }
                        );
                });
#pragma warning restore 612, 618
        }
    }
}
