﻿// <auto-generated />
using System;
using Diarymous.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Diarymous.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220225092725_mgr_2")]
    partial class mgr_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Diarymous.Models.Entities.Account", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("Diarymous.Models.Entities.Diary", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("authorid")
                        .HasColumnType("int");

                    b.Property<string>("diaryText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("publishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("authorid");

                    b.ToTable("diaries");
                });

            modelBuilder.Entity("Diarymous.Models.Entities.Diary", b =>
                {
                    b.HasOne("Diarymous.Models.Entities.Account", "author")
                        .WithMany("diaries")
                        .HasForeignKey("authorid");

                    b.Navigation("author");
                });

            modelBuilder.Entity("Diarymous.Models.Entities.Account", b =>
                {
                    b.Navigation("diaries");
                });
#pragma warning restore 612, 618
        }
    }
}
