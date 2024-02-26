// using System;
// class Program{


//     public static void Main(string[] args)
//     {
//         int[] arr= {1,2,3,4,5,6,7,8,9,10};
//         int k=4;
//         int n = arr.Length-1;
//         RotateArray(arr , k , n);
//         System.Console.WriteLine("the rotated array is : ");
//         for(int i=0;i<n;i++){
//             System.Console.Write(arr[i]+" ");
//         }
//     }
//     static void ReverseArray(int[]arr ,int s , int e){
//         while(s<e)
//         {
//             int t = arr[s];
//             arr[s]= arr[e];
//             arr[e] = t;
//             s++;
//             e--;
//         }
//     }

//     static void RotateArray(int[] arr , int k  , int n){
//         ReverseArray(arr , 0 , k-1);
//         ReverseArray(arr , k , n-1);
//         ReverseArray(arr , 0 ,n-1);
//     }
// }





// using System;
// class Program{
//     public static void Main(string[] args){
//         int[] arr = {1,2,3,3,4,5,5,6,7,8,8,9,9};
//         RemveDuplicate(arr);
//     }
//     static void RemveDuplicate(int[] arr )
//     {   
        //we will use hashset because it stores all the elements only one
//         HashSet<int>h = new HashSet<int>();
//         int n = arr.Length;

        //we use list for dynamic array
//         List<int> li = new List<int>();

//         for(int i = 0; i<n;i++){
//             if(!h.Contains(arr[i])){
//                 h.Add(arr[i]);
//                 li.Add(arr[i]);
//             }
//         }  
//         System.Console.WriteLine("the resultant array is : ");
//         foreach(int item in li ){
//             System.Console.Write(item+" ");
//         }
//     }   
// }
//this solution requires more space
//but efficient time complexity - O(n) rather than brute fore (O(n log n))






//brute force



// using System;
// class Program{
//      public static void Main(string[] args){
//         int[] arr = {1,2,3,3,4,5,5,6,7,8,8,9,9};
//         RemoveItem(arr);
//     }
//     static void RemoveItem(int[]arr){
//         int n= arr.Length;
//         bool[] duplicate = new bool[n];

//         for(int i=0;i<n;i++){
//             if(duplicate[i]){
//                 continue;
//             }
//here we are just skipping the elment which are encountered before
//             for(int j=i+1;j<n;j++){
//                 if(arr[i]==arr[j]){
//                     duplicate[j] = true;
//                 }
//             }
//         }

//         System.Console.WriteLine("the resultant array : ");
//         for(int i=0;i<n;i++){
//             if(!duplicate[i]){
//                 System.Console.Write(arr[i]+" ");
//             }
//         }
//     }
// }



//find the missing number
//logic (sum of n numbers )  -(sum of elements presen in the array)
//n = size of the arrray

// using System;
// class Program{
//     public static void Main(string[] args){
//         int[]arr = {1,2,5,4,6,7,8};
//         int n = arr.Length;
//         int sum=0;
//         for(int i=0; i<n; i++){
//             sum+=arr[i];
//         }
//         int N = n+1;
        //i did N = n+1 because i need sum of N elements which should have been preseted in the array and n is denoting the elemts currently present in the array , so actual elements would be n+1
//         int sumOfNumbers = N*(N+1)/2;
//         int res = sumOfNumbers - sum;

//         System.Console.WriteLine("the missing number is  :" + res);
//     }
// }