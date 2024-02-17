//arrays are the data structres which store homogenius elements in a sequential manner
//in c#  , arrays are of three types :- single dimensional , multidimensional , jagged array

// using System;
// class UsingArrays
// {
//     public static void Main(string[] args)
//     {
         

//         //single dimensional arrays

//         System.Console.Write("enter size of array : ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[n];

//         System.Console.WriteLine("enter the elemens of array ->");
//         for(int i=0;i<n;i++){
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         System.Console.WriteLine("printing the array elemens -> ");

//         foreach(int elemens in arr){
//             System.Console.Write(elemens + " ");
//         }

//     }
// }





//multidimensional arrays
// using System;
// class MultiDArray{
//     public static void Main(string[] args){
//         int[,] multiD = {{1,2,3} , {4,5,6} , {7,8,6}};
        
//         // Console.WriteLine("enter the elements for 2D array ->>");
//         // for(int i=0;i<3;i++){
//         //     for(int j=0;j<3;j++){
//         //         multiD[i,j] = Convert.ToInt32(Console.ReadLine());
//         //     }
//         // }
//         for(int i=0;i<3;i++){
//             for(int j=0;j<3;j++){
//                 System.Console.Write(multiD[i,j]+ " \t ");
//             }
//             System.Console.WriteLine("\n");
//             // System.Console.WriteLine(" ");
//         }
//     }
// }