// using System;
// using System.Runtime.ConstrainedExecution;
// class Customer
// {
//     public Queue<string> c = new Queue<string>();

//     public void AddCustomerInQueue(string customer)
//     {
//         c.Enqueue(customer);
//         System.Console.WriteLine(customer + " added to queue");
//     }

//     public string FirstCustomer()
//     {
//         if (c.Count > 0)
//         {
//             return c.Peek();
//         }
//         else
//         {
//             System.Console.WriteLine("Queue is empty");
//             return null??"";
//         }
//     }

//     public bool isQueueEmpty()
//     {
//         return c.Count == 0;
//     }

//     public int QueueLength()
//     {
//         return c.Count;
//     }

//     public void ProcessCustomer()
//     {
//         if (c.Count > 0)
//         {
//             string customerName = c.Dequeue();
//             System.Console.WriteLine("processing customer ticket for : " + customerName);
//         }
//         else
//         {
//             System.Console.WriteLine("The queue is empty");
//         }
//     }

//     public void DisplayCustomerDetails()
//     {
//         if (c.Count > 0)
//         {
//             System.Console.WriteLine("Current Queue : ");
//             foreach (string item in c)
//             {
//                 System.Console.WriteLine(item);
//             }
//         }
//         else
//         {
//             System.Console.WriteLine("Queue is empty");
//         }
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Customer customer = new Customer();
//         customer.AddCustomerInQueue("Rohan");
//         customer.AddCustomerInQueue("Rohit");
//         customer.AddCustomerInQueue("Akash");
//         customer.AddCustomerInQueue("Sonu");
//         customer.AddCustomerInQueue("Shivam");


//         System.Console.WriteLine("Displaying customer details...");
//         customer.DisplayCustomerDetails();

//         System.Console.WriteLine("First customer in queue: " + customer.FirstCustomer());

//         customer.ProcessCustomer();
//         customer.ProcessCustomer();
//         customer.ProcessCustomer();

//         customer.DisplayCustomerDetails();

//         System.Console.WriteLine("Total Customers in Queue: " + customer.QueueLength());

//     }
// }


// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main(string[] args)
//     {

//         Dictionary<string , int > d = new Dictionary<string , int >
//         {
//           {"Rohan" , 45},
//           {"Akash" , 40},
//           {"Ravi" , 66},
//           {"Shiv" , 85},
//         };
//         var key = d.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
//         var resulut = key.Reverse().ToDictionary(x => x.Key, x => x.Value);
//         Console.WriteLine("Reversed d:");
//         foreach (var itme in resulut)
//         {
//            System.Console.WriteLine("key : " + itme.Key);
//            System.Console.WriteLine("Value : " + itme.Value);
//         }

//     }
// }





//Phone directory system
// class PhoneDirectory
// {
//     SortedDictionary<string, int> contactList = new SortedDictionary<string, int>
//     {
//          {"Aman", 45465646},
//             {"Ravi", 454685226},
//             {"Bhuvan", 123456},
//             {"Mohan", 415236},
//             {"Sita", 789456},
//             {"Ram", 987654},
//             {"Gita", 654321},
//             {"Shyam", 654789},
//             {"Kiran", 951753},
//             {"Anita", 147258},
//             {"Rahul", 258963},
//             {"Komal", 369852},
//             {"Amit", 741852},
//             {"Pooja", 963258},

//     };


//     public void DisplayContactDetails()
//     {

//         foreach (var contact in contactList)
//         {
//             System.Console.WriteLine("Name : " + contact.Key);
//             System.Console.WriteLine("Contact Number : " + contact.Value);
//         }
//     }

//     public void AddContact()
//     {
//         System.Console.WriteLine("Enter the credentials :");
//         string contactName = Console.ReadLine() ?? "";
//         int contactNumber = Convert.ToInt32(Console.ReadLine());

//         contactList.Add(contactName, contactNumber);
//     }

