using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ST10045844.PROG6221.POEPART1
{
    internal class Program : Recipe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, create a recipe.");
            Recipe recipe = new Recipe();

            Console.WriteLine("Enter recipe Name:");
            recipeName = Console.ReadLine();
            recipe.DetailRecipe();

            Console.WriteLine("Enter yes to display recipe or no to not display it:");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "yes")
            {
                recipe.RecipeDisplay();
            }
            else if (yesOrNo == "no")
            {
                Console.WriteLine("Recipe will not be displayed");
            }
            //https://www.c-sharpcorner.com/article/how-to-use-c-sharp-if-else-statement/
            // Mahesh Chand

            Console.WriteLine("Would you like to scale recipe. Enter yes or no:");

            string scale = Console.ReadLine();
            if (scale == "yes") { 
                Console.WriteLine("Enter 1 to half the recipe or 2 to double the recipe or 3 to triple the recipe:");
            double userScaleInput = double.Parse(Console.ReadLine());
              

            if (userScaleInput == 1)
            {
                recipe.QuantityScale(userScaleInput);
                    recipe.RecipeDisplay();   
            }
            else if (userScaleInput == 2)
            {
                recipe.QuantityScale(userScaleInput);
                    recipe.RecipeDisplay();
                }
            else if (userScaleInput == 3)
            {
                recipe.QuantityScale(userScaleInput);
                    recipe.RecipeDisplay();
                }
           
                //https://www.c-sharpcorner.com/article/how-to-use-c-sharp-if-else-statement/
                // Mahesh Chand

                Console.WriteLine("Would you like to revert changes back to the orignal of the recipe:");
                string reset = Console.ReadLine();
                if (reset == "yes")
                {
                    recipe.RevertQuantities(Convert.ToInt32(userScaleInput));
                    recipe.RecipeDisplay();
                }
                else if (reset == "no")
                {
                    Console.WriteLine("Recipe remains the same.");

                }
            }
            else if (scale== "no")
            {
                Console.WriteLine("Recipe is not scaled");
                recipe.RecipeDisplay();
            }
            //https://www.c-sharpcorner.com/article/how-to-use-c-sharp-if-else-statement/
            // Mahesh Chand

            //https://www.geeksforgeeks.org/c-sharp-methods/
            // keshav_786






            Console.WriteLine("Would you like to clear current recipe:");
            string clear = Console.ReadLine();
            if (clear == "yes")
            {
                recipe.ResetRecipe();
            }
            else if (clear == "no")
            {
                Console.WriteLine("Recipe remains saved");
                   recipe.RecipeDisplay();
                    }
            //https://www.c-sharpcorner.com/article/how-to-use-c-sharp-if-else-statement/
            // Mahesh Chand

            Console.WriteLine("Would you like to exit program");
            string exit=Console.ReadLine();

            if (exit == "yes")
            {
                Environment.Exit(0);
            }
            else if (exit == "no")
            {
                Console.WriteLine("Would you like to enter a recipe then?");
                string newRec = Console.ReadLine();
                if (newRec == "yes")
                {
                    Console.WriteLine("Enter recipe Name:");
                    recipeName = Console.ReadLine();
                    recipe.DetailRecipe();
                    recipe.RecipeDisplay();


                    Console.WriteLine("Please enter scale value for recipe, enter 1 to half recipe, 2 to double recipe and 3 to triple recipe:");
                    double userScaleInput = double.Parse(Console.ReadLine());
                    recipe.QuantityScale(userScaleInput);
                    Console.WriteLine("Would you like to revert quantities");
                    string newRecRev=Console.ReadLine();
                    if (newRecRev == "yes")
                    {
                        Console.WriteLine("Receipe reverted");
                        recipe.RevertQuantities(Convert.ToInt32(userScaleInput));
                        recipe.RecipeDisplay();
                        Console.WriteLine("Good bye");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (newRecRev == "no")
                    {
                        Console.WriteLine("Recipe remains scaled");
                        recipe.RecipeDisplay();

                        Console.WriteLine("Good bye");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    
                }
                else if(newRec == "no")
                {
                    Environment.Exit(0);
                }
                //https://www.c-sharpcorner.com/article/how-to-use-c-sharp-if-else-statement/
                // Mahesh Chand
            }
            Console.ReadLine();
        }
    }

}
