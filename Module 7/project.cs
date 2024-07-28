using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
   static public void Main () 
   {
    Dictionary<int, string> Store = new Dictionary<int, string>();
      char choice;
      do{
      Console.WriteLine("\n Grocery Store Options");
      Console.WriteLine("a. Populate the Grocery List");
      Console.WriteLine("b. Display the Grocery Contents");
      Console.WriteLine("c. Remove an Item"); // remove a key
      Console.WriteLine("d. Add a new item and value"); // add a new key and value
      Console.WriteLine("e. Add value to existing item"); // add a value to an existing key
      Console.WriteLine("f. Sort out grocery items"); //sort the keys in the dictionary
      Console.WriteLine("g. Exit Grocery Store"); //end program

      Console.WriteLine("\n Please enter your choice: "); //prompts the user to enter and perform any of these tasks
      choice = Char.ToLower(Console.ReadLine()[0]); 
         switch(choice)
      {
         case 'a':
            PopulateGroceryDict(Store); //Populate the grocery list with predefined items 
            break;
         case 'b':
            DisplayDictContents(Store); //Display the contents of the grocery list 
            break;
         case 'c':
            RemoveContents(Store);  //Remove a specific item from the grocery list 
            break;
         case 'd':
            AddItems(Store); //Add a new item to the grocery list 
            break;
         case 'e':
            AddValueExisting(Store); // Add a value to a current list 
            break;
         case 'f':
            SortDictionary(Store); // sort the items in the grocery list by key
            break;
         case 'g': // Exit the loop and quit the program  
            break;
         default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
      }
   } while(choice != 'g');
   Console.WriteLine("Thank you for using this Grocery Store. Come Shop Again!");  // Loop until the user chooses to quit 
}

static void PopulateGroceryDict(Dictionary<int, string> Store)
   {
      Store.Clear();
      Store.Add(2, "Milk Cartons");
      Store.Add(12, "Eggs");
      Store.Add(1, "Bread");
      Store.Add(3, "Bananas");
      Store.Add(6, "Apples");
      Store.Add(4, "Oranges");
      Store.Add(5, "Tomatoes");
      Store.Add(9, "Onions");
      Store.Add(28, "Potatoes");
      Store.Add(19, "Carrots");
      Console.WriteLine("Grocery List has been populated with items!");
   }
static void DisplayDictContents(Dictionary<int, string> Store)  // display the contebts of the grocery list 
   {
      Console.WriteLine("Grocery Store Contents:");
      
      foreach(var(key, value) in Store)
      {
         Console.WriteLine($"{key}, {value}");
      }
      
   }
static void RemoveContents(Dictionary<int, string> Store) // Remove a specific item for the list 
   {
      Console.WriteLine("Enter the quantity of the item you want to remove: ");
      int quantity = int.Parse(Console.ReadLine());
      if (Store.ContainsKey(quantity))
      {
         Store.Remove(quantity);
         Console.WriteLine("Item removed successfully.");
      }
      else
      {
         Console.WriteLine("Item not found in the dictionary.");
      }
   }
static void AddItems(Dictionary<int, string> Store)   // add a new item to the frocery list 
   {
      Console.WriteLine("Enter the quantity of the item you want to add: ");
      int quantity = int.Parse(Console.ReadLine());
      
      Console.WriteLine("Enter the name of item you want to add: ");
      string item = Console.ReadLine();
 
      Store.Add(quantity, item);
      Console.WriteLine("Item added successfully!");
      
   }
static void AddValueExisting(Dictionary<int, string> Store)
   {
      Console.WriteLine("Enter the quantity of the item you want to add to:");
      int quantity = int.Parse(Console.ReadLine());
      
      if (Store.ContainsKey(quantity))
      {
         Console.WriteLine("Enter the value you want to add to the item:");
         string value = Console.ReadLine();

         Store[quantity] += "- appended value: " + value;
         Console.WriteLine("Your new value has been added successfully.");
      }
      else
      {
         Console.WriteLine("Please enter a valid key. Item not found in dictionary.");
      }   
   }
   static void SortDictionary(Dictionary<int, string> Store) // sort and display the items in the grocery list by key 
   {
      var sortedStoreByValue = Store.OrderBy(item => item.Key).ToList();
      Console.WriteLine("Grocery Store Contents (Sorted):");
      foreach(var item in sortedStoreByValue)
      {
         Console.WriteLine($"{item.Key}-{item.Value}");
      }
   }

}
