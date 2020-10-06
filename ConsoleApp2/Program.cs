using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new Test();
            var newNum = test1.Num02;
            Console.WriteLine(newNum);
            Console.WriteLine("tjabba");
        }
    }

    class Test
    {
        public Test()
        {
            
        }


        public int _num = 22;
        public int Num02 = 23;

    }
    
    
}    