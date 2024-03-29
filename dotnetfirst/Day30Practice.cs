using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("enter string 1 :");
        string s1 = Console.ReadLine()??"";
        System.Console.Write("enter string 2 :");
        string s2 = Console.ReadLine()??"";
        

        Func<string,string,string> concate = (a,b)=>a+b;

        string output = concate(s1,s2);
        System.Console.WriteLine("Resultant string is : " + output);

    }
}