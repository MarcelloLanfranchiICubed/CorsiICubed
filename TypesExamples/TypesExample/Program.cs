//#define FIRSTVERSION
//#define SECONDVERSION
#define THIRDVERSION

using TypesExample.Classes;
using static System.Console;

namespace TypesExample
{
#if (FIRSTVERSION)
    class Program 
    {
        static void Main(string[] args)
        {
            WriteLine("Please, type an integer");
            int result;
            var success = int.TryParse(ReadLine(),out result);
            if(success)
            {
                WriteLine("You have typed an integer!");
            }
            else
            {
                WriteLine("This is not an integer, mother fucker!!");
            }
        }
    }
#endif
#if (SECONDVERSION)
    class Program
    {
        static void Main(string[] args)
        {
            int cooX;
            int cooY;
            var success = false;
            do
            {
                WriteLine("Please, type an integer");
                success = int.TryParse(ReadLine(), out cooX);
                if (success)
                {
                    WriteLine("CooX: " + cooX);
                }
                else
                {
                    WriteLine("This is not an integer, mother fucker!!");
                }
            } while (!success);
            success = false;
            do
            {
                WriteLine("Please, type an integer");
                success = int.TryParse(ReadLine(), out cooY);
                if (success)
                {
                    WriteLine("CooY: " + cooY);
                }
                else
                {
                    WriteLine("This is not an integer, mother fucker!!");
                }
            } while (!success);
            var point = new Point2d(cooX, cooY);
            WriteLine($"Is the 2d point equals to zero? {point.Equals(new { x = 0, y = 0 })}");
            WriteLine($"Is the 2d point equals to zero? {point.Equals(new Point2d())}");
        }
    }
#endif
#if (THIRDVERSION)
    class Program
    {
        static void Main(string[] args)
        {
            int dimension;
            var success = false;
            do
            {
                WriteLine("Please, type an integer");
                success = int.TryParse(ReadLine(), out dimension);
                if (success)
                {
                    WriteLine("CooX: " + dimension);
                }
                else
                {
                    WriteLine("This is not an integer, mother fucker!!");
                }
            } while (!success);
            var coordinates = new int[dimension];
            success = false;
            for(int i = 1; i <= dimension; i++)
            {
                do
                {
                    WriteLine("Please, type an integer");
                    success = int.TryParse(ReadLine(), out coordinates[i - 1]);
                    if (success)
                    {
                        WriteLine($"Coo{i}: {coordinates[i - 1]}");
                    }
                    else
                    {
                        WriteLine("This is not an integer, mother fucker!!");
                    }
                } while (!success);
            }
            var point = new PointNd(coordinates);
            WriteLine($"Is the {point.Dimension()}d point equals to zero? {point.Equals(new PointNd(dimension))}");
        }
    }
#endif
}
