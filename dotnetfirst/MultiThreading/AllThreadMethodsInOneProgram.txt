using System;
class Program
{
    public static void Display()
    {
        System.Console.WriteLine("Thread started with priority {0}: ", Thread.CurrentThread.Priority);
        // Get the priority of the current thread , which i have defined below in the main method

        for (int i = 0; i < 50; i++)
        {
            Thread.Sleep(1000);   //to stop the simulation for 1 seconds
            System.Console.WriteLine("Thread iteration : " + i);
        }
        System.Console.WriteLine("Thread finished");
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(Display);

        t1.Priority = ThreadPriority.AboveNormal;     // Set the priority of thread t1 to AboveNormal
        t1.Name = "First Thread";
        System.Console.WriteLine("Name of the thread is : " + t1.Name);


        t1.Start();       // Start the execution of thread t1

        System.Console.WriteLine("Main thread waiting for thread 1");

        Thread.Sleep(2000);

        if (t1.IsAlive)
        {
            System.Console.WriteLine("Thread t1 is still working");

            System.Console.WriteLine("current thread -> " + Thread.CurrentThread);
            // Get information about the currently executing thread
        }

        t1.Join();
        // Wait for thread t1 to finish before continuing

        System.Console.WriteLine("Main thread exiting");
    }
}


Thread.Abort() & Thread.interrupt()   -->> we generally do not use these methods because they may lead to inconsistent results and memory leaks , we either use with caution or do not use it completely









Output - 
---------


Name of the thread is : First Thread
Thread started with priority AboveNormal: 
Main thread waiting for thread 1
Thread iteration : 0
Thread iteration : 1
Thread t1 is still working
current thread -> System.Threading.Thread
Thread iteration : 2
Thread iteration : 3
Thread iteration : 4
Thread iteration : 5
Thread iteration : 6
Thread iteration : 7
Thread iteration : 8
Thread iteration : 9
Thread iteration : 10
Thread iteration : 11
Thread iteration : 12
Thread iteration : 13
Thread iteration : 14
Thread iteration : 15
Thread iteration : 16
Thread iteration : 17
Thread iteration : 18
Thread iteration : 19
Thread iteration : 20
Thread iteration : 21
Thread iteration : 22
Thread iteration : 23
Thread iteration : 24
Thread iteration : 25
Thread iteration : 26
Thread iteration : 27
Thread iteration : 28
Thread iteration : 29
Thread iteration : 30
Thread iteration : 31
Thread iteration : 32
Thread iteration : 33
Thread iteration : 34
Thread iteration : 35
Thread iteration : 36
Thread iteration : 37
Thread iteration : 38
Thread iteration : 39
Thread iteration : 40
Thread iteration : 41
Thread iteration : 42
Thread iteration : 43
Thread iteration : 44
Thread iteration : 45
Thread iteration : 46
Thread iteration : 47
Thread iteration : 48
Thread iteration : 49
Thread finished
Main thread exiting