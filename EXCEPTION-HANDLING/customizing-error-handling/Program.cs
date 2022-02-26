using System;

namespace customizing_error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Numerator");
                int numerator;

                bool IsNumaratorValidationSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);

                if (IsNumaratorValidationSuccessful)
                {
                    Console.WriteLine("Enter Denominator");
                    int denominator;
                    bool IsdenominatorValidationSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);
                    if (IsdenominatorValidationSuccessful && denominator != 0)
                    {
                        int results = numerator / denominator;
                        Console.WriteLine(results);
                    }
                    else
                    {
                        if (denominator == 0)
                        {
                            Console.WriteLine("devide by zero not allowed");
                        }
                        else
                        {
                            Console.WriteLine("denominator should be of range " + Int32.MinValue + "and " + Int32.MaxValue + "");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numerator should be of range " + Int32.MinValue + "and " + Int32.MaxValue + "");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }

        }

    }
}