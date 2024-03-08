// using System;
// using Microsoft.VisualBasic;

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

//     Dictionary<string, double> Beverages { get; }
//     public void DisplayDetails()
//     {
//         foreach (var item in Items)
//         {
//             System.Console.WriteLine("Name : " + item.Key + "Price : " + item.Value);
//         }
//         System.Console.WriteLine("Quantity : " + Quantity);
//         foreach (var beverages in Beverages)
//         {
//             System.Console.WriteLine("available beverages : " + beverages);
//         }
//     }

//     public double CalculatePrice()
//     {
//         System.Console.WriteLine("The price of the item is  :");

//         foreach (var itme in Items)
//         {

//             price += itme.Value;
//         }
//         return price * Quantity;
//     }
// }

// class Customers
// {
//     string? name { get; set; }
//     string? address { get; set; }

//     public Dictionary<string, int> orders { get; set; }


// }

// class Order
// {
//     public void OrdersByCustomer(Customers customers)
//     {
//         foreach (var items in customers.orders)
//         {
//             System.Console.WriteLine("Orderes placed by customer : ");
//             System.Console.WriteLine(items);
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
//         int cnt = 0;
//         foreach (var itmes in customers.orders)
//         {
//             cnt += itmes.Value;
//             if (customers.orders.ContainsKey("Cold drink"))
//             {
//                 System.Console.WriteLine("we offer cold drink of 200ml free of cost along with the ordered items");
//             }
//         }
//         if (cnt > 3)
//         {
//             discount = menuItems.CalculatePrice() * 0.10;
//         }

//         else
//         {
//             discount = 0;
//         }
//         return discount;
//     }
// }


// class RestaturentManagement
// {
//     public static void Main(string[] args)
//     {

//         DiscountManager discountManager = new DiscountManager();
//         Customers customers = new Customers();
//         Order order = new Order();
//         MenuItems menuItems = new MenuItems();

//         menuItems.Items = new Dictionary<string, double>
//        {
//         {"Pizza" , 25.0},
//         {"Burher" , 15.0},
//         {"Momos" ,15.0},
//         {"Spring Rolls" ,50.0}
//        };

//         System.Console.WriteLine("Welcome to iconic restross ");
//         System.Console.WriteLine("These are the list of available items : ");
//         foreach (var dish in menuItems.Items)
//         {
//             System.Console.WriteLine(dish);
//         }

//         System.Console.WriteLine("So! what you'd like to have :");
//         string? orderThis = Console.ReadLine();
//     }
// }