using System;
using System.Collections;

namespace ProductManagement
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - ₹{Price}";
        }
    }

    public class ProductHashTableExample
    {
        private Hashtable products;

        public ProductHashTableExample()
        {
            products = new Hashtable();
        }

        public void AddProduct(Product product)
        {
            if (!products.ContainsKey(product.Id))
                products[product.Id] = product;
            else
                Console.WriteLine("Product already exists.");
        }

        public void UpdateProduct(Product product)
        {
            if (products.ContainsKey(product.Id))
                products[product.Id] = product;
            else
                Console.WriteLine("Product not found.");
        }

        public bool ProductExists(int productId)
        {
            return products.ContainsKey(productId);
        }

        public void RemoveProduct(int productId)
        {
            if (products.ContainsKey(productId))
                products.Remove(productId);
            else
                Console.WriteLine("Product not found.");
        }

        public Product GetProductById(int productId)
        {
            if (products.ContainsKey(productId))
                return (Product)products[productId];

            Console.WriteLine("Product not found.");
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProductHashTableExample productTable = new ProductHashTableExample();

            Product p1 = new Product(101, "Laptop", 49999.99);
            Product p2 = new Product(102, "Mouse", 599.00);
            Product p3 = new Product(103, "Keyboard", 899.00);
            Product p4 = new Product(104, "Monitor", 6999.99);

            productTable.AddProduct(p1);
            productTable.AddProduct(p2);
            productTable.AddProduct(p3);
            productTable.AddProduct(p4);

            Product updatedProduct = new Product(102, "Wireless Mouse", 799.00);
            productTable.UpdateProduct(updatedProduct);

            Console.WriteLine($"Product 102 exists: {productTable.ProductExists(102)}");

            productTable.RemoveProduct(103);

            Product found = productTable.GetProductById(104);
            if (found != null)
            {
                Console.WriteLine($"Product Found: {found.Name} - ₹{found.Price}");
            }
        }
    }
}
