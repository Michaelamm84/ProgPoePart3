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
/*Michael Amm
 * st10396724
 * 2024/6/27
 * PROGPOE PART 3
 * Group 1
 * */

namespace ProgPoePart3
{
    
    public partial class Steps : Window
    {
        private Recipe currentRecipe; // Store the current Recipe object

        //------------------------------------------------------------------------------------------------------------//

        public Steps(Recipe recipe)
        {
            InitializeComponent();
            currentRecipe = recipe; // Store the passed-in Recipe for later use
        }
        //------------------------------------------------------------------------------------------------------------//



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------------------------//


        private void submitsteps(object sender, RoutedEventArgs e)
        {

            // Retrieve the entered step from the TextBox
            string stepText = step.Text;



            // Access the instance in the SecondForm and add the step
            currentRecipe.Steps.Add(stepText);
            


            Close(); // closes application after step is added
        }
        //------------------------------------------------------------------------------------------------------------//


    }
}
//end of file

