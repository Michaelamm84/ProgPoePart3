using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProgPoePart3
{
    public partial class Printz : Window // Printz class inherits from Window
    {
        private Tools tools; // Store the current Tools object
        private List<Recipe> filteredRecipes; // Store the filtered recipes

        public Printz(Tools tools) //prints constructor
        {
            InitializeComponent();
            this.tools = tools;
            PopulateRecipesListView();
        }
        //------------------------------------------------------------------------------------------------------------//

        private void Print_Click(object sender, RoutedEventArgs e) //print button for recipes
        {
            StringBuilder recipesList = new StringBuilder("Recipes:\n");

            foreach (var recipe in tools.Recipes)
            {
                recipesList.AppendLine(recipe.name);
            }

            MessageBox.Show(recipesList.ToString());
        }

        //------------------------------------------------------------------------------------------------------------//


        private void PopulateRecipesListView() //method that populates Itemsource of the ListView
        {
            RecipesListView.ItemsSource = tools.Recipes;
        }

        //------------------------------------------------------------------------------------------------------------//


        private void Search_Click(object sender, RoutedEventArgs e) //search button that searches for recepies
        {
            string searchText = SearchTextBox.Text.ToLower();
            filteredRecipes = tools.Recipes.Where(r => r.name.ToLower().Contains(searchText)).ToList();
            RecipesListView.ItemsSource = filteredRecipes;
        }
        //------------------------------------------------------------------------------------------------------------//

    }
}
//end of file
