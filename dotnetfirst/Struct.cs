// using System;

// struct Employee{
//     public int id{get;set;}
//     public string? name{get;set;}


//     public void Display(){
//         System.Console.WriteLine("Employee id :" +id);
//         System.Console.WriteLine("employee name :" +name);
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         Employee e = new Employee();
//         e.id=12;
//         e.name="Ravi";
//         e.Display();
//     }
// }




// using System;

// // Define a struct for a book
// struct Book
// {
 
//     public string Title { get; set; }
//     public string Author { get; set; }
//     public decimal Price { get; set; }

//     // Constructor
//     public Book(string title, string author, decimal price)
//     {
//         Title = title;
//         Author = author;
//         Price = price;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create an instance of the Book struct
//         Book book = new Book("The india way", "Why Bharat matters", 12222);

//         // Display book details
//         Console.WriteLine("Book details:");
//         Console.WriteLine("Title: " + book.Title);
//         Console.WriteLine("Author: " + book.Author);
//         Console.WriteLine("Price: " + book.Price);

//         // Update the book's price
//         book.Price = 1200;

//         // Display updated price
//         Console.WriteLine("\nUpdated price:");
//         Console.WriteLine("Price: " + book.Price);
//     }
// }
