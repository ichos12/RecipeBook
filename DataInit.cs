using RecipeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook
{
    public class DataInit
    {
        public static void Initialize(RecipeBookContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        UserId = 2,
                        Email = "mail@mail.ru",
                        PasswordHash = "12345".GetHashCode().ToString(),
                        Username = "mail",
                        Type = 0,
                        Country = "Russia"
                    },
                    new User
                    {
                        UserId = 3,
                        Email = "fail@mail.ru",
                        PasswordHash = "12345678".GetHashCode().ToString(),
                        Username = "fail",
                        Type = 1,
                        Country = "US"
                    }
                );
            }
            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        RecipeId = 1,
                        Title = "First Dish",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                        RecipeRating = 3,
                        RecipeTypeId = 1,
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 2,
                        Title = "Second Dish",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                        RecipeRating = 5,
                        RecipeTypeId = 2,
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 3,
                        Title = "Second Dish",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                        RecipeRating = 1,
                        RecipeTypeId = 2,
                        UserId = 2
                    },
                    new Recipe
                    {
                        RecipeId = 4,
                        Title = "Dessert",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                        RecipeRating = 0,
                        RecipeTypeId = 3,
                        UserId = 2
                    }
                );
            }
            if (!context.Types.Any())
            {
                context.Types.AddRange(
                    new Models.Type
                    {
                        TypeId = 1,
                        Title = "First Dish"
                    },
                    new Models.Type
                    {
                        TypeId = 2,
                        Title = "Second Dish"
                    },
                    new Models.Type
                    {
                        TypeId = 3,
                        Title = "Dessert"
                    }
                );
            }
            if (!context.Feedbacks.Any())
            {
                context.Feedbacks.AddRange(
                    new Feedback
                    {
                        FeedbackId = 1,
                        Rating = 3,
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                        UserId = 1,
                        RecipeId = 3
                    },
                    new Feedback
                    {
                        FeedbackId = 2,
                        Rating = 1,
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                        UserId = 3,
                        RecipeId = 1
                    },
                    new Feedback
                    {
                        FeedbackId = 3,
                        Rating = 3,
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                        UserId = 3,
                        RecipeId = 1
                    },
                    new Feedback
                    {
                        FeedbackId = 4,
                        Rating = 0,
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.",
                        UserId = 2,
                        RecipeId = 4
                    }
                );
            }
            context.SaveChanges(true);
        }
    }
}
