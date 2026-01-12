namespace InventoryManagementSystem

{
  public class InventoryManager {
    private List<Product> products;

    public InventoryManager() {
      products = new List<Product>();
    }

    public void AddProduct (string name, decimal price, int quantity) {
      Product newProduct = new Product(name, price, quantity);
      products.Add(newProduct);
    }

    public void UpdateStock(int productIndex, int newQuantity) 
    {
      if (productIndex >= 0 && productIndex < products.Count) {
        products[productIndex].Quantity = newQuantity;
      }
    }

    public void RemoveProduct(int productIndex) {
      if (productIndex >= 0 && productIndex < products.Count) {
        products.RemoveAt(productIndex);
      }
    }

    public List<Product> GetProducts() {
      return products;
    }
  }

}