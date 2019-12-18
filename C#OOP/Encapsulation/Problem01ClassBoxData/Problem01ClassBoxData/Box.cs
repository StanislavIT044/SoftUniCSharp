namespace Problem01ClassBoxData
{
    using System;
    public class Box
    {
        public Box(double length, double width, double height)
        {
            if (length <= 0)
            {
                Console.WriteLine($"Length cannot be zero or negative.");
                return;
            }
            else
            {
                this.Length = length;
            }

            if (width <= 0)
            {
                Console.WriteLine($"Width cannot be zero or negative.");
                return;
            }
            else
            {
                this.Width = width;
            }

            if (height <= 0)
            {
                Console.WriteLine($"Height cannot be zero or negative.");
                return;
            }
            else
            {
                this.Height = height;
            }

        }
        public double Length { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }

        public double GetSurfaceArea() // Surface Area = 2lw + 2lh + 2wh
        {
            double surfaceAre = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return surfaceAre;
        }

        public double GetLeteralSurfaceArea() // Lateral Surface Area = 2lh + 2wh
        {
            double leteralSurfaceAre = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return leteralSurfaceAre;
        }

        public double GetVolume() // Volume = lwh
        {
            double volume = this.Length * this.Width * this.Height;
            return volume;
        }
    }
}
