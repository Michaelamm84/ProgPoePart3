using ProgPoePart3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace ProgPoePart3
{
    /*Michael Amm
 * st10396724
 * 2024/6/27
 * PROGPOE PART 3
 * Group 1
 * */
    public class Tools
    {
        //List of recipes
        public List<Recipe> Recipes = new List<Recipe>();
        public List<Recipe> BackUpRecipes = new List<Recipe>();


        public Tools() //constructor for tools
        {
            
            BackUpRecipes = new List<Recipe>();
            Recipes = new List<Recipe>();
        }

        /*-----------------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------*/


        //old method to prompt input
        public int Introduction()
        {
            int opt = 0;
            string welcome = "welcome to recipe maker:" +
                             "\n enter '1' to create new recipe" +
                             "\n enter '2' to change scale of a saved recipe" +
                             "\n enter '3' to display full recipe " +
                             "\n enter '4' calculate calories for a recipe" +
                             "\n enter '5' print recipes alphabetically" +
                             "\n enter '6' to exit";
            Console.WriteLine(welcome);
            opt = int.Parse(Console.ReadLine());
            return opt;
        }

        /*-----------------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------*/

        // made a delegate
        public delegate void CaloriesExceededDelegate(string recipeName, int totalCalories);

        /*-----------------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------*/

        public int CalculateTotalCalories(string recipeName)
        {
            // Find the recipe with the given name
            var recipe = Recipes.FirstOrDefault(r => r.name == recipeName);


            if (recipe == null)
            {
                Console.WriteLine("Recipe not found.");
                return 0;
            }



            // Calculate the total calories
            int totalCalories = 0;
            foreach (var ingredient in recipe.Ingrediants)
            {
                totalCalories += ingredient.cal;
            }

           
            return totalCalories;
        }
        /*-----------------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------*/


        public void ChangeQuantities(string recipeName, int factor)
        {
            // Find the recipe with the given name
            var recipe = Recipes.FirstOrDefault(r => r.name == recipeName);


            if (recipe == null)
            {
                Console.WriteLine("Recipe not found.");
                return;
            }

            // Scaling up the quantities of all ingredients in recipe
            foreach (var ing in recipe.Ingrediants)
            {
                ing.quanity = ing.quanity * factor;
                if (ing.uOm == "teaspoons" && ing.quanity > 3)
                {
                    ing.uOm = "tablespoons";
                    ing.quanity = ing.quanity / 3;
                }
                else if (ing.uOm == "tablespoons" && ing.quanity > 16)
                {
                    ing.uOm = "cups";
                    ing.quanity = ing.quanity / 16;
                }
            }
        }



        /*-----------------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------*/


        public void RevertIngredients(Recipe rec)
        {
            rec.Ingrediants = new List<Ingrediant>(rec.BackUpIngrediants);
        }

        /*-----------------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------*/

        //Prints the recipe alphabetically
        public string PrintRecipesAlphabetically(Recipe recipe) //print button for recipes
        {

            StringBuilder result = new StringBuilder();
            var sortedRecipes = Recipes.OrderBy(r => r.name).ToList();

            foreach (var recipes in sortedRecipes)
            {
                result.AppendLine(recipe.name);
                foreach (var ingredient in recipe.Ingrediants)
                {
                    result.AppendLine($"Ingredient: {ingredient.ingName}, Unit of Measurement: {ingredient.uOm}, Quantity: {ingredient.quanity}, Calories: {ingredient.cal}");
                }
                result.AppendLine("--------------------");
            }
            MessageBox.Show("mayn");

            return result.ToString();
        }
        //------------------------------------------------------------------------------------------------------------//


    }

}
//end of file
