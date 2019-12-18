using System;
using static System.Console;
using static Boxes.Box;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            
            WriteLine("Volume is {0}, Surface Area is {1}", box1.Volume, box1.SurfaceArea);

            Box box2 = new Box(2, 3, 3);

            WriteLine("Volume is {0}, Surface Area is {1}", box2.Volume, box2.SurfaceArea);

            box2.Length = 7;
            box2.Label = "OXxyBox";
            WriteLine("Volume is {0}, Surface Area is {1}", box2.Volume, box2.SurfaceArea);

            WriteLine("Volume is {0}, Surface Area is {1}", Box.findVolume(2,3,3), Box.findSurfaceArea(2,3,3));

            WriteLine(box2.ShippingID());
        }
    }
}
