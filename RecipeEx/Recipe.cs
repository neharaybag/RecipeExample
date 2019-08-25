using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeEx
{
    class Recipe
    {
        public Recipe(string name, List<string> ingredients, Type recipeType)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.RecipeType = recipeType;
        }


        public Type RecipeType { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public enum Type
        {
            Veg,
            NonVeg,
            Vegan
        }
    }
}
