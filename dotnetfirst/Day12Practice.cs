// using System;
// class BankManagement
// {

//     private int AccountNumber { get; set; }
//     public string? name { get; set; }
//     public int balance { get; set; }

//     public string? AccountHolderName{get;set;}
//     public void Deposit(double amount)
//     {
//         System.Console.Write(amount + " credited to the account " + AccountNumber + "\n");
//     }

//     public void Withdraw(double amount)
//     {
//         System.Console.Write(amount + " debited from the account " + AccountNumber + "\n");
//     }

//     public BankManagement(int AccountNumber , string AccountHolderName)
//     {   
//         System.Console.WriteLine("Account holder name : "+AccountHolderName);
//         System.Console.WriteLine("Your account number is :" + AccountNumber);
//     }
//     public void DisplayData(string name, int balance, int AccountNumber)
//     {   
//         // this.AccountHolderName = AccountHolderName;
//         this.AccountNumber = AccountNumber;


//         // System.Console.WriteLine("Account Holder :" + AccountHolderName+"\n");
//         System.Console.WriteLine("Account number : " + AccountNumber + "\n");
//         System.Console.WriteLine("Account holder : " + name + "\n");
//         System.Console.WriteLine("current amount : " + balance + "\n");

//     }


// }

// class DetailsOfCustomer
// {
//     public static void Main(string[] args)
//     {
//         System.Console.WriteLine("welcome to bank of netsmartz");
//         System.Console.WriteLine("enter your name  :");
//         string name = System.Console.ReadLine() ?? " ";

//         System.Console.WriteLine();

//         System.Console.WriteLine("Account created successfully");


//         BankManagement customer = new BankManagement(1234 , name);

//         System.Console.WriteLine();


//         System.Console.WriteLine("current banking details --->>>"+"\n");
//         customer.DisplayData(name, 0, 1234);



//         System.Console.WriteLine("enter the amount you want to deposit :"+"\n");
//         int amount = Convert.ToInt32(Console.ReadLine());


//         customer.Deposit(amount);

//         System.Console.WriteLine();

//         customer.DisplayData(name, amount, 1234 );

//         System.Console.WriteLine("enter the amount you want to withdraw :" + "\n");
//         int withdraw = Convert.ToInt32(Console.ReadLine());


//         if (withdraw == 0)
//         {
//             System.Console.WriteLine("insufficient balance");
//         }
//         else
//         {
//             customer.Withdraw(withdraw);
//             int remainingBalance = amount-withdraw;
//             customer.DisplayData(name, remainingBalance, 1234);

//         }
//     }
// }




// // This code implements a basic banking management system with the following features:

// // Allows users to create an account with a name and an account number.
// // Supports deposit and withdrawal operations.
// // Displays current account details such as account number, account holder's name, and balance.
// // Checks for sufficient balance before allowing withdrawals.



// using System;
// using System.Collections.Generic;

// class BankAccount
// {
//     private static int NextAccountNumber = 1000;

//     public int AccountNumber { get; }
//     public string AccountHolderName { get; }
//     public int Balance { get; private set; }

//     public BankAccount(string accountHolderName)
//     {
//         AccountHolderName = accountHolderName;
//         AccountNumber = NextAccountNumber++;
//         Console.WriteLine("Account created successfully.");
//         Console.WriteLine($"Your account number is: {AccountNumber}");
//     }

//     public void Deposit(int amount)
//     {
//         Balance += amount;
//         Console.WriteLine($"{amount} credited to the account {AccountNumber}");
//         DisplayAccountDetails();
//     }

//     public bool Withdraw(int amount)
//     {
//         if (amount > Balance)
//         {
//             Console.WriteLine("Insufficient balance.");
//             return false;
//         }

//         Balance -= amount;
//         Console.WriteLine($"{amount} debited from the account {AccountNumber}");
//         DisplayAccountDetails();
//         return true;
//     }

//     public void DisplayAccountDetails()
//     {
//         Console.WriteLine("Account details:");
//         Console.WriteLine($"Account Number: {AccountNumber}");
//         Console.WriteLine($"Account Holder: {AccountHolderName}");
//         Console.WriteLine($"Current Balance: {Balance}");
//         Console.WriteLine();
//     }
// }

