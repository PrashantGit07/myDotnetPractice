// using System;

// delegate int Calculator(int a, int b);
// class Delegates
// {

//     public static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public static int Multiply(int a, int b)
//     {
//         return a * b;
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Calculator c1 = new Calculator(Delegates.Add);
//         Calculator c2 = new Calculator(Delegates.Multiply);

//         System.Console.WriteLine(c1(20, 30));
//         System.Console.WriteLine(c2(15, 25));
//     }
// }



//delegates are function pointers or reference of methods , they help us to treat methods in c# as first class citizens
//using delegates , we can excute   method of a class from another class

// using System;

// class UsingDelegates
// {
//     public delegate int Calculate(int a, int b);

//     public static void Main(string[] args)
//     {
//         Calculate del = Add;
//         Program.ExcuteDelegate(del);
//     }
//     public static int Add(int x, int y)
//     {
//         return x + y;
//     }
// }

// class Program
// {
//     public static void ExcuteDelegate(UsingDelegates.Calculate del)
//     {
//         System.Console.WriteLine(del(4, 5));
//     }
// }



//we can also excute some small line of code with the help of delegates withou creating a method , it is called anonymous method

// using System;
// class Program{
//     public delegate void Display(string s);
//     public static void Main(string[] args)
//     {
//         Display d = delegate(string s){System.Console.WriteLine(s);};
//         //we can use lambda expression here as well
//         d("hello");
//         Display d2 = s=>{System.Console.WriteLine(s);};
//         d2("World");

//     }
// }


//Func - it is genreic delegate which represents a method takes number of paramters as input type and one parameter as return type , 
// class Program{
//     public static void Main(string[] args)
//     {
//         Func<int,string> f = Add;
//         System.Console.WriteLine(f(2));
//     }

//     public static string Add(int a){
//         return ("hello"+a);
//     }
// }



//Action - it is genreic delegate which represents a method that takes number of parameters and no return type

// class Program{
//     public static void Main(string[] args)
//     {
//         Action<string>ac = Display;
//         ac("Healthy Life"+" ");
//     }

//     public static void Display(string s){
//         System.Console.WriteLine("Happy Day"+s);
//     }
// }