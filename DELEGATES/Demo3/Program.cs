using System;

namespace Demo3
{
    public delegate void SampleDeligate();
    class Program
    {
        static void Main(string[] args)
        {
            SampleDeligate del = new SampleDeligate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del();
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree invoked");
        }

    }
   
}
