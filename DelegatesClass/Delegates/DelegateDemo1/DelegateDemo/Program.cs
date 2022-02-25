using System;

namespace DelegateDemo
{
    //signature of the deligate should match the signature of the method;
    public delegate void HelloFuctionDelegate(string message);
     class Program
    {
        static void Main(string[] args)
        {
            // a deligate is a type safe function pointer;
            HelloFuctionDelegate del = new HelloFuctionDelegate(Hello);
                del("hello from Evans");
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

    }
   
  
}
