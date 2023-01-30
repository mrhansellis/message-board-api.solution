﻿// <auto-generated />
using System;
using MessageBoardApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MessageBoardApi.Migrations
{
    [DbContext(typeof(MessageBoardApiContext))]
    [Migration("20230129233257_AddInital")]
    partial class AddInital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Group")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}