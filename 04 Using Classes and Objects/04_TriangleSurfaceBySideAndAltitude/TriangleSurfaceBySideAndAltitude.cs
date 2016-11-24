using System;

namespace _04_TriangleSurfaceBySideAndAltitude
{
    static class Triangle
    {
        public static double AreaBySideAndAlt(double side, double altitude)
        {
            double area = (side * altitude) / 2;
            return area;
        }
    }

    class TriangleSurfaceBySideAndAltitude
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double alt = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}" ,Triangle.AreaBySideAndAlt(side, alt));
        }
    }
}
