﻿// <auto-generated />
using System;
using Estudos.BaltaIO.Tarefas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQL.Example.Migrations
{
  [DbContext(typeof(DataContext))]
  partial class DataContextModelSnapshot : ModelSnapshot
  {
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
        .HasAnnotation("ProductVersion", "6.0.0")
        .HasAnnotation("Relational:MaxIdentifierLength", 64);

      modelBuilder.Entity("GraphQL.Example.Domain.Entities.Note", b =>
      {
        b.Property<Guid>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("char(36)");

        b.Property<DateTime>("CreatedAt")
          .HasColumnType("datetime(6)");

        b.Property<bool>("Deleted")
          .HasColumnType("tinyint(1)");

        b.Property<DateTime?>("DeletedAt")
          .HasColumnType("datetime(6)");

        b.Property<string>("Message")
          .IsRequired()
          .HasColumnType("varchar(100)")
          .HasColumnName("message");

        b.Property<DateTime?>("UpdatedAt")
          .HasColumnType("datetime(6)");

        b.HasKey("Id");

        b.ToTable("reg_notes", (string)null);
      });
#pragma warning restore 612, 618
    }
  }
}
