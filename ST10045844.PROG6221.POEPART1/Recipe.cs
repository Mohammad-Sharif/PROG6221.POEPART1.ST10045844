using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ST10045844.PROG6221.POEPART1
{
    internal class Recipe : RecipeArrays
    {


        public static string recipeName { get; set; }

        public static int noOfIngredients { get; set; } 
        public static int noOfSteps { get; set; }
        public static int userInput;
        //https://www.geeksforgeeks.org/static-keyword-in-c-sharp/
        // ankita_saini
        public Recipe()
        {
           Quantity= new double[0];
            Ingredient = new string[0];
            Steps = new string[0];
            MeasurementUnit = new string[0];

        }
        public void DetailRecipe()
        {
            Console.WriteLine("Enter the number of Ingredients:");
             userInput = Int32.Parse(Console.ReadLine());
         
            Ingredient = new string[userInput];
            Console.WriteLine("Enter the number of steps:");
            int stepsInput = Convert.ToInt32(Console.ReadLine());
            Steps = new string[stepsInput];
            MeasurementUnit = new string[userInput];

            Quantity = new double[userInput];
            Ingredient = new string[userInput];
            Steps = new string[stepsInput];
            MeasurementUnit = new string[userInput];
            //https://www.geeksforgeeks.org/c-sharp-arrays/
            //Mithun Kumar, Kehsav_786 and niku123
            for (int s = 0; s < userInput; s++)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Enter the ingredient details", s + 1);
                Console.WriteLine("Enter the ingredients:");
                Ingredient[s] = Console.ReadLine();
                Console.WriteLine("Enter the Quantity of each ingredient:");
                Quantity[s] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter measurement units of ingredients:");
                MeasurementUnit[s] = Console.ReadLine();

            }

            for (int n = 0; n < stepsInput; n++)
            {
                Console.WriteLine("Please enter the steps for the recipe:");
                Steps[n] = Console.ReadLine();
            }
        }
        //https://www.geeksforgeeks.org/c-sharp-methods/
        // keshav_786


        //https://www.geeksforgeeks.org/c-sharp-arrays/
        //Mithun Kumar, Kehsav_786 and niku123
        public void RecipeDisplay()
        {
            Console.WriteLine("Recipe name is:"+recipeName);
            Console.WriteLine("Recipe ingredients are:");
            for (int f = 0; f < Ingredient.Length; f++)
            {
                Console.WriteLine($"{Quantity[f]} {Ingredient[f]} {MeasurementUnit[f]}");
            }
            Console.WriteLine("Steps for recipe are the following");
            for (int l = 0; l < Steps.Length; l++)
            {
                Console.WriteLine($"{Steps[l]}");
                Console.WriteLine("----------------------");
            }
            //https://www.geeksforgeeks.org/c-sharp-using-foreach-loop-in-arrays/
            //SoumikMondal

        }
        //https://www.geeksforgeeks.org/c-sharp-methods/
        // keshav_786

        //https://www.geeksforgeeks.org/c-sharp-arrays/
        //Mithun Kumar, Kehsav_786 and niku123
        public void QuantityScale(double userScaleInput)
        {
       
                if (userScaleInput == 2)
                {
                    for (int k=0; k< userInput; k++)
                    {
                        Quantity[k] *= 2;
       
                    }
            
                }
                if (userScaleInput == 3)
                {
                    for (int k = 0; k < userInput  ; k++)
                    {
                        Quantity[k] *= 3;
                       
                    }
                }
                if (userScaleInput == 1)
                {
                    for (int k = 0; k < userInput; k++)
                    {
                        Quantity[k] *= 0.5;
                    
                    }
           
            }
            //https://www.geeksforgeeks.org/c-sharp-using-foreach-loop-in-arrays/
            //SoumikMondal
        }
        //https://www.geeksforgeeks.org/c-sharp-arrays/
        //Mithun Kumar, Kehsav_786 and niku123
        public void ResetRecipe()
        {
            string reset;
  
            Console.WriteLine("Would you like to reset the recipe?");
            
            reset= Console.ReadLine();
            if (reset == "yes")
            {
                Console.WriteLine("Enter recipe Name:");
                recipeName = Console.ReadLine();
                Ingredient = new string[0];
                Quantity = new double[0];
                MeasurementUnit=new string[0];

                Steps=new string[0];
                DetailRecipe();
                RecipeDisplay();
                ResetRecipe();
                Console.WriteLine("Would you like to exit program");
                string exit = Console.ReadLine();

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
                        DetailRecipe();
                        RecipeDisplay();
                    }
                    else if (newRec == "no")
                    {
                        Environment.Exit(0);
                    }
                }

            }
            else if (reset == "no")
            {
                Console.WriteLine("Recipe is saved");
                RecipeDisplay();
            }
        }    //https://www.geeksforgeeks.org/c-sharp-methods/
        // keshav_786
        public void RevertQuantities(int revertInput)
        {
            if (revertInput == 2)
            {
                for (int k = 0; k < userInput; k++)
                {
                    Quantity[k] /= 2;

                }

            }
            if (revertInput == 3)
            {
                for (int k = 0; k < userInput; k++)
                {
                    Quantity[k] /= 3;

                }
            }
            if (revertInput == 1)
            {
                for (int k = 0; k < userInput; k++)
                {
                    Quantity[k] *= 2;

                }

            }
            //https://www.geeksforgeeks.org/c-sharp-using-foreach-loop-in-arrays/
            //SoumikMondal
        }
    }
    //https://www.c-sharpcorner.com/article/how-to-use-c-sharp-if-else-statement/
    // Mahesh Chand
    //https://www.geeksforgeeks.org/c-sharp-methods/
    // keshav_786

}




