
using System;
class Program{ 
    static void Main(string[] args){
        Console.WriteLine("enter the numbers : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int number = 0;

        if(number ==a || number ==b || number ==c){
            number++;
        }
        if(number==a|| number==b || number==c){
            number++;
        }
        if(number==a || number ==b || number==c){
            number++;
        }

        Console.WriteLine("the smallest number not equal to a b c is : " + number);
    }
}