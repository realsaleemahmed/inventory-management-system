# Inventory Management System

A simple console-based **Inventory Management System** built in **C#**. This project allows a user to manage products, update stock, remove products, and view current inventory from the command line.

---

## Features

- **Add Product**: Add a new product with name, price, and quantity.
- **Update Stock**: Update the quantity of an existing product.
- **Remove Product**: Remove a product from the inventory with confirmation.
- **View Products**: Display all products in the inventory with their details.
- **Input Validation**: Ensures valid input for product details and prevents negative values.

---

## Folder Structure

inventory-management-system/
│
├─ Program.cs # Main entry point and menu logic
├─ InventoryManager.cs # Handles product list and CRUD operations
├─ Product.cs # Product model (Name, Price, Quantity)
├─ Utils/
│ └─ InputHelper.cs # Helper functions for validated input
└─ Report/ # (Optional) Folder for reports or logs

yaml
Copy code

---

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or later recommended)
- Any code editor or IDE (e.g., VS Code, Visual Studio)

---

## How to Run

1. Open a terminal/PowerShell in the project folder.
2. Build the project:

```bash
dotnet build
Run the project:

bash
Copy code
dotnet run
Follow the on-screen menu to manage your inventory.

Usage Example
Select an option from the menu (1–5):

mathematica
Copy code
Inventory Management System
1. Add Product
2. Update Stock
3. Remove Product
4. View Products
5. Exit
Select an option:
```
Follow the on-screen menu to manage your inventory.

## Usage Example

```
Copy code
Enter product name: Laptop
Enter product price: 1200.50
Enter product quantity: 10
```

```
Copy code
1. Name: Laptop, Price: 1200.50, Quantity: 10
Notes
Input is validated to prevent negative prices or quantities.

All products are stored in memory; data is not persistent across runs.

The project is designed to be modular and easily extendable.

Future Improvements
Save products to a database or file for persistence.

Add search functionality to find products quickly.

Implement categories and sorting by price or quantity.

Add a graphical user interface (GUI) for better usability.

Author
Saleem Ahmed
Email: saleemkhanx001@gmail.com
