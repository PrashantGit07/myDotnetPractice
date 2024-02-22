// using System;
// class Program
// {
//     public Program(int a  , int b)
//     {
//         try
//         {
//             Console.WriteLine("Enter the value of 'a' : ");
//             a = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("\nEnter the value of 'b' : ");
//             b = Convert.ToInt32(Console.ReadLine());
//             int res = a/b;
//         }
//        catch(Exception e)
//        {
//         System.Console.WriteLine(e);
//        }
//     }
//     public static void Main(string[] args)
//     {
//         Program p = new Program(10,0);
//     }
// }




//user defined exception
//we need to inherit Exception class to define user defined exception

// using System;
// class ProgramExecption:Exception{
//     public ProgramExecption(string msg):base(msg){}
// }

// class Answer{
//     public static void Display(int age)
//     {
//         if(age<18)
//         {
//             throw new ProgramExecption("bhaag yaha se");
//         }
//         else{
//             System.Console.WriteLine("Qualified to enter the club");
//         }
//     }

//     public static void Main(string[] args)
//     {
//         try{
//             System.Console.WriteLine("enter the age : ");
//             int age  = Convert.ToInt32(Console.ReadLine());
//             Display(age);
//         }
// catch(ProgramExecption p){ //we can also write it for detailed explanation of exception}
//         catch{
// System.Console.WriteLine(p);
//             System.Console.WriteLine("less than 18 not allowed here");
//         }
//         finally{
//             System.Console.WriteLine("program excuted till last line");
//         }
//     }
// }