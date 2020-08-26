using System;

namespace Cover
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Sum(int a, int b)  // <--- Important! Add the public keyword here
        {
            return a + b;
        }
    }
}
