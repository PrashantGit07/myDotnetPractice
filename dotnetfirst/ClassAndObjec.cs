// class ClassAndObject
// {
//     //field
//     private string name;

//     public ClassAndObject()
//     {
//         name = "";
//     }


    //properties
    // In C#, properties are special member variables within a class that control how values are accessed and assigned. Unlike traditional fields (variables), properties allow you to execute code when getting or setting their values. This additional logic provides a way to maintain control over the access to class fields and can help ensure data integrity.


//     public string Name
//     {
//         get { return name; }
//         set
//         {
//             if (!string.IsNullOrEmpty(value))
//             {
//                 name = value;
//             }
//             else
//             {
//                 System.Console.WriteLine("name can not be empty");
//             }
//         }
//     }


//     class Answe
//     {
//         public static void Main(string[] args)
//         {
//             ClassAndObject obj = new()
//             {
//                 name = "hello"
//             };
//             System.Console.WriteLine(obj.name);
//         }
//     }
// }