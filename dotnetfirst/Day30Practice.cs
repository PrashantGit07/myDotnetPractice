// // // using System;
// // // class Program
// // // {
// // //     public static void Display()
// // //     {
// // //         System.Console.WriteLine("Thread 1 started");
// // //         for (int i = 0; i < 80; i++)
// // //         {
// // //             System.Console.WriteLine("t1 " + i);
// // //             Thread.Sleep(100);
// // //         }

// // //         System.Console.WriteLine("Thread 1 ended");
// // //     }
// // //     public static void Display2()
// // //     {
// // //         System.Console.WriteLine("Thread 2 started");
// // //         for (int i = 0; i < 80; i++)
// // //         {
// // //             System.Console.WriteLine("t2 " + i);
// // //             Thread.Sleep(100);
// // //         }

// // //         System.Console.WriteLine("Thread 2 ended");
// // //     }
// // //     public static void Main(string[] args)
// // //     {
// // //         Thread t1 = new Thread(Display);
// // //         Thread t2 = new Thread(Display2);

// // //         t1.Start();
// // //         Thread.Sleep(5000);
// // //         t1.Interrupt();
// // //         t2.Start();
// // //         // t1.Start();

// // //         t1 = new Thread(Display);

// // //         t1.Start();
// // //         Thread.Sleep(5000);
// // //         t2.Interrupt();

// // //         // System.Console.WriteLine("Starting thread 2");
// // //         // t2.Start();  --- it will give exception becuase thread is eithter running or terminated , it can not restart
// // //         t1.Join(); t2.Join();

// // //     }
// // // }



// // using System;
// // class Program
// // {
// //     // public static void Display()
// //     // {
// //     //     // System.Console.WriteLine($"Id of this thread is ->> {Environment.CurrentManagedThreadId}");
// //     //     System.Console.WriteLine($"Thread{Environment.CurrentManagedThreadId} started");
// //     //     Thread.Sleep(TimeSpan.FromSeconds(3));
// //     //     System.Console.WriteLine($"Thread{Environment.CurrentManagedThreadId} completd work");
// //     //     // System.Console.WriteLine($"Id of this another thread is ->> {Environment.CurrentManagedThreadId}");
// //     // }

// //     static void DoWork(object name)
// //     {
// //         System.Console.WriteLine("Thread is starting the work");
// //         for (int i = 0; i < 10; i++)
// //         {
// //             System.Console.WriteLine(name + " is on work ");
// //             Thread.Yield();
// //             Thread.Sleep(500);
// //         }
// //         System.Console.WriteLine("Work done");
// //     }

// //     public static void Main(string[] args)
// //     {
// //         // System.Console.WriteLine("Main thread started");
// //         // Thread t = new Thread(Display);
// //         // Thread t2 = new Thread(Display);

// //         // t.Start();
// //         // t2.Start();

// //         // t.Join();
// //         // t2.Join();
// //         // System.Console.WriteLine("Main thread ended");

// //         Thread t1 = new Thread(DoWork);
// //         Thread t2 = new Thread(DoWork);

// //         t1.Start("First thread");
// //         t2.Start("Second thread");

// //         t1.Join(); t2.Join();
// //     }
// // }


// using System;
// class Program
// {
//     public static void Display()
//     {
//         System.Console.WriteLine("Thread started with priority {0}: ", Thread.CurrentThread.Priority);
//         // Get the priority of the current thread

//         for (int i = 0; i < 50; i++)
//         {
//             Thread.Sleep(1000);   //to stop the simulation for 1 seconds
//             System.Console.WriteLine("Thread iteration : " + i);
//         }
//         System.Console.WriteLine("Thread finished");
//     }

//     static void Main(string[] args)
//     {
//         Thread t1 = new Thread(Display);

        
//         t1.Priority = ThreadPriority.AboveNormal;     // Set the priority of thread t1 to AboveNormal
//         t1.Name = "First Thread";
//         System.Console.WriteLine("Name of the thread is : " + t1.Name);


//         t1.Start();       // Start the execution of thread t1

//         System.Console.WriteLine("Main thread waiting for thread 1");

//         Thread.Sleep(2000);


      
//         if (t1.IsAlive)
//         {
//             System.Console.WriteLine("Thread t1 is still working");

//             System.Console.WriteLine("current thread -> " + Thread.CurrentThread);
//             // Get information about the currently executing thread
//         }

//         t1.Join();
//         // Wait for thread t1 to finish before continuing

//         System.Console.WriteLine("Main thread exiting");
//     }
// }