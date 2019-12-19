using System;
using static System.Console;
using static Boxes.Box;

namespace Boxes
{
    /// <summary>
    /// Program Class
    /// Starts the Boxes program and outputs the volume, mass, and surface area to the user's console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Box box1;

            UI ui = new UI();
            box1 = ui.CreateBox();

            
            WriteLine("Volume is {0}, Surface Area is {1}, and Mass {2}", box1.Volume, box1.SurfaceArea, box1.Mass);

            
        }
    }
}
