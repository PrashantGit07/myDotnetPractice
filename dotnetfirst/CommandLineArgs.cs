// using System;
// class Program{
//     static void Main(string[] args){
//         if(args.Length<1){
//             System.Console.WriteLine("exit");
//             return;
//         }

//         int n1 = int.Parse(args[0]);
//         int n2 = int.Parse(args[1]);


//         int  res = n1*n2;

//         System.Console.WriteLine("the answer is : " + res);
//     }
// }


// using System;
// class Program{
//     public static void Main(string[] args){
//         int[] arr = {-2,1,-3,4,-1,2,1,-5,4};
// // largest subarray with maximum sum;
// // kadane's algorithm 

//         int res = LargestSubArray(arr);
//         System.Console.WriteLine("the largest sum of a subarray : ");
//         System.Console.WriteLine(res);
//     }

//     static int LargestSubArray(int[] arr){
//         int sum=arr[0];
//         int mx = arr[0];

//         for(int i=1;i<arr.Length;i++){
//             sum+=arr[i];
//             mx=  Math.Max(mx , sum);
//             if(sum<0){
//                sum= 0;
//             }

//         }
//         return mx;
//     }
// }



// reversing the array with simple approach

// using System;
// class Program{
//     static void Main(string[] args){
//         int[] arr = {1,2,3,4,5,6,7,8,9,10,11};

//         for(int i=arr.Length-1 ; i>=0;i--){
//             System.Console.Write(arr[i]+" ");
//         }
//     }
// }


// find maximum and minimum number from array

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

//         int min = int.MaxValue;
//         int max = int.MinValue;

//         for(int i=0;i<arr.Length;i++){
//             if(arr[i] < min){
//                 min = arr[i];
//             }

//             if(arr[i] > max){
//                 max = arr[i];
//             }
//         }

//         System.Console.WriteLine("maximum value: " + max);
//         System.Console.WriteLine("minimum value: " + min);
//     }
// }



// roatate array from k positions

// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//          int[] arr = {1,2,3,4,5,6,7,8,9,10,11};
//          System.Console.WriteLine("enter the position u want to rotate :");
//          int k = Convert.ToInt32(Console.ReadLine());

//          RotateFromK(arr , k);

//          for(int i=0;i<arr.Length;i++){
//             System.Console.Write(arr[i]+" ");
//          }
//     }

//     //function to reverse the array

//     static void ReverseArray(int[] arr, int s, int e){
//         while(s<e){
//             int t = arr[s];
//             arr[s] = arr[e];
//             arr[e] = t;
//             s++;
//             e--;
//         }
//     }


//     //now rotation from k position 
//     static void RotateFromK(int[]arr , int k){
//         int n = arr.Length-1;

//         //make sure value of k is in range of array size
//         k = k%n;
//         //first we will reverse the whole array

//         ReverseArray(arr ,0 ,n );
//         //reverse fisrt k elements

//         ReverseArray(arr , 0 , k-1);

//         //reverse remaining elements
//         ReverseArray(arr , k , n);
//     }
// }




//remove duplicate elements

//in c++ i use unordered map , here i use dictionary because c# does not support unorderedmap

using System;
class Program{

    static void Main(string[] args){
        int[] arr = {1,2,3,1,2,3,4,4,5,9};
        int[] res = RemoveDuplicates(arr);

        // Array.Reverse
        System.Console.WriteLine("this is our input arra -> [1,2,3,1,2,3,4,4,5,9]");
        for(int i=0;i<res.Length;i++){
            System.Console.Write( res[i]+" ");
        }
    }
    static int[] RemoveDuplicates(int[] arr)
    {
        Dictionary<int,bool> d = new Dictionary<int,bool>();
        List<int> l = new List<int>();

        for(int i=0;i<arr.Length;i++){
            if(!d.ContainsKey(arr[i])){
                //it checks if the element is not present in the dictionary 
                //if not it adds in it and also in the list as well
                //now we know that dictionary will store only unique elements
                d[arr[i]] = true;
                l.Add(arr[i]);
            }

            //we can do it without list as well
            if(!d.ContainsKey(arr[i])){)
        }
        return l.ToArray();
    }
}