using System;
using System.IO;

namespace Demo2
{

    class Program
    {
        //the innerException property returns the Excemption instance that  caused by the current Exception
        //To return the original exception pass it as a parameter to the constructor , of the current exception
        //always check if inner exception is not null before accessing any property of the inner exception object ,else you may get null reference exeception
        //To get the innerExcemption use GetType()method
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    int results = firstNumber / secondNumber;
                    Console.WriteLine("result is " + results + " ");
                }
                catch (Exception ex)
                {
                    string path = @"C:\testfile\test22.txt";
                    //checks if the file exists
                    if (File.Exists(path))
                    {
                        StreamWriter sw = new StreamWriter(path);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine(ex.Message);
                    }
                    //if the file does not exist this line is executed
                    else
                    {
                        throw new FileNotFoundException("the file " + path + " was not found", ex);
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("current Exemption " + exception.GetType().Name + "");
                //check inner exeption exists then execute this line
                if(exception.InnerException != null)
                {
                    Console.WriteLine("inner Exception " + exception.InnerException.GetType().Name + "");
                }
            }
        }
    }
}
