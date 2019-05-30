using DelegateExample.Classes;
using System;
using static DelegateExample.Classes.Algebra;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var algebra = new Algebra();

            var success = false;
            int operand1;
            do
            {
                Console.WriteLine("Please, enter an integer:");
                success = Int32.TryParse(Console.ReadLine(), out operand1);
                if(!success)
                {
                    Console.WriteLine("Wrong: I said an integer");
                }
            } while (!success);
            success = false;
            int operand2;
            do
            {
                Console.WriteLine("Please, enter an integer:");
                success = Int32.TryParse(Console.ReadLine(), out operand2);
                if (!success)
                {
                    Console.WriteLine("Wrong: I said an integer");
                }
            } while (!success);

            AlgebraicOperation operation = algebra.Sum;
            Console.WriteLine($"Their sum is {operation(operand1,operand2)}");
            operation = algebra.Product;
            Console.WriteLine($"Their product is {operation(operand1, operand2)}");
            Console.WriteLine("________________________");
            operation = StaticAlgebra.Sum;
            Console.WriteLine($"Their static sum is {operation(operand1, operand2)}");
            operation = StaticAlgebra.Product;
            Console.WriteLine($"Their static product is {operation(operand1, operand2)}");
        }
    }
}
