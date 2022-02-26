using System;

namespace Exception_Misuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Numerator");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Denominator");
                int deno = Convert.ToInt32(Console.ReadLine());
                int results = num / deno;
                Console.WriteLine(results);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("divide by zero not allowed");
            }
            catch (FormatException)
            {
                Console.WriteLine("only Numbers allowed");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only numbers in the range of " +Int16.MaxValue + " and " + Int32.MaxValue + " are alowed");
            }
           
        }
    }
}
