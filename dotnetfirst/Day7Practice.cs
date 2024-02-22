// Develop a C# console application that simulates a simple ATM system. The program should allow users to check their balance, deposit funds, withdraw funds (with validation to ensure they do not exceed their balance), and exit the system using switch statements for menu navigation and loop structures for validation.



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         double balance = 1000; // Initial balance
        
//         while (true)
//         {
//             Console.WriteLine("ATM Menu:");
//             Console.WriteLine("1. Check Balance");
//             Console.WriteLine("2. Deposit Funds");
//             Console.WriteLine("3. Withdraw Funds");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your choice: ");
            
//             int choice = Convert.ToInt32(Console.ReadLine());
            
//             switch (choice)
//             {
//                 case 1:
//                     Console.WriteLine($"Your balance is: ${balance}");
//                     break;
//                 case 2:
//                     Console.Write("Enter the amount to deposit: ");
//                     double depositAmount = Convert.ToDouble(Console.ReadLine());
//                     balance += depositAmount;
//                     Console.WriteLine($"${depositAmount} deposited successfully.");
//                     break;
//                 case 3:
//                     Console.Write("Enter the amount to withdraw: ");
//                     double withdrawAmount = Convert.ToDouble(Console.ReadLine());
//                     if (withdrawAmount > balance)
//                     {
//                         Console.WriteLine("Insufficient funds!");
//                     }
//                     else
//                     {
//                         balance -= withdrawAmount;
//                         Console.WriteLine($"${withdrawAmount} withdrawn successfully.");
//                     }
//                     break;
//                 case 4:
//                     Console.WriteLine("Exiting the ATM. Thank you!");
//                     Environment.Exit(0);
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }
//         }
//     }
// }







// Design a C# program for a simple inventory management system for a small store. The program should allow users to add new items to the inventory, remove items, display the current inventory, and exit the system. Use switch statements for menu navigation and loop structures for validation.


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static List<string> inventory = new List<string>();

//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("Inventory Management System:");
//             Console.WriteLine("1. Add Item to Inventory");
//             Console.WriteLine("2. Remove Item from Inventory");
//             Console.WriteLine("3. Display Inventory");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your choice: ");

//             int choice;
//             if (!int.TryParse(Console.ReadLine(), out choice))
//             {
//                 Console.WriteLine("Invalid choice. Please enter a number.");
//                 continue;
//             }

//             switch (choice)
//             {
//                 case 1:
//                     AddItem();
//                     break;
//                 case 2:
//                     RemoveItem();
//                     break;
//                 case 3:
//                     DisplayInventory();
//                     break;
//                 case 4:
//                     Console.WriteLine("Exiting the Inventory Management System. Thank you!");
//                     return;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }
//         }
//     }

//     static void AddItem()
//     {
//         Console.Write("Enter item name: ");
//         string itemName = Console.ReadLine();

//         inventory.Add(itemName);
//         Console.WriteLine($"Item '{itemName}' added to inventory.");
//     }

//     static void RemoveItem()
//     {
//         Console.Write("Enter item name to remove: ");
//         string itemName = Console.ReadLine();

//         if (!inventory.Contains(itemName))
//         {
//             Console.WriteLine("Item not found in inventory.");
//             return;
//         }

//         inventory.Remove(itemName);
//         Console.WriteLine($"Item '{itemName}' removed from inventory.");
//     }

//     static void DisplayInventory()
//     {
//         if (inventory.Count == 0)
//         {
//             Console.WriteLine("Inventory is empty.");
//             return;
//         }

//         Console.WriteLine("Current Inventory:");
//         foreach (var item in inventory)
//         {
//             Console.WriteLine($"- {item}");
//         }
//     }
// }
