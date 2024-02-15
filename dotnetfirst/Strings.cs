using System;

namespace WorkingWithString
{
    class StringClass
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "World";

            string res = String.Concat(s1, s2); // Using String.Concat() method for string concatenation
            Console.WriteLine(res);
        }
    }
}
