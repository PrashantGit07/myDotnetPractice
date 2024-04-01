// using System;
// class Program
// {
//     public static void Display()
//     {
//         System.Console.WriteLine("Thread 1 started");
//         for (int i = 0; i < 80; i++)
//         {
//             System.Console.WriteLine("t1 " + i);
//             Thread.Sleep(100);
//         }

//         System.Console.WriteLine("Thread 1 ended");
//     }
//     public static void Display2()
//     {
//         System.Console.WriteLine("Thread 2 started");
//         for (int i = 0; i < 80; i++)
//         {
//             System.Console.WriteLine("t2 " + i);
//             Thread.Sleep(100);
//         }

//         System.Console.WriteLine("Thread 2 ended");
//     }
//     public static void Main(string[] args)
//     {
//         Thread t1 = new Thread(Display);
//         Thread t2 = new Thread(Display2);

//         t1.Start();
//         Thread.Sleep(5000);
//         t1.Interrupt();
//         t2.Start();
//         // t1.Start();

//         t1 = new Thread(Display);

//         t1.Start();
//         Thread.Sleep(5000);
//         t2.Interrupt();
       
//         // System.Console.WriteLine("Starting thread 2");
//         // t2.Start();  --- it will give exception becuase thread is eithter running or terminated , it can not restart
//         t1.Join(); t2.Join();

//     }
// }



using System;
class Program
{
    public static void Display()
    {
        // System.Console.WriteLine($"Id of this thread is ->> {Environment.CurrentManagedThreadId}");
        System.Console.WriteLine($"Thread{Environment.CurrentManagedThreadId} started");
        Thread.Sleep(TimeSpan.FromSeconds(3));
        System.Console.WriteLine($"Thread{Environment.CurrentManagedThreadId} completd work");
        // System.Console.WriteLine($"Id of this another thread is ->> {Environment.CurrentManagedThreadId}");
    }
    
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("Main thread started");
        Thread t = new Thread(Display);
        Thread t2 = new Thread(Display);
        
        t.Start();
        t2.Start();

        t.Join();
        t2.Join();
        System.Console.WriteLine("Main thread ended");
    }
}