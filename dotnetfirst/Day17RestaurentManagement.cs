// using System;
// using System.Collections.Generic;

// interface IOrderable
// {
//     Dictionary<string, double> Items { get; }
//     int Quantity { get; set; }

//     void DisplayDetails();
//     double CalculatePrice();
// }

// interface IDiscountable
// {
//     Dictionary<string, bool> ItemsForDiscount { get; }

//     double CalculateAndApplyDiscount();
// }

// public class MenuItems : IOrderable
// {
//     public double price = 0;
//     public Dictionary<string, double> Items { get; set; }
//     public int Quantity { get; set; }

//     public Dictionary<string, double> Beverages { get; set; } // Making Beverages accessible outside

//     public void DisplayDetails()
//     {
//         foreach (var item in Items)
//         {
//             Console.WriteLine("Name: " + item.Key + " Price: " + item.Value);
//         }
//         Console.WriteLine("Quantity: " + Quantity);
//         foreach (var beverages in Beverages)
//         {
//             Console.WriteLine("Available beverages: " + beverages);
//         }
//     }

//     public double CalculatePrice()
//     {


//         double totalPrice = 0;

//         foreach (var item in Items)
//         {
//             totalPrice += item.Value;
//         }

//         return totalPrice * Quantity;
//     }

// }

// class Customers
// {
//     public string? name { get; set; } // Making name accessible outside
//     public string? address { get; set; } // Making address accessible outside

//     public Dictionary<string, int> orders { get; set; } = new Dictionary<string, int>(); // Initialize orders
// }

// class Order
// {
//     public void OrdersByCustomer(Customers customers)
//     {

//         foreach (var item in customers.orders)
//         {
//             Console.WriteLine($"Item: {item.Key}, Quantity: {item.Value}");
//         }
//     }
// }

// class DiscountManager : IDiscountable
// {
//     MenuItems menuItems = new MenuItems();
//     double discount;
//     Customers customers = new Customers();

//     public Dictionary<string, bool> ItemsForDiscount => throw new NotImplementedException();

//     public double CalculateAndApplyDiscount()
//     {
//         double totalPrice = 0;

//         foreach (var item in customers.orders)
//         {
            
//             totalPrice += menuItems.Items[item.Key] * item.Value;

//             // Check if the quantity of any item exceeds 3
//             if (item.Value > 3)
//             {
                 
//                 discount += menuItems.Items[item.Key] * item.Value * 0.10;
//             }
//         }

//         // Display offer for Cold Drink
//         if (customers.orders.ContainsKey("Cold drink"))
//         {
//             Console.WriteLine("We offer cold drink of 200ml free of cost along with the ordered items");
//         }

//         return discount;
//     }

// }

// class RestaurantManagement
// {
//     public static void Main(string[] args)
//     {
//         DiscountManager discountManager = new DiscountManager();
//         Customers customers = new Customers();
//         Order order = new Order();
//         MenuItems menuItems = new MenuItems();

//         menuItems.Items = new Dictionary<string, double>
//         {
//             {"Pizza", 25.0},
//             {"Burger", 15.0},
//             {"Momos", 15.0},
//             {"Spring Rolls", 50.0}
//         };

//         Console.WriteLine("Welcome to iconic restross");
//         Console.WriteLine("These are the list of available items:");
//         foreach (var dish in menuItems.Items)
//         {
//             Console.WriteLine(dish);
//         }

//         Console.WriteLine("So! What would you like to have:");
//         string? orderThis = Console.ReadLine();

//         Console.WriteLine("How many quantity:");
//         int quantity = Convert.ToInt32(Console.ReadLine());

        
//         // Checking if the ordered item exists in the menu
//         if (menuItems.Items.ContainsKey(orderThis ?? ""))
//         {
//             Console.WriteLine("Your order is being prepared");
//         }
//         else
//         {
//             Console.WriteLine("Sorry! The dish is not available");
//             return; // Exit the program if the dish is not available
//         }

//         // Adding order to customers
//         customers.orders.Add(orderThis ?? "", quantity);

//         Console.WriteLine("Total orders given by customer:");
//         order.OrdersByCustomer(customers);

//         menuItems.Quantity = quantity;
      

//         System.Console.WriteLine("Order is being prepared");
//         order.OrdersByCustomer(customers);

//         int totalQuantity = customers.orders.Values.Sum();
//         double discount = 0;

//         if (quantity > 3)
//         {
//             discount = discountManager.CalculateAndApplyDiscount();
//             System.Console.WriteLine("Discount applied : " + discount);
//         }


//         double totalBill = menuItems.CalculatePrice() - discount;
//         Console.WriteLine($"Total bill: {totalBill}");


//     }
// }
