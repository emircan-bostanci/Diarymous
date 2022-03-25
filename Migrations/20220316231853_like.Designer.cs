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
    [Migration("20220316231853_like")]
    partial class like
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccountDiary", b =>
                {
                    b.Property<int>("likedPostsid")
                        .HasColumnType("int");

                    b.Property<int>("likedUsersid")
                        .HasColumnType("int");

                    b.HasKey("likedPostsid", "likedUsersid");

                    b.HasIndex("likedUsersid");

                    b.ToTable("AccountDiary");
                });

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipAdrr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("bit");

                    b.Property<int>("likeCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("publishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("authorid");

                    b.ToTable("diaries");
                });

            modelBuilder.Entity("AccountDiary", b =>
                {
                    b.HasOne("Diarymous.Models.Entities.Diary", null)
                        .WithMany()
                        .HasForeignKey("likedPostsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diarymous.Models.Entities.Account", null)
                        .WithMany()
                        .HasForeignKey("likedUsersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
