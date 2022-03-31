﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tiger_Tix.Web.Services;

namespace Tiger_Tix.Web.Migrations
{
    [DbContext(typeof(LoginService))]
    [Migration("20220329180957_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tiger_Tix.Web.Models.EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RemainingTickets")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserViewModelId")
                        .HasColumnType("int");

                    b.Property<int?>("UserViewModelId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserViewModelId");

                    b.HasIndex("UserViewModelId1");

                    b.ToTable("EventModel");
                });

            modelBuilder.Entity("Tiger_Tix.Web.Models.UserViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passhash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Tiger_Tix.Web.Models.EventModel", b =>
                {
                    b.HasOne("Tiger_Tix.Web.Models.UserViewModel", null)
                        .WithMany("AvailableEvents")
                        .HasForeignKey("UserViewModelId");

                    b.HasOne("Tiger_Tix.Web.Models.UserViewModel", null)
                        .WithMany("BoughtEvents")
                        .HasForeignKey("UserViewModelId1");
                });

            modelBuilder.Entity("Tiger_Tix.Web.Models.UserViewModel", b =>
                {
                    b.Navigation("AvailableEvents");

                    b.Navigation("BoughtEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
