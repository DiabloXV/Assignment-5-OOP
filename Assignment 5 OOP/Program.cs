using System;
namespace Assignment_5_OOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Point3D P1 = ReadPointFromUser("P1");
            Point3D P2 = ReadPointFromUser("P2");

            if (P1 == P2)
                Console.WriteLine("P1 and P2 are equal.");
            else
                Console.WriteLine("P1 and P2 are not equal.");

            Point3D[] points = new Point3D[]
            {
            new Point3D(5, 6, 7),
            new Point3D(2, 3, 4),
            new Point3D(8, 1, 9),
            new Point3D(3, 2, 1)
            };

            Array.Sort(points);

            Console.WriteLine("Sorted points:");
            foreach (var point in points)
            {
                Console.WriteLine(point);
            }

            Point3D clone = (Point3D)P1.Clone();
            Console.WriteLine($"Cloned point: {clone}");
        }
        private static Point3D ReadPointFromUser(string pointName)
        {
            int x, y, z;
            while (true)
            {
                Console.WriteLine($"Enter coordinates for {pointName} (X Y Z):");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if (parts.Length == 3 &&
                    int.TryParse(parts[0], out x) &&
                    int.TryParse(parts[1], out y) &&
                    int.TryParse(parts[2], out z))
                {
                    return new Point3D(x, y, z);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter three integers separated by spaces.");
                }
            }
        }
    }
}
