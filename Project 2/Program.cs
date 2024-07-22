namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 5;

            Console.WriteLine($"Add: {num1} + {num2} = {Maths.Add(num1, num2)}");
            Console.WriteLine($"Subtract: {num1} - {num2} = {Maths.Subtract(num1, num2)}");
            Console.WriteLine($"Multiply: {num1} * {num2} = {Maths.Multiply(num1, num2)}");
            Console.WriteLine($"Divide: {num1} / {num2} = {Maths.Divide(num1, num2)}");
        }
    }
}
