using System;
using System.Collections.Generic;
using InventoryManagementSystem.Utils;

namespace InventoryManagementSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      InventoryManager inventoryManager = new InventoryManager();
      bool exit = false;

      while (!exit)
      {
        ShowMenu();
        int choice = InputHelper.GetValidInt("Select an option: ");

        switch (choice)
        {
          case 1:
            HandleAddProduct(inventoryManager);
            break;
          case 2:
            HandleUpdateStock(inventoryManager);
            break;
          case 3:
            HandleRemoveProduct(inventoryManager);
            break;
          case 4:
            HandleViewProducts(inventoryManager);
            break;
          case 5:
            exit = true;
            Console.WriteLine("Exiting... Goodbye!");
            break;
          default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }
      }
    }

    // Show menu function
    static void ShowMenu()
    {
      Console.WriteLine("\n--- Inventory Management System ---");
      Console.WriteLine("1. Add Product");
      Console.WriteLine("2. Update Stock");
      Console.WriteLine("3. Remove Product");
      Console.WriteLine("4. View Products");
      Console.WriteLine("5. Exit");
    }

    // Add product
    static void HandleAddProduct(InventoryManager inventoryManager)
    {
      string name = InputHelper.GetValidString("Enter product name: ");
      decimal price = InputHelper.GetValidDecimal("Enter product price: ");
      int quantity = InputHelper.GetValidInt("Enter product quantity: ");

      inventoryManager.AddProduct(name, price, quantity);
      Console.WriteLine($"Product '{name}' added successfully!\n");
    }

    // Update stock
    static void HandleUpdateStock(InventoryManager inventoryManager)
    {
      var products = inventoryManager.GetProducts();
      if (products.Count == 0)
      {
        Console.WriteLine("No products in inventory to update.\n");
        return;
      }

      HandleViewProducts(inventoryManager);
      int index = InputHelper.GetValidInt("Enter product index to update: ") - 1;

      if (index < 0 || index >= products.Count)
      {
        Console.WriteLine("Invalid product index.\n");
        return;
      }

      int newQuantity = InputHelper.GetValidInt("Enter new quantity: ");
      inventoryManager.UpdateStock(index, newQuantity);
      Console.WriteLine("Stock updated successfully!\n");
    }

    // Remove product
    static void HandleRemoveProduct(InventoryManager inventoryManager)
    {
      var products = inventoryManager.GetProducts();
      if (products.Count == 0)
      {
        Console.WriteLine("No products in inventory to remove.\n");
        return;
      }

      HandleViewProducts(inventoryManager);
      int index = InputHelper.GetValidInt("Enter product index to remove: ") - 1;

      if (index < 0 || index >= products.Count)
      {
        Console.WriteLine("Invalid product index.\n");
        return;
      }

      if (!InputHelper.ConfirmAction($"Are you sure you want to remove '{products[index].Name}'?"))
      {
        Console.WriteLine("Product removal cancelled.\n");
        return;
      }

      inventoryManager.RemoveProduct(index);
      Console.WriteLine("Product removed successfully!\n");
    }

    // View products
    static void HandleViewProducts(InventoryManager inventoryManager)
    {
      var products = inventoryManager.GetProducts();
      if (products.Count == 0)
      {
        Console.WriteLine("No products in inventory.\n");
        return;
      }

      Console.WriteLine("\nCurrent Products:");
      for (int i = 0; i < products.Count; i++)
      {
        var p = products[i];
        Console.WriteLine($"{i + 1}. Name: {p.Name}, Price: {p.Price}, Quantity: {p.Quantity}");
      }
      Console.WriteLine();
    }
  }
}
