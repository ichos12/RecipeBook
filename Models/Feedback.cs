using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
