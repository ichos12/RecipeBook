﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Type
    {
        public int TypeId { get; set; }
        public string Title { get; set; }

        public List<Recipe> Recipes { get; set; }
        public Type()
        {
            Recipes = new List<Recipe>();
        }
    }
}
