using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecipeBook.Models
{
    public class RecipeBookContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<RecipeType> RecipeTypes { get; set; }
        public DbSet<Type> Types { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            string adminEmail = "admin@mail.ru";
            string adminPassword = "qwerty";

            User adminUser = new User { UserId = 1, Email = adminEmail, PasswordHash = adminPassword, Type = 1, Username = "admin" };
            User user1 = new User
            {
                UserId = 2,
                Email = "mail@mail.ru",
                PasswordHash = "12345",
                Username = "mail",
                Type = 0,
                Country = "Russia"
            };
            User user2 = new User
            {
                UserId = 3,
                Email = "fail@mail.ru",
                PasswordHash = "12345678",
                Username = "fail",
                Type = 1,
                Country = "US"
            };
            Type type1 = new Type
            {
                TypeId = 1,
                Title = "First Dish"
            };
            Type type2 = new Type
            {
                TypeId = 2,
                Title = "Second Dish"
            };
            Type type3 = new Type
            {
                TypeId = 3,
                Title = "Dessert"
            };
            Recipe recipe1 = new Recipe
            {
                RecipeId = 1,
                Title = "First Dish",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                RecipeRating = 3,
                RecipeTypeId = 1,
                UserId = 1
            };
            Recipe recipe2 = new Recipe
            {
                RecipeId = 2,
                Title = "Second Dish",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                RecipeRating = 5,
                RecipeTypeId = 2,
                UserId = 1
            };
            Recipe recipe3 = new Recipe
            {
                RecipeId = 3,
                Title = "Second Dish",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                RecipeRating = 1,
                RecipeTypeId = 2,
                UserId = 2
            };
            Recipe recipe4 = new Recipe
            {
                RecipeId = 4,
                Title = "Dessert",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                RecipeRating = 0,
                RecipeTypeId = 3,
                UserId = 2
            };
            Feedback feed1 = new Feedback
            {
                FeedbackId = 1,
                Rating = 3,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                UserId = 1,
                RecipeId = 3
            };
            Feedback feed2 = new Feedback
            {
                FeedbackId = 2,
                Rating = 1,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                UserId = 3,
                RecipeId = 1
            };
            Feedback feed3 = new Feedback
            {
                FeedbackId = 3,
                Rating = 3,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                UserId = 3,
                RecipeId = 1
            };
            Feedback feed4 = new Feedback
            {
                FeedbackId = 4,
                Rating = 0,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                UserId = 2,
                RecipeId = 4
            };
            modelbuilder.Entity<User>().HasData(new User[] { adminUser, user1, user2 });
            modelbuilder.Entity<Type>().HasData(new Type[] { type1, type2, type3 });
            modelbuilder.Entity<Recipe>().HasData(new Recipe[] { recipe1, recipe2, recipe3, recipe4 });
            modelbuilder.Entity<Feedback>().HasData(new Feedback[] { feed1, feed2, feed3, feed4 });
            base.OnModelCreating(modelbuilder);
        }
        public RecipeBookContext(DbContextOptions<RecipeBookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
