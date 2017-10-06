using System;

namespace RecursiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tests.AreEqual(Power.CopmutePower(3, 0), 1));
            Console.ReadKey();
        }

    }


    static class Tests
    {
        public static string AreEqual(double expected, double actual)
        {
            return expected == actual ? string.Format(" Test Passed- {0} raised to power {1} is {2}" , expected , actual , Math.Pow(expected , actual)) 
                : string.Format("Test Failed - Expected {0} - Actual {1}", Math.Pow(expected, actual), Power.CopmutePower(expected , actual));  
        }
    }

    public  static class Power
    {


        public static double CopmutePower(double x , double n)
        {
            // base case
            if (n == 0)
            {
                return 1;
            }

            // recursive case: n is negative 
            else if (n < 0)
            {
                return 1 / CopmutePower(x, -n);
            }
            // recursive case: n is odd
            else if (IsOdd(n))
            {
                return x * CopmutePower(x, n - 1);
            }
            // recursive case: n is even
            else if (IsEven(n))
            {
                var y = CopmutePower(x, n / 2);
                return y * y;
            }
            else
            {
                return 0;
            }

           
        }
        
        static bool IsEven(double n)
        {
            return n % 2 == 0;
        }

        static bool IsOdd(double n)
        {
            return !IsEven(n);
        }
    }
}
