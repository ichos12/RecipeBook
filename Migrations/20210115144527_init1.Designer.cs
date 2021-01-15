﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBook.Models;

namespace RecipeBook.Migrations
{
    [DbContext(typeof(RecipeBookContext))]
    [Migration("20210115144527_init1")]
    partial class init1
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

                    b.HasData(
                        new
                        {
                            FeedbackId = 1,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                            Rating = 3,
                            RecipeId = 3,
                            UserId = 1
                        },
                        new
                        {
                            FeedbackId = 2,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                            Rating = 1,
                            RecipeId = 1,
                            UserId = 3
                        },
                        new
                        {
                            FeedbackId = 3,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                            Rating = 3,
                            RecipeId = 1,
                            UserId = 3
                        },
                        new
                        {
                            FeedbackId = 4,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                            Rating = 0,
                            RecipeId = 4,
                            UserId = 2
                        });
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

                    b.Property<int>("RecipeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                            RecipeRating = 3,
                            RecipeTypeId = 1,
                            Title = "First Dish",
                            UserId = 1
                        },
                        new
                        {
                            RecipeId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                            RecipeRating = 5,
                            RecipeTypeId = 2,
                            Title = "Second Dish",
                            UserId = 1
                        },
                        new
                        {
                            RecipeId = 3,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                            RecipeRating = 1,
                            RecipeTypeId = 2,
                            Title = "Second Dish",
                            UserId = 2
                        },
                        new
                        {
                            RecipeId = 4,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                            RecipeRating = 0,
                            RecipeTypeId = 3,
                            Title = "Dessert",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("RecipeBook.Models.RecipeType", b =>
                {
                    b.Property<int>("RecipeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int?>("RecipeId1")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("RecipeTypeId");

                    b.HasIndex("RecipeId1");

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

                    b.HasData(
                        new
                        {
                            TypeId = 1,
                            Title = "First Dish"
                        },
                        new
                        {
                            TypeId = 2,
                            Title = "Second Dish"
                        },
                        new
                        {
                            TypeId = 3,
                            Title = "Dessert"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "admin@mail.ru",
                            PasswordHash = "qwerty",
                            Type = 1,
                            Username = "admin"
                        },
                        new
                        {
                            UserId = 2,
                            Country = "Russia",
                            Email = "mail@mail.ru",
                            PasswordHash = "12345",
                            Type = 0,
                            Username = "mail"
                        },
                        new
                        {
                            UserId = 3,
                            Country = "US",
                            Email = "fail@mail.ru",
                            PasswordHash = "12345678",
                            Type = 1,
                            Username = "fail"
                        });
                });

            modelBuilder.Entity("RecipeBook.Models.Feedback", b =>
                {
                    b.HasOne("RecipeBook.Models.Recipe", "Recipe")
                        .WithMany("Feedbacks")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RecipeBook.Models.User", "Author")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBook.Models.Recipe", b =>
                {
                    b.HasOne("RecipeBook.Models.Type", "Type")
                        .WithMany("Recipes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RecipeBook.Models.User", "Author")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("RecipeBook.Models.RecipeType", b =>
                {
                    b.HasOne("RecipeBook.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId1")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RecipeBook.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("RecipeBook.Models.Recipe", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("RecipeBook.Models.Type", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("RecipeBook.Models.User", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
