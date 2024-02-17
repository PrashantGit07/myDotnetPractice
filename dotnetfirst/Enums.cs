
//enums in c# are used to store named constants
//for example months(they are 12 - constant)    , days(they are 7 -- constant)  size( sizes are fixed)
//enums are initialized from 0 and they increament by +1;
//we can change the initialization from start and further they'll be increamented by +1

using System;
class UsingEnums
{
    public enum Season { winter, summer, spring };
    //now if we print value of winter , it will be 0 by default
    //we can change the value of winter , we can put winter=4, and further summer will be 5 , spring = 6 


    public enum Season2 { winter = 10, summer, spring };

    public static void Main()
    {
        int x = (int)Season.winter;
        int y = (int)Season.spring;
        int z = (int)Season.summer;

        System.Console.WriteLine("before changing initialization (default value) -->>>");
        System.Console.WriteLine("winter : " + x);
        System.Console.WriteLine("summer : " + z);
        System.Console.WriteLine("spring : " + y);

        System.Console.WriteLine("after changing initialization -->>>");
        int a = (int)Season2.winter;
        int b = (int)Season2.spring;
        int c = (int)Season2.summer;

        System.Console.WriteLine("winter : " + a);
        System.Console.WriteLine("spring : " + c);
        System.Console.WriteLine("summer : " + b);

    }
}