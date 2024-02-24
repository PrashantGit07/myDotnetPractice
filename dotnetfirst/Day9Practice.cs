// using System;
// class Program
// {
//     static void Display(int[] arr)
//     {
//         int mmaxin = arr[0];
//         for (int i = 1; i < arr.Length; i++)
//         {
//             if (arr[i] > mmaxin)
//             {
//                 mmaxin = arr[i];
//             }
//         }
//         System.Console.WriteLine("minimum  : " + mmaxin);
//     }

//     public static void Main(string[] args)
//     {
//         int[] arr = {5,7,6,8,1,2,3,9,5,36,5,4};
//         Display(arr);
//     }
// }








// using System;
// class MultiDArray{
//     public static void Main(string[] args){
//         System.Console.WriteLine("enter the rows : ");
//         int r = Convert.ToInt32(Console.ReadLine());

//         System.Console.WriteLine("enter the columns  :");
//         int c = Convert.ToInt32(Console.ReadLine());

//         System.Console.WriteLine($"enter {r} rows and {c} columns values :");
//         int[,] multiArr =new int[r,c];
//         for(int i=0;i<r;i++)
//         {
//             string[] rows = Console.ReadLine().Split();
//             for(int j=0;j<c;j++)
//             {
//                 multiArr[i,j] = Convert.ToInt32(rows[j]);
//             }
//         }


//         System.Console.WriteLine("printing the array : ");
//         for(int i=0;i<r;i++)
//         {
//             for(int j=0;j<c;j++)
//             {
//                 System.Console.Write(multiArr[i,j]+"\t ");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }

// using System;
// class Program{
//     public static void Main(string[] args){
//         System.Console.WriteLine("enter the rows  :");
//         int r = Convert.ToInt32(Console.ReadLine());

//         int[][] jArr = new int[r][];

//         //taking input
//         for(int i=0;i<r;i++)
//         {
//             System.Console.WriteLine("enter number of colums for each  row i  : ");
//             int j = Convert.ToInt32(Console.ReadLine());

//             // inner array for each row
//             jArr[i] = new int[j];

//             System.Console.WriteLine("enter column values for each row : ");
//             string[] v = Console.ReadLine().Split();

//             //filling values in each row's array

//             for(int k=0;k<j;k++)
//             {
//                 jArr[i][k] = Convert.ToInt32(v[k]);
//             }

//         }

//         //printing the array
//         System.Console.WriteLine("printing the array : ");
//         for(int i=0;i<jArr.Length;i++){
//             for(int j=0;j<jArr[i].Length;j++){
//                 System.Console.Write(jArr[i][j]);
//             }
//         }
//         System.Console.WriteLine();
//     }
// }








// using System;
// using System.Collections.Generic;  

// class Program {
//     public static void Main(string[] args) {
//         int[] arr = {4, 5, 8, 9, 6, 4, 3, 7, 5, 1};
//         Console.WriteLine("Enter the target sum:");
//         int t = Convert.ToInt32(Console.ReadLine());
//         List<int> res = new List<int>();

//         for (int i = 0; i < arr.Length; i++) {
//             for (int j = i + 1; j < arr.Length; j++) {
//                 int sum = arr[i] + arr[j];  
//                 if (sum == t) {
//                     res.Add(arr[i]);
//                     res.Add(arr[j]);
//                 }
//             }
//         }

//         Console.WriteLine("Pairs that sum up to " + t);
//         for (int i = 0; i < res.Count; i += 2) {
//             Console.WriteLine( res[i] + ", " + res[i + 1] );
//         }
//     }
// }



// using System;
// class Program{
//     public static void Main(string[] args)
//     {
//         int[,] m1= {{1,2,3},{3,4,5},{6,7,8}};
//         int[,] m2= {{4,5,6},{1,2,3},{7,2,0}};

//         //checking if dimesnions are same or not\
//         int r = m1.GetLength(0);
//         int c = m1.GetLength(1);

//         int[,] res = new int[r,c];

//         //  adding the matrixes
//         for(int i=0;i<r;i++)
//         {
//             for(int j=0;j<c;j++)
//             {
//                 res[i,j] = m1[i,j]+m2[i,j];
//             }
//         }

//         //printing
//         for(int i=0;i<r;i++)
//         {
//             for(int j=0;j<c;j++){
//                 System.Console.WriteLine(res[i,j]+" ");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }



// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         int[,] mt = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };

//         //checking dimesions
//         int r = mt.GetLength(0);
//         int c = mt.GetLength(1);


//         int[,] res = new int[r,c];

//         //display original matrix
//         System.Console.WriteLine("orignial : ");
//         for(int i=0;i<r;i++)
//         {
//             for(int j=0;j<c;j++){
//                 System.Console.Write(mt[i,j]);
//             }
//         }

//         //transpose matrix
//         System.Console.WriteLine("transpose : ");
//         for(int i=0;i<r;i++){
//             for(int j=0;j<c;j++){
//                 res[j,i] = mt[i,j];
//             }
//         }

//         //display transpose
//         for(int i=0;i<r;i++){
//             for(int j=0;j<c;j++){
//                 System.Console.WriteLine(res[i,j]+" ");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }

// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         int[,] m1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//         int[,] m2 = { { 4, 5, 6 }, { 1, 2, 3 }, { 7, 2, 0 } };

//         //getting dimesions
//         int r1 = m1.GetLength(0);
//         int c1 = m1.GetLength(1);
//         int r2 = m2.GetLength(0);
//         int c2 = m2.GetLength(1);

//         //to store result
//         int[,] result = new int[r1, c2];

//         if (c1 != r2)
//         {
//             System.Console.WriteLine("can not multiply");
//         }

//         //mutiply
//         for (int i = 0; i < r1; i++)
//         {
//             for (int j = 0; j < c2; j++)
//             {
//                 for (int k = 0; k < c1; k++)
//                 {
//                     result[i, j] += m1[i, k] * m2[k, j];
//                 }
//             }
//         }
//         System.Console.WriteLine("result");
//         Display(result);
//     }
//     static void Display(int[,] matrix)
//     {
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         int[,] m1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//         //geting dimesion
//         int r = m1.GetLength(0);
//         int c = m1.GetLength(1);

//         int rsum = 0;
//         for (int i = 0; i < r; i++)
//         {
//             for (int j = 0; j < c; j++)
//             {
//                 rsum += m1[i, j];
//             }
//             System.Console.WriteLine("row :" + i + 1 + rsum);
//         }


//         int csum = 0;
//         for (int i = 0; i < r; i++)
//         {
//             for (int j = 0; j < c; j++)
//             {
//                 csum += m1[j, i];
//                 System.Console.WriteLine("column :" + j + 1 + rsum);
//             }
//         }
//     }
// }




// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {

//         int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//         int r = arr.GetLength(0);
//         int c = arr.GetLength(1);
//         //initialize the maximum array to store maximum row and column values
//         int mxarr = arr[0, 0];
//         int mxr = 0;
//         int mxc = 0;


//         for (int i = 0; i < r; i++)
//         {
//             for (int j = 0; j < c; j++)
//             {
//                 if (arr[i, j] > mxarr)
//                 {
//                     mxarr = arr[i, j];
//                     mxr = i;
//                     mxc = j;
//                 }
//             }
//         }
//         Console.WriteLine("Largest Element: " + mxarr);
//         Console.WriteLine("Position: Row " + (mxr + 1) + ", Column " + (mxc + 1));
//     }
// }
