using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgPoePart3
{
    
    /*Michael Amm
     * st10396724
     * 2024/6/27
     * PROGPOE PART 3
     * Group 1
     * */
    public partial class Ingredient : Window //ingrediant Class
    {


        private Recipe currentRecipe; // Store the current Recipe object

        public Ingredient(Recipe recipe) //Constructor
        {
            InitializeComponent();
            currentRecipe = recipe; // Store the passed-in Recipe for later use
        }

        //------------------------------------------------------------------------------------------------------------//


        // Define the Submit_Click event handler
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            
            
            //collecting data from the text boxes and doing something with it.
            Ingrediant ingrediant = new Ingrediant();
            ingrediant.ingName = txtIngName.Text;
            ingrediant.quanity = double.Parse(txtQuantity.Text);
            ingrediant.uOm = txtUoM.Text;
            ingrediant.cal = int.Parse(txtCal.Text);
            ingrediant.foodGroup = txtFoodGroup.Text;
            currentRecipe.Ingrediants.Add(ingrediant);

            
            string ingName = txtIngName.Text;
            string quantity = txtQuantity.Text;
            string uom = txtUoM.Text;
            string calories = txtCal.Text;
            string foodGroup = txtFoodGroup.Text;

            // variables to create an Ingredient object, save it, or perform other actions.
            MessageBox.Show($"Ingredient: {ingName}, Quantity: {quantity}, Unit of Measure: {uom}, Calories: {calories}, Food Group: {foodGroup}");

            
            Close(); //Closing the window

        }
    }
}
//end of file


