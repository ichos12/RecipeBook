using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class RecipeType
    {
        public int RecipeTypeId { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
