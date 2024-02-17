using System;
// class Program
// {
//     public static int cnt = 0;

//     public Program()
//     {
//         cnt++;
//     }

//     public void Display()
//     {
//         System.Console.WriteLine(cnt);
//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int i = 0;
//         while (i < 5)
//         {
//             Program p = new Program();
//             p.Display();
//             i++;
//         }
//     }
// }


//static class --->>> we can not make instance of static class
//static class can contain only static member and static varibles/fields
//we can directly access the fields and methods of the static class directly by using (.) with the class name

// public static class SaticClass{
//     public static int a = 10;
//     public static int Display(){
//         return a*2;
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         System.Console.WriteLine(SaticClass.a);
//         System.Console.WriteLine(SaticClass.Display());
//     }
// }