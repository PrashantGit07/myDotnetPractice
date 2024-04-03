// using System;
// using System.Diagnostics;
// using System.Threading;

// class ThreadExample
// {
//     static object obj = new object();

//     static void CalculateFactorial(object n)
//     {
//         int num = (int)n;
//         int f = 1;
//         lock (obj)
//         {
//             for (int i = 1; i <= num; i++)
//             {
//                 f *= i;
//             }
//             Console.WriteLine("The factorial of " + num + " is -> " + f);
//         }
//     }

//     static void Display()
//     {
//         int sum = 0;
//         Console.WriteLine("This is thread 2");
//         for (int i = 0; i < 100000; i++)
//         {
//             sum += i;
//             Thread.Sleep(1);
//         }
//         Console.WriteLine("thread " + sum);
//         Console.WriteLine("Thread 2 done");
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a number: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         Stopwatch s1 = new Stopwatch();
//         Stopwatch s2 = new Stopwatch();

//         // Measure time taken by single threaded model
//         s1.Start();
//         CalculateFactorial(n);
//         Display();
//         s1.Stop();

//         Console.WriteLine("Time taken by Single threaded model: " + s1.ElapsedMilliseconds);

//         // Measure time taken by multiple threaded model
//         Thread t1 = new Thread(new ParameterizedThreadStart(CalculateFactorial));
//         Thread t2 = new Thread(new ThreadStart(Display));

//         s2.Start();
//         t1.Start(n);
//         t2.Start();

//         t1.Join();
//         t2.Join();
//         s2.Stop();

//         Console.WriteLine("Time taken by Multiple threaded model: " + s2.ElapsedMilliseconds);

//         Console.WriteLine("Main thread finished");
//     }
// }
