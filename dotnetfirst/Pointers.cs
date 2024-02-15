//pointers in c# allow you to directly ,manipulate the memory address by providing a low level memory access.
//the directly points to the memory location of a variable
// int* ptr   -->> here ptr is the pointer to integer variable
//to access-->> int v = *ptr , it will point to the memory address of ptr and access the value at that location


//they directly manipulate the memory that can lead to unsafe excution
//pointers can be null
//pointets bypass safety mechanism of c# , we have to explicitly allocate and deallocate the memory

// using System;
// class Program
// {
//     public static unsafe void Main(string[] args)
//     {
//         int v = 10;
//         int* ptr = &v;
//         Console.WriteLine((int)ptr);
//     }
// }