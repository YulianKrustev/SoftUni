using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Heigth = height;
        }

        public double Heigth
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }


        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }


        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        public string SurfaceArea()
        {
            double surfaceArea = (2 * length * height) + (2 * length * width) + (2 * height * width);

            return $"Surface Area - {surfaceArea:f2}";
        }

        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * length * height) + (2 * width * height);

            return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
        }

        public string Volume()
        {
            double volume = length * height * width;

            return $"Volume - {volume:f2}";
        }

    }
}
