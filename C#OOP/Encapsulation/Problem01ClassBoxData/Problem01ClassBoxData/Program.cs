namespace Problem01ClassBoxData
{
    using System;

    public class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            if (length <= 0 || width <= 0 || height <= 0)
            {
                return;
            }

            Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.GetLeteralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.GetVolume():F2}");

        }
    }
}
