﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBook.Models;

namespace RecipeBook.Migrations
{
    [DbContext(typeof(RecipeBookContext))]
    [Migration("20210115095330_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("RecipeBook.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FeedbackId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("RecipeBook.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipeRating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipeBook.Models.RecipeType", b =>
                {
                    b.Property<int>("RecipeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("RecipeTypeId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("TypeId");

                    b.ToTable("RecipeTypes");
                });

            modelBuilder.Entity("RecipeBook.Models.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("RecipeBook.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RecipeBook.Models.Feedback", b =>
                {
                    b.HasOne("RecipeBook.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RecipeBook.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBook.Models.Recipe", b =>
                {
                    b.HasOne("RecipeBook.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("RecipeBook.Models.RecipeType", b =>
                {
                    b.HasOne("RecipeBook.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RecipeBook.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
