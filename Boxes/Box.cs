using System;
using System.Collections.Generic;
using System.Text;

namespace Boxes
{
    /// <summary>
    /// Box Class
    /// Contain the dimensions and finds the volume, mass, and surface area of a box
    /// </summary>
    class Box
    {

        
        double height; //
        double length;
        double width;
        double density;

        public string Label;


        public double madeUp { get; } //testing read-only syntax

        double surfaceArea;
        double volume;
        double mass;
        /// <summary>
        /// Height of the box
        /// </summary>
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                volume = findVolume(height, length, width);
                surfaceArea = findSurfaceArea(height, length, width);
                mass = findMass(density, volume);
            }
        }
        /// <summary>
        /// Length of the box
        /// </summary>
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                volume = findVolume(height, length, width);
                surfaceArea = findSurfaceArea(height, length, width);
                mass = findMass(density, volume);
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                volume = findVolume(height, length, width);
                surfaceArea = findSurfaceArea(height, length, width);
                mass = findMass(density, volume);
            }
        }

        public double Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
                mass = findMass(density, volume);
            }
        }

        /// <summary>
        /// The volume of this box
        /// </summary>
        public double Volume
        {
            get
            {
                return volume;
            }
        }

        /// <summary>
        /// The surface area of this box
        /// </summary>
        public double SurfaceArea
        {
            get
            {
                return surfaceArea;
            }
        }

        public double Mass
        {
            get
            {
                return mass;
            }
        }
        /// <summary>
        /// Constructor that sets default values
        /// </summary>
        public Box()
        {
            Height = 1;
            Length = 1;
            Width = 1;
            Density = 1;


            madeUp = 10;
        }

        /// <summary>
        /// Constructor that sets height, length, and width at construction
        /// </summary>
        /// <param name="H">Height</param>
        /// <param name="L">Length</param>
        /// <param name="W">Width</param>
        public Box(double H, double L, double W)
        {
            Height = H;
            Length = L;
            Width = W;
            Density = 1;

            madeUp = 10;
        }

        /// <summary>
        /// Constructor that sets height, length, width, and density at construction
        /// </summary>
        /// <param name="H">Height</param>
        /// <param name="L">Length</param>
        /// <param name="W">Width</param>
        /// <param name="D">Density of material</param>
        public Box(double H, double L, double W, double D)
        {
            Height = H;
            Length = L;
            Width = W;
            Density = D;

            madeUp = 10;
        }

       


        public static double findVolume(double H, double L, double W)
        {
            double V; //volume

            V = H * L * W;
            return V;
        }

        public static double findSurfaceArea(double H, double L, double W)
        {
            double sArea;
            sArea = 2 * ( H * L +  L * W +  H * W);
            return sArea;
        }

        public static double findMass(double d, double v)
        {
            double m;
            m = d * v;
            return m;
        }

        public string ShippingID()
        {
            string id = String.Format(Label.GetHashCode()+ "v" + volume + "m" + Mass);

            return id;
        }
    }
}
