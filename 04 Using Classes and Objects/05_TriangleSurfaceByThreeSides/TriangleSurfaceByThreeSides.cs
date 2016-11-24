using System;

namespace _05_TriangleSurfaceByThreeSides
{
    static class Triangle
    {
        public static double AreaByThreeSides(double side1, double side2, double side3)
        {
            double area;
            double s = (side1 + side2 + side3) / 2; // semiparameter
            area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            return area;
        }
    }

    class TriangleSurfaceByThreeSides
    {
        static void Main()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Triangle.AreaByThreeSides(side1, side2, side3));
        }
    }
}
