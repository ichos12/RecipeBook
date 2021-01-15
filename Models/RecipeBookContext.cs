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
        public RecipeBookContext(DbContextOptions<RecipeBookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
