using System;

namespace _6_kyu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CamelCase_Method cm = new CamelCase_Method();
            Console.WriteLine(CamelCase_Method.CamelCase("test me"));
        }
    }
}
