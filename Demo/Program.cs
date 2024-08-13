namespace Demo
{
    internal class Program
    {

        // 1. Operator Overloading
        public class ComplexNumber
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }

            public ComplexNumber(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            // Overload + operator
            public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
            }

            // Overload - operator
            public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
            }

            public override string ToString()
            {
                return $"{Real} + {Imaginary}i";
            }
        }

        // 2. Casting Operator Overloading
        public class Fahrenheit
        {
            public double Temperature { get; set; }

            public Fahrenheit(double temperature)
            {
                Temperature = temperature;
            }

            // Implicit conversion from Fahrenheit to Celsius
            public static implicit operator Celsius(Fahrenheit f)
            {
                return new Celsius((f.Temperature - 32) * 5 / 9);
            }
        }

        public class Celsius
        {
            public double Temperature { get; set; }

            public Celsius(double temperature)
            {
                Temperature = temperature;
            }

            public override string ToString()
            {
                return $"{Temperature} °C";
            }
        }

        // 3. Abstraction
        public abstract class Shape
        {
            public abstract double Area { get; }

            public void DisplayArea()
            {
                Console.WriteLine($"The area is {Area}");
            }
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            // Override abstract property
            public override double Area => Width * Height;
        }

        // 4. Static Members
        public static class MathUtilities
        {
            public static double PI { get; } = 3.14159;

            public static double Square(double number)
            {
                return number * number;
            }

            // Static Constructor
            static MathUtilities()
            {
                Console.WriteLine("Static MathUtilities Constructor Called");
            }
        }

        // 5. Sealed Class and Methods
        public sealed class Utility
        {
            public void DisplayMessage()
            {
                Console.WriteLine("Utility class method.");
            }

            // Sealed Method
            public sealed class NestedUtility
            {
                public void NestedMethod()
                {
                    Console.WriteLine("NestedUtility class method.");
                }
            }
        }
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);
            Console.WriteLine($"Addition: {c1 + c2}"); 
            Console.WriteLine($"Subtraction: {c1 - c2}"); 

            Fahrenheit f = new Fahrenheit(100);
            Celsius c = f; 
            Console.WriteLine($"Temperature in Celsius: {c}"); 

            Shape shape = new Rectangle(4, 5);

            Console.WriteLine($"PI: {MathUtilities.PI}");
            Console.WriteLine($"Square of 5: {MathUtilities.Square(5)}");

            Utility utility = new Utility();
            utility.DisplayMessage();
            Utility.NestedUtility nestedUtility = new Utility.NestedUtility();
            nestedUtility.NestedMethod();
        }
    }
}
