

// // You are tasked with creating a simple application that simulates a basic inventory management system using .NET Core.

// // The application should be able to perform the following operations:

// // 1. Add a new item to the inventory. Each item should have a unique ID, name, and quantity.
// // 2. Remove an item from the inventory using its unique ID.
// // 3. Update the quantity of an item in the inventory.
// // 4. Display all items in the inventory.

// // Please ensure to incorporate the following elements in your solution:

// // - Use 'Control Statements' to navigate through different options like adding, removing, updating, and displaying the inventory items.
// // - Handle any potential exceptions, such as trying to remove an item that doesn't exist in the inventory or updating the quantity to a negative number, using 'Exception Handling'.
// // - Use 'Collections' to store the inventory items.
// // - Organize your code into different 'Namespaces' based on the functionality, like one for handling the inventory operations and another for the main program flow.



// //Solution begins here--------------------------------------- 


// //Defining a namespace under which all related classes will be kept
// namespace InventryManagementAssesment
// {

//     //class for inventory Items and operations that to be done on items
//     class InventoryItemsClass
//     {
//         public int Id { get; set; }
//         public string? name { get; set; }
//         public int quantity { get; set; }


//         //I used a list of class type to store and access all the items effciently
//         List<InventoryItemsClass> inventoryItems = new List<InventoryItemsClass>();


//         //Method to add item in inventory
//         public void AddItemsToInventory(string name, int quantity)
//         {
//             int id = new Random().Next(10, 100);    //This line will generate a Random and  unique Id for each inventory item everytime when it is added in the list
//             InventoryItemsClass inventoryItems2 = new InventoryItemsClass
//             {
//                 Id = id + 5,
//                 name = name,
//                 quantity = quantity  
//             };
//             inventoryItems.Add(inventoryItems2);
//             System.Console.WriteLine("Item Added successfully");
//             System.Console.WriteLine("---------------------------------");  //for better readabiltiy in console

//             DisplayItemsInInventory();

//             //here i called display method because once user has added the items in the inventory , there will be a unique id of the item , so later if user wants to update or delete or search his item  , he will need Id of the element , so i will display his details once so that user can know his item's Id  ,this is how we can remove redundency without creating any inconvenience for user
//             System.Console.WriteLine("---------------------------------");

//         }


//         //Method to display items in inventory using foreach loop
//         public void DisplayItemsInInventory()
//         {
//             foreach (var inventoryItem in inventoryItems)
//             {
//                 //just for better readability in the output
//                 System.Console.WriteLine("---------------------------------");
//                 System.Console.WriteLine("Unique Id :" + inventoryItem.Id);
//                 System.Console.WriteLine("Name of the Item :" + inventoryItem.name);
//                 System.Console.WriteLine("Quantity of the Item :" + inventoryItem.quantity);
//                 System.Console.WriteLine("---------------------------------");

//             }
//         }



//         //Method to remove item from inventory based on id

//         public void RemoveItemsFromInventory()
//         {
//             System.Console.WriteLine("Enter the Id of the item you want to remove : ");
//             int id = Convert.ToInt32(Console.ReadLine());


//             //here i took a variable removeItem of class type and assigned to null initially , because i can assign it to the item which need to be removed and later using this variable (which now has the exact item that i want to remove) i can remove the item from the list

//             InventoryItemsClass removeItem = null;

//             foreach (var item in inventoryItems)
//             {
//                 if (item.Id == id)
//                 {
//                     removeItem = item;
//                     break;

//                 }
//             }

//             try
//             {

//                 if (removeItem != null)
//                 {
//                     inventoryItems.Remove(removeItem);
//                     System.Console.WriteLine(" Item Removded from inventory");
//                 }
//                 else
//                 {
//                     throw new Exception("Item not found inventory");
//                 }
//             }
//             catch (Exception e)
//             {
//                 System.Console.WriteLine(e.Message);
//             }

//         }



//         public void UpdateAnItemInInventory()
//         {
//             System.Console.WriteLine("Enter the Id of the item you want to update  :");
//             int idOfItem = Convert.ToInt32(Console.ReadLine());

