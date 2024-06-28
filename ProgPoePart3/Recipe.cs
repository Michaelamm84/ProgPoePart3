using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoePart3
{
    /*Michael Amm
 * st10396724
 * 2024/6/27
 * PROGPOE PART 3
 * Group 1
 * */
    public class Recipe
    {
        //Attributes of the Recipe class
        public string name { get; set; }

        public int numIng { get; set; }

        public int NumSteps { get; set; }

        //lists that contain the steps and ingrediants
        public List<String> Steps { get; set; }
        public List<Ingrediant> Ingrediants { get; set; }
        public List<Ingrediant> BackUpIngrediants { get; set; }


        //------------------------------------------------------------------------------------------------------------//


        //Constructor of the Recipe class
        public Recipe()
        {
            Ingrediants = new List<Ingrediant>();
            BackUpIngrediants = new List<Ingrediant>();
            Steps = new List<string>(); // Initialize the Steps list property
        }
        //------------------------------------------------------------------------------------------------------------//

    }

}

//End of file 


