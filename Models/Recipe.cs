using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RecipeRating { get; set; }
        public string RecipeImageURL { get; set; }

        public int UserId { get; set; }
        public User Author { get; set; }
    }
}