//     public void RemoveCOntact()
//     {
//         System.Console.WriteLine("Enter the name and number of the contact you want to remove");
//         string contactName = Console.ReadLine() ?? "";
//         int number = Convert.ToInt32(Console.ReadLine());
//         if (contactList.Count > 0)
//         {
//             if (contactList.ContainsKey(contactName) && contactList[contactName] == number)
//             {

//                 contactList.Remove(contactName);
//                 System.Console.WriteLine("Contact removed successfully");
//             }
//             else
//             {
//                 System.Console.WriteLine("Invalid input");
//             }
//         }
//         else
//         {
//             System.Console.WriteLine("No contact found");
//         }
//     }


//     public void UpdateContact()
//     {
//         System.Console.WriteLine("Enter the name and number of the contact you want to Update");
//         string contactName = Console.ReadLine() ?? "";

//         System.Console.WriteLine("Enter the updated name : ");
//         string updatedNme = Console.ReadLine() ?? " ";

//         Console.WriteLine($"Enter the updated number for {contactName}:");
//         int updatedNumber = Convert.ToInt32(Console.ReadLine());


//         if (contactList.ContainsKey(contactName))
//         {
//             contactName = updatedNme;
//             contactList.Remove(contactName);
//             contactList.Add(updatedNme, updatedNumber);
//         }
//     }
//     public static void Main(string[] args)
//     {
//         PhoneDirectory phoneDirectory = new PhoneDirectory();
//         phoneDirectory.DisplayContactDetails();

//         //Adding new contact
//         System.Console.WriteLine("What you want to do  :");
//         System.Console.WriteLine("1 - add contact to phone directory");
//         System.Console.WriteLine("2- remove contact from phone directory");
//         System.Console.WriteLine("3- update existing contact information");
//         System.Console.WriteLine("4- Nothing");
//         int choice = Convert.ToInt32(Console.ReadLine());

//         switch (choice)
//         {
//             case 1:
//                 phoneDirectory.AddContact();
//                 break;
//             case 2:
//                 phoneDirectory.RemoveCOntact();
//                 break;
//             case 3:
//                 phoneDirectory.UpdateContact();
//                 break;

//             default:
//                 System.Console.WriteLine("Exited");
//                 break;
//         }
//     }
// }








class TaskScheduler
{
    LinkedList<string> tasks = new LinkedList<string>();
    public void AddTask()
    {
        System.Console.WriteLine("Enter the tasks one by one :");
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Enter the task " + i + " :");

            string task = Console.ReadLine() ?? " ";
            tasks.AddFirst(task);
        }
    }

    public void DisplyTasks()
    {
        foreach (string task in tasks)
        {
            System.Console.WriteLine("task " + task);
        }
    }
    public void UpdateTaskPriority()
    {

        System.Console.WriteLine("Entering task priority :");
        string taskPriority = Console.ReadLine() ?? " ";
        tasks.AddLast(taskPriority);
    }

    public void RemoveTask()
    {
        System.Console.WriteLine("Enter the task to remove : ");
        string TaskToRemove = Console.ReadLine() ?? " ";

        if (tasks.Find(TaskToRemove) != null)
        {
            tasks.Remove(TaskToRemove);
            System.Console.WriteLine("The task has been removed");
        }
        else
        {
            System.Console.WriteLine("Task was not found");
        }
    }
    public static void Main(string[] args)
    {
        TaskScheduler taskScheduler = new TaskScheduler();

        while (true)
        {
            System.Console.WriteLine("What you want to do : ");
            System.Console.WriteLine("1 -  Add a new task");
            System.Console.WriteLine("2 - Remove a task");
            System.Console.WriteLine("3 - Update the task");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    taskScheduler.AddTask();
                    taskScheduler.DisplyTasks();
                    break;
                case 2:
                    taskScheduler.RemoveTask();
                    break;
                case 3:
                    taskScheduler.UpdateTaskPriority();
                    break;
                default:
                    System.Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}