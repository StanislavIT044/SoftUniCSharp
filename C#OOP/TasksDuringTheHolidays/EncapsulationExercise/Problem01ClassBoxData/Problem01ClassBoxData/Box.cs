using System;
using System.Collections.Generic;
using System.Text;

namespace Problem01ClassBoxData
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        internal Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        internal double Length 
        {
            get
            {
                return length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        internal double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        internal double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public double surfaceArea()
        {
            double surfaceArea = 2 * this.length * this.width +
                2 * this.length * this.height +
                2 * this.width * this.height;

            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * this.length * this.height +
                2 * this.width * this.height;

            return lateralSurfaceArea;
        }
        public double Volume()
        {
            double volume = this.length * this.width * this.height;

            return volume;
        }
    }
}
