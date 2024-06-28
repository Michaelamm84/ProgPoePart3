using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

/*Michael Amm
 * st10396724
 * 2024/6/27
 * PROGPOE PART 3
 * Group 1
 * */

namespace ProgPoePart3
{
   
    public partial class SecondForm : Window
    {
        public Recipe newRecipe = new Recipe();
        private Tools tools; // Store the current Recipe object
        private Recipe recipe; // Store the current Recipe object

        // Define the SecondForm constructor
        public SecondForm(Tools tool, Recipe recipe)
        {
            InitializeComponent();
            PopulpateCombobox();

            this.tools = tool; // Store the passed-in Recipe for later use
            this.recipe = recipe; // Store the passed-in Recipe for later use
        }

        //------------------------------------------------------------------------------------------------------------//

        //Populating combo box 
        private void PopulpateCombobox()
        {
            List<int> ingredients = new List<int>(); // Create a list of integers with loops
            for (int i = 1; i <= 100; i++)
            {
                ingredients.Add(i);
            }
            numIngredient.ItemsSource = ingredients;
        }

        //------------------------------------------------------------------------------------------------------------//


        // Define the Submit_Click event handler
        //submiting recipe, ingredients and steps
        //loops bring up windows to input ingredients and steps
        //stores the data in the recipe object
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            SecondForm second = new SecondForm(tools, recipe);

            


            newRecipe.name = RecipeName.Text;
            newRecipe.numIng = int.Parse(numIngredient.Text);
            newRecipe.NumSteps = int.Parse(steps.Text);

            for (int i = 0; i < newRecipe.numIng; i++)
            {
                Ingredient ingredient = new Ingredient(newRecipe);

                ingredient.ShowDialog(); // Initialize and open the Ingredient.xam
                
                                
            }
            if (int.TryParse(steps.Text, out int numberOfSteps))
            {
                for (int i = 1; i <= numberOfSteps; i++)
                {
                    // For each step, create and show the Steps form dialog
                    Steps stepsForm = new Steps(newRecipe);

                      
                    stepsForm.ShowDialog(); // Show the Steps form as a modal dialog


                    
                }
            }


                // Retrieve the text from the TextBox
                string inputText = RecipeName.Text;
            tools.Recipes.Add(newRecipe);

            // Show the text in a MessageBox
            MessageBox.Show("You entered: " + inputText);
            Close();

        }
        //------------------------------------------------------------------------------------------------------------//


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //------------------------------------------------------------------------------------------------------------//

        //Creates the form to inout Steps
        //uses loops to populate the the List
        private void Steps_Click(object sender, RoutedEventArgs e)
        {
            // Parse the number of steps from the numSteps TextBox
            if (int.TryParse(steps.Text, out int numberOfSteps))
            {
                for (int i = 1; i <= numberOfSteps; i++)
                {
                    // For each step, create and show the Steps form dialog
                    Steps stepsForm = new Steps(newRecipe);
                    stepsForm.ShowDialog(); // Show the Steps form as a modal dialog


                      
                }

    
            }


        }
        //------------------------------------------------------------------------------------------------------------//


    }
}
//end of file
