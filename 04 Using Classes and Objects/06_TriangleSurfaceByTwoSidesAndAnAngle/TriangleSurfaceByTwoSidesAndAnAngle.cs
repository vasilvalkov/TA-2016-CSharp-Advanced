using System;

namespace _06_TriangleSurfaceByTwo_SidesAndAnAngle
{
    static class Triangle
    {
        public static double AreaByTwoSidesAndAngle(double side1, double side2, double angle)
        {
            double area;
            area = ((side1 * side2 * Math.Sin(angle * Math.PI / 180)) / 2) ;
            return area;
        }
    }

    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Triangle.AreaByTwoSidesAndAngle(side1, side2, angle));

        }
    }
}
