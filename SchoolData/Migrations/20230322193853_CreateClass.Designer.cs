﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolData.Data;

#nullable disable

namespace SchoolData.Migrations
{
    [DbContext(typeof(SchoolDataContext))]
    [Migration("20230322193853_CreateClass")]
    partial class CreateClass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("SchoolData.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Classe")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specializzazione")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Class");
                });
#pragma warning restore 612, 618
        }
    }
}