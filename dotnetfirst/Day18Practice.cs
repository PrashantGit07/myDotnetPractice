// using System;

// class PublicSpecifier
// {
//     public int id { get; set; }
//     public string? name { get; set; }

//     public void Display(string? name, int id)
//     {
//         this.name = name;
//         this.id = id;
//         System.Console.WriteLine("id: " + id + " name: " + name);
//     }
// }
// class PrivateSpecifier{
//     private int id{get;set;}
//     private string? name{get;set;}


// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         PublicSpecifier publicSpecifier = new PublicSpecifier();
//         publicSpecifier.Display("John", 123);

//         PrivateSpecifier privateSpecifier = new PrivateSpecifier();
//        // privateSpecifier.id = 15;     // id is not accessible here due to its protection level
//     }
// }





// class ProtectedSpecifier{
//     protected int id{get;set;}
//     protected string? name{get;set}
// }

// class Child:ProtectedSpecifier{

//     public void SetValues(int newId , string? newName){
//         newId = id;
//         newName = name;
//     }
//     public void Display(){
//         System.Console.WriteLine("id :"+ id);
//         System.Console.WriteLine("name :" + name);
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         Child child  = new Child();

//         // child.id = 5;    --- not accssible in here due to its protection level

//         child.SetValues(15 , "Hello");
//         child.Display();
//     }
// }








//Internal members and methods are accessible within same assembly

// internal class InternalSpecifier{
//     internal void Display(){
//         System.Console.WriteLine("This is internal method");
//     }
// }
// class Answer{
//     public static void Main(string[] args){
//         InternalSpecifier internalSpecifier = new InternalSpecifier();
//         internalSpecifier.Display();
//     }
// }









//Protected Internal variables or methods are accessible within the same assembly and in the derived class of another assembly

// class ProtectedInternalSpecifier{
//     protected internal string? name{get;set;}
//     protected internal void Display(string name){
//         this.name = name;
//         System.Console.WriteLine("the name is  :" + name);
//     }
// }

// class DerivedProtectedInternalClass : ProtectedInternalSpecifier{
//     protected internal void DisplayHere(){
//         Display("Hello");
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         DerivedProtectedInternalClass derivedProtectedInternalClass = new DerivedProtectedInternalClass();

//         derivedProtectedInternalClass.DisplayHere();
//     }
// }







// using System;

// public class BankAccount
// {
//     private string accountNumber;
//     private decimal balance;

//     public int AccountNumber { get; private set; }
//     public decimal Balance { get; private set; }

//     public BankAccount(int accountNumber, decimal initialBalance)
//     {
//         AccountNumber = accountNumber;
//         Balance = initialBalance;
//     }

//     public void Deposit(decimal amount)
//     {
//         if (amount <= 0)
//         {
//             Console.WriteLine("Invalid deposit amount.");
//             return;
//         }

//         Balance += amount;
//         System.Console.WriteLine("Deposited : " + amount);
//         System.Console.WriteLine("Total : " + Balance);
//     }

//     public void Withdraw(decimal amount)
//     {
//         if (amount <= 0)
//         {
//             Console.WriteLine("Invalid withdrawal amount.");
//             return;
//         }

//         if (amount > Balance)
//         {
//             Console.WriteLine("Insufficient funds.");
//             return;
//         }

//         Balance -= amount;
//         System.Console.WriteLine("Withdraw amount : " + amount);
//         System.Console.WriteLine("Current balance :" + Balance);
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("enter your account number  :");
//         int AccountNumber = Convert.ToInt32(Console.ReadLine());


//         BankAccount account = new BankAccount(AccountNumber, 1000m);


//         System.Console.WriteLine("Account number : " + account.AccountNumber);
//         System.Console.WriteLine("Current balance : " + account.Balance);

//         System.Console.WriteLine("Enter depostit amount : ");
//         int dep = Convert.ToInt32(Console.ReadLine());
//         account.Deposit(dep);

//         System.Console.WriteLine("Enter depostit amount : ");
//         int withdraw = Convert.ToInt32(Console.ReadLine());
//         account.Withdraw(withdraw);


//         System.Console.WriteLine("Account number : " + account.AccountNumber);
//         System.Console.WriteLine("Current balance : " + account.Balance);
//     }
// }
