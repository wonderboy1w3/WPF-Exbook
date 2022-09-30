﻿// <auto-generated />
using System;
using ExamProject.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExamProject.Data.Migrations
{
    [DbContext(typeof(ExamProjectContext))]
    partial class ExamProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExamProject.Domain.Entities.Attachment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Attachements");
                });

            modelBuilder.Entity("ExamProject.Domain.Entities.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Faculty")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<long?>("ImageId")
                        .HasColumnType("bigint");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<long?>("PassportId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PasspostId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("PassportId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ExamProject.Domain.Entities.Student", b =>
                {
                    b.HasOne("ExamProject.Domain.Entities.Attachment", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("ExamProject.Domain.Entities.Attachment", "Passport")
                        .WithMany()
                        .HasForeignKey("PassportId");

                    b.Navigation("Image");

                    b.Navigation("Passport");
                });
#pragma warning restore 612, 618
        }
    }
}
