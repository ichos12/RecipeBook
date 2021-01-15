﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int Type { get; set; }
        public string Country { get; set; }

        public List<Feedback> Feedbacks { get; set; }
        public User()
        {
            Feedbacks = new List<Feedback>();
            Recipes = new List<Recipe>();
        }
        public List<Recipe> Recipes { get; set; }
    }
}