// class BankManager
// {
//     public static List<BankAccount> accounts = new List<BankAccount>();

//     public static void Manage()
//     {
//         Console.WriteLine("Welcome, Manager!");
//         foreach (var account in accounts)
//         {
//             account.DisplayAccountDetails();
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to Bank of Netsmartz");
//         Console.WriteLine("Are you a Customer or a Manager?");
//         Console.WriteLine("1. Customer");
//         Console.WriteLine("2. Manager");
//         int choice = Convert.ToInt32(Console.ReadLine());

//         switch (choice)
//         {
//             case 1:
//                 Console.WriteLine("1. New User");
//                 Console.WriteLine("2. Existing User");
//                 int userType = Convert.ToInt32(Console.ReadLine());

//                 switch (userType)
//                 {
//                     case 1:
//                         Console.WriteLine("Enter your name:");
//                         string userName = Console.ReadLine()??"";
//                         BankAccount newUser = new BankAccount(userName);
//                         BankOperations(newUser);
//                         break;

//                     case 2:
//                         Console.WriteLine("Enter your account number:");
//                         int existingAccountNumber;
//                         if (int.TryParse(Console.ReadLine(), out existingAccountNumber))
//                         {
//                             BankAccount existingUser = FindAccount(existingAccountNumber);
//                             if (existingUser != null)
//                             {
//                                 BankOperations(existingUser);
//                             }
//                             else
//                             {
//                                 Console.WriteLine("Account not found.");
//                             }
//                         }
//                         else
//                         {
//                             Console.WriteLine("Invalid account number.");
//                         }
//                         break;

//                     default:
//                         Console.WriteLine("Invalid choice.");
//                         break;
//                 }
//                 break;

//             case 2:
//                 BankManager.Manage();
//                 break;

//             default:
//                 Console.WriteLine("Invalid choice.");
//                 break;
//         }
//     }

//     static void BankOperations(BankAccount user)
//     {
//         Console.WriteLine("1. Deposit");
//         Console.WriteLine("2. Withdraw");
//         int operation;
//         if (int.TryParse(Console.ReadLine(), out operation))
//         {
//             switch (operation)
//             {
//                 case 1:
//                     Console.WriteLine("Enter amount to deposit:");
//                     int depositAmount;
//                     if (int.TryParse(Console.ReadLine(), out depositAmount))
//                     {
//                         user.Deposit(depositAmount);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid amount.");
//                     }
//                     break;

//                 case 2:
//                     Console.WriteLine("Enter amount to withdraw:");
//                     int withdrawAmount;
//                     if (int.TryParse(Console.ReadLine(), out withdrawAmount))
//                     {
//                         user.Withdraw(withdrawAmount);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid amount.");
//                     }
//                     break;

//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     break;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid operation.");
//         }
//     }

//     static BankAccount? FindAccount(int accountNumber)
//     {
//         foreach (var account in BankManager.accounts)
//         {
//             if (account.AccountNumber == accountNumber)
//             {
//                 return account;
//             }
//         }
//         return null;
//     }
// }






using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Technology { get; set; }
    public int EmployeeId { get; private set; }

    private static int nextId = 1;
      
    public Employee(string name, int age, string address, string technology)
    {
        Name = name;
        Age = age;
        Address = address;
        Technology = technology;
        EmployeeId = nextId++;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Welcome {0} to Netsmartz", Name);
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Technology: " + Technology);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Netsmartz");

        List<Employee> employees = new List<Employee>();

        while (true)
        {
            Console.WriteLine("Please submit employee details or type 'exit' to finish:");
            Console.Write("Name: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            if (name.ToLower() == "exit")
                break;

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Address: ");
            string address = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Technology: ");
            string technology = Console.ReadLine()?.Trim() ?? "";

            // Create an employee object
            Employee employee = new Employee(name, age, address, technology);
            employees.Add(employee);
        }

        // Display employee details
        Console.WriteLine("\nEmployee Details:");
        foreach (var employee in employees)
        {
            employee.DisplayEmployeeDetails();
            Console.WriteLine();
        }
    }
}
