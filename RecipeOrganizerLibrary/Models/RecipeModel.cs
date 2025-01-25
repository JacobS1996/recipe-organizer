using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeOrganizerLibrary.Models
{
    public class RecipeModel
    {
        public string? RecipeName { get; set; }

        public List<IngredientModel> IngredientList { get; set; } = new List<IngredientModel>();
    }
}
