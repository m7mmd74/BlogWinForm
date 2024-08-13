﻿// <auto-generated />
using System;
using BlogCodeFirstEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogCodeFirstEF.Migrations
{
    [DbContext(typeof(ITIDbcontext))]
    partial class ITIDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlogCodeFirstEF.Models.Author", b =>
                {
                    b.Property<int>("auth_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("auth_id"), 1L, 1);

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<bool>("auth_isBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("auth_id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BlogCodeFirstEF.Models.Blog", b =>
                {
                    b.Property<int>("b_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("b_id"), 1L, 1);

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("o_Id")
                        .HasColumnType("int");

                    b.HasKey("b_id");

                    b.HasIndex("o_Id")
                        .IsUnique();

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BlogCodeFirstEF.Models.Owner", b =>
                {
                    b.Property<int>("o_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("o_id"), 1L, 1);

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("o_id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("BlogCodeFirstEF.Models.Post", b =>
                {
                    b.Property<int>("p_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("p_id"), 1L, 1);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int?>("author_id")
                        .HasColumnType("int");

                    b.Property<int>("authorauth_id")
                        .HasColumnType("int");

                    b.Property<string>("brief")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("p_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("p_media")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("p_id");

                    b.HasIndex("BlogId");

                    b.HasIndex("authorauth_id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BlogCodeFirstEF.Models.Blog", b =>
                {
                    b.HasOne("BlogCodeFirstEF.Models.Owner", "owner")
                        .WithOne("blog")
                        .HasForeignKey("BlogCodeFirstEF.Models.Blog", "o_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");
                });

            modelBuilder.Entity("BlogCodeFirstEF.Models.Post", b =>
                {
                    b.HasOne("BlogCodeFirstEF.Models.Blog", "blog")
                        .WithMany("posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogCodeFirstEF.Models.Author", "author")
                        .WithMany("Posts")
                        .HasForeignKey("authorauth_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("blog");
                });

            modelBuilder.Entity("BlogCodeFirstEF.Models.Author", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("BlogCodeFirstEF.Models.Blog", b =>
                {
                    b.Navigation("posts");
                });

            modelBuilder.Entity("BlogCodeFirstEF.Models.Owner", b =>
                {
                    b.Navigation("blog")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
