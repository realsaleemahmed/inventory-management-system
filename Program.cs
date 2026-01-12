using System;

namespace InventoryManagementSystem

{
  class Program
  {
    static void Main(string[] args)
    {
      InventoryManager inventoryManager = new InventoryManager();
      bool exit = false;

      while(!exit) {
        Console.WriteLine("Inventory Management System");
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. Update Stock");
        Console.WriteLine("3. Remove Product");
        Console.WriteLine("4. View Products");
        Console.WriteLine("5. Exit");

        Console.Write("Select an option: ");
        string choice = Console.ReadLine();
        if (!int.TryParse(choice, out int intChoice)) {
          Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
          continue;
        }

        switch(intChoice) {
          case 1:
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter product quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            inventoryManager.AddProduct(name, price, quantity);
            break;
          case 2:
            Console.Write("Enter product index to update: ");
            int productIndex = int.Parse(Console.ReadLine());
            Console.Write("Enter new quantity: ");
            int newQuantity = int.Parse(Console.ReadLine());
            inventoryManager.UpdateStock(productIndex, newQuantity);
            break;
          case 3:
            Console.Write("Enter product index to remove: ");
            int removeIndex = ixnt.Parse(Console.ReadLine());
            inventoryManager.RemoveProduct(removeIndex);
            break;
          case 4:
            List<Product> products = inventoryManager.GetProducts();
            if (products.Count == 0) {
              Console.WriteLine("No products in inventory.");
              break;
            }
            Console.WriteLine("Current Products:");
            for (int i = 0; i <= products.Count - 1; i++) {
              Product p = products[i];
              Console.WriteLine($"{i}. Name: {p.Name}, Price: {p.Price}, Quantity: {p.Quantity}");
            }
            break;
          case 5:
            exit = true;
            break;
          default:
            {
              Console.WriteLine("Invalid choice. Please try again.");
            }
        } 
      }
    }
  }
}