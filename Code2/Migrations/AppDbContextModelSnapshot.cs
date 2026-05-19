using System;

using Code2.Data;

using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Infrastructure;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Code2.Migrations

{

    [DbContext(typeof(AppDbContext))]

    partial class AppDbContextModelSnapshot : ModelSnapshot

    {

        protected override void BuildModel(ModelBuilder modelBuilder)

        {

#pragma warning disable 612, 618

            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Code2.Models.TodoItem", b =>

                {

                    b.Property<int>("Id")

                        .ValueGeneratedOnAdd()

                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")

                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")

                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")

                        .IsRequired()

                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                });

#pragma warning restore 612, 618

        }

    }

}

