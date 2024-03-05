// Association means (has a) relationship between two classes
// it has two types :- aggregation and composition
// using aggregation and composition an object can communicate with another object and use the functionality of that object
// composition refers to strong bounding ex:- college has branch , means if college is removed , the branches will be removed too

// aggregation refers to weak bounding ex:- students are in college , meaans if students are removed  , then college will still be in existence


// overall we can say that we can use properties of another object without inheritence

// using System;
// class Program{
//    public static void Main(string[] args){
//         Help2 h2 = new Help2();
//         h2.h1.Display();
//         System.Console.WriteLine(h2.h1.a);
//    }
// }

// class Help1{
//         public int a =5;

//         public void Display(){
//                 System.Console.WriteLine("hello world");
//         }
// }

// class Help2{
//       public  Help1 h1 = new Help1();
// }

 

//  using System;

// class FinalClass
// {
//     public static void Main(string[] args)
//     {
//         AggregationClass2 obj2 = new AggregationClass2();
//         obj2.obj.Display();
//     }

//     class AggregationClass1
//     {
//         public int id;
//         public char grade;
//         public void Display()
//         {
//             System.Console.WriteLine("hello world");
//         }
//     }

//     class AggregationClass2
//     {
//         now to display has a relationship we can create object of above class and use its functionality
//         withour explicitly inheritence
//         public AggregationClass1 obj = new AggregationClass1();

//     }
// }