//             System.Console.WriteLine("Enter the Quantity to update : ");
//             int UpdatedQuantityOfItem = Convert.ToInt32(Console.ReadLine());



//             //here i took a variable removeItem of class type and assigned to null initially , because i can assign it to the item which need to be updated and later using this variable (which now has the exact item that i want to remove) i can Update the item in the list
//             InventoryItemsClass updateItem = null;

//             foreach (var items in inventoryItems)
//             {
//                 if (items.Id == idOfItem)
//                 {
//                     updateItem = items;
//                     break;
//                 }
//             }

//             try
//             {

//                 if (updateItem != null)
//                 {
//                     if (UpdatedQuantityOfItem > 0)
//                     {
//                         updateItem.quantity = UpdatedQuantityOfItem;
//                         System.Console.WriteLine("Item updated with Quantity : " + UpdatedQuantityOfItem);
//                     }
//                     else
//                     {
//                         System.Console.WriteLine("Item can not be updated ! something went wrong");
//                     }
//                 }
//                 else
//                 {
//                     throw new Exception("Item can not be updated");
//                 }
//             }
//             catch (Exception e)
//             {
//                 System.Console.WriteLine(e.Message);
//             }
//         }

//         //Additional a functionality to let the user search any item by Id
//         public void SearchItemById()
//         {
//             System.Console.WriteLine("Enter the Id of the Item to search");
//             int IdToSearch = Convert.ToInt32(Console.ReadLine());

//             //here i am using foreach loop and checking if the id entered by user exsists in the list of items or not
//             foreach (var item in inventoryItems)
//             {
//                 if (item.Id == IdToSearch)
//                 {
//                     System.Console.WriteLine("item found in inventory :");
//                     System.Console.WriteLine("name : " + item.name);
//                     System.Console.WriteLine("Quantity : " + item.quantity);
//                 }
//             }

//         }
//     }


//     class ItemsManagerClass
//     {
//         public static void Main(string[] args)
//         {
//             System.Console.WriteLine("Welcome to Netsmartz inventory....!!");
//             InventoryItemsClass inventoryItemsClass = new InventoryItemsClass();
//             bool wantToExit = false;

//             //I am using do-while loop because it will keep asking the user if he wants to do something else and it terminates the program if user wants to exit from the inventory
//             do
//             {
//                 System.Console.WriteLine("Tell us what you want to do...");
//                 System.Console.WriteLine("1- Add Item to the inventory");
//                 System.Console.WriteLine("2 - Update item in invetory");
//                 System.Console.WriteLine("3 - delete item from inventory");
//                 System.Console.WriteLine("4 - Display items of inventory");
//                 System.Console.WriteLine("5 - Search Item by its Id");
//                 System.Console.WriteLine("6 - no! Just came here to see the place");

//                 int choice = Convert.ToInt32(Console.ReadLine());


//                 //Using control statements to let the user perform operations according to his choice and available choices
//                 switch (choice)
//                 {
//                     case 1:
//                         System.Console.WriteLine("Enter the name of the Item");
//                         string? name = Convert.ToString(Console.ReadLine());

//                         System.Console.WriteLine("Enter the Quantity of the Item");
//                         int quantity = Convert.ToInt32(Console.ReadLine());

//                         inventoryItemsClass.AddItemsToInventory(name ?? "", quantity);
//                         break;

//                     case 2:
//                         inventoryItemsClass.UpdateAnItemInInventory();
//                         break;

//                     case 3:
//                         inventoryItemsClass.RemoveItemsFromInventory();
//                         break;
//                     case 4:
//                         inventoryItemsClass.DisplayItemsInInventory();
//                         break;
//                     case 5:
//                         inventoryItemsClass.SearchItemById();
//                         break;

//                     case 6:
//                         wantToExit = true;
//                         System.Console.WriteLine("Thank You! Bye..");
//                         break;
//                     default:
//                         System.Console.WriteLine("Thanks for visit");
//                         break;


//                 }
//             }
//             while (!wantToExit);
//         }
//     }

// }
