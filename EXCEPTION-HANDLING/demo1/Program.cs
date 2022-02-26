using System;
using System.IO;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = null;
            try
            {
                stream = new StreamReader(@"D:\file\dummyData.txt");
                Console.WriteLine(stream.ReadToEnd());
                stream.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if file " + ex.FileName + " Exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
                Console.WriteLine("\n Evans Stream was closed successfully");
            }
        }
    }
}
