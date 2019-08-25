using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allergies = new List<string> { "potato", "gluten", "peanuts"};

            List<Recipe> recipes = new List<Recipe>();            

            recipes.Add(new Recipe("Pasta", new List<string> { "gluten", "onion", "tomato", "pasta sause" }, Recipe.Type.Veg));
            recipes.Add(new Recipe("Fruit Custard", new List<string> { "milk", "fruites", "cream", "sugar" }, Recipe.Type.Veg));
            recipes.Add(new Recipe("Rice", new List<string> { "peanuts", "onion", "rice", "lemon" }, Recipe.Type.Veg));
            recipes.Add(new Recipe("Thai Curry", new List<string> { "chicken", "lemongrass", "brocoli", "coconut milk" }, Recipe.Type.NonVeg));
            recipes.Add(new Recipe("Tofu Curry", new List<string> { "tofu", "onion", "tomato", "masala" }, Recipe.Type.Vegan));

            var vegRecipes = recipes.FindAll(x => x.RecipeType.Equals(Recipe.Type.Veg));

            Console.WriteLine("Veg Recipes");

            PrintList(vegRecipes);

            var nonVegRecipes = recipes.FindAll(x => x.RecipeType.Equals(Recipe.Type.NonVeg));

            Console.WriteLine("Non Veg Recipes");

            PrintList(nonVegRecipes);

            var allergicRecipes = recipes.FindAll(x => x.Ingredients.Intersect(allergies).Any());

            Console.WriteLine("Allergic Recipes");

            PrintList(allergicRecipes);

            Console.ReadLine();
        }


        public static void PrintList(List<Recipe>recipes)
        {
            foreach(var recipe in recipes)
            {
                Console.WriteLine(recipe.Name);
            }
        }
    }
}
