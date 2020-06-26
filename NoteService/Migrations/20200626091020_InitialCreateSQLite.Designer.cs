﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteService.Data;

namespace NoteService.Migrations
{
    [DbContext(typeof(NoteServiceContext))]
    [Migration("20200626091020_InitialCreateSQLite")]
    partial class InitialCreateSQLite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("NoteService.Models.Note", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<string>("Head")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
