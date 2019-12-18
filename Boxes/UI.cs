using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Boxes
{
    class UI
    {
        public Box CreateBox()
        {
            Box box = new Box();
            string input; 
            WriteLine("Lets make a box!");

            WriteLine("How high is the box?");
            input = ReadLine();
            box.Height = dimensionCheck(input);
            WriteLine("How long is the box?");
            input = ReadLine();
            box.Length = dimensionCheck(input);
            WriteLine("How wide is the box?");
            input = ReadLine();
            box.Width = dimensionCheck(input); 
            WriteLine("What material would you like it made of? \n (Concrete, Steel, Wood, PVC, or Cardboard)");
            input = ReadLine();
            box.Density = MaterialCheck(input);


            return box;
        }

        private static double dimensionCheck(string input)
        {
            double side;
            bool successfulParse = Double.TryParse(input, out side);

            while (!successfulParse)
            {
                WriteLine("I am sorry but that was not a valid number, please try again.");
                input = ReadLine();
                successfulParse = Double.TryParse(input, out side);
            }

            return side;
        }

        private static double MaterialCheck(string input)
        {
            bool validMaterial = false;
            input = input.ToLower();
            double density = 0;

            while(!validMaterial)
            {
                if (input.IndexOf("concrete") >= 0)
                {
                    validMaterial = true;
                    density = 2400;
                } else if (input.IndexOf("steel") >= 0)
                {
                    validMaterial = true;
                    density = 750;
                } else if (input.IndexOf("wood") >= 0)
                {
                    validMaterial = true;
                    density = 420;
                }
                else if (input.IndexOf("pvc") >= 0)
                {
                    validMaterial = true;
                    density = 145;
                }
                else if (input.IndexOf("cardboard") >= 0)
                {
                    validMaterial = true;
                    density = 689;
                } else
                {
                    WriteLine("We don't have that material. Please check your spelling or specify a material we have such as Concrete, Steel, Wood, PVC, Cardboard");
                }


            }

            return density;
            
        }

        
    }
}
