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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgPoePart3
{
    /*Michael Amm
 * st10396724
 * 2024/6/27
 * PROGPOE PART 3
 * Group 1
 * */
    public partial class MainWindow : Window
    {
        // Tools tools = new Tools();
        public Recipe rec = new Recipe();
        public Tools tool = new Tools();

        // Define the MainWindow constructor

        public MainWindow()
        {

            InitializeComponent();
            
        }
        //------------------------------------------------------------------------------------------------------------//


        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {

            // Create an instance of SecondForm
            SecondForm secondForm = new SecondForm(tool, rec);

            // Show the form
            secondForm.Show(); 
            
        }
        //------------------------------------------------------------------------------------------------------------//


        private void ChangeIngredient_Click(object sender, RoutedEventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------------------------//


        private void CalCalories_Click(object sender, RoutedEventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------------------------//


        private void DeleteRecipe_Click(object sender, RoutedEventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------------------------//



        private void Exist_Click(object sender, RoutedEventArgs e)
        {


        }
        //------------------------------------------------------------------------------------------------------------//


        // Define the Button_Click event handler for the "Exit application" button

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown(); // This will close the application

        }

        //------------------------------------------------------------------------------------------------------------//




        // implementation of GetRecipes 
        private List<Recipe> GetRecipes()
        {
            
            Tools tools = new Tools();
            return tools.Recipes; // Assuming Recipes is a public property of Tools
        }

        //------------------------------------------------------------------------------------------------------------//

        // Define the Print_Click event handler
        private void Print_Click(object sender, RoutedEventArgs e)
        {
            
            Printz printz = new Printz(tool);


            printz.Show();
        }
    }
       
    }
//end of file

