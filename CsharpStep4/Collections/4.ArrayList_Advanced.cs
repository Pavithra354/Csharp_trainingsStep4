using ProductManagement;
using System;
using System.Collections;

namespace ProjectCode
{
    internal class ProductArrayListExample
    {
        public ArrayList products;

        public ProductArrayListExample()
        {
            products = new ArrayList();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (((Product)products[i]).Id == product.Id)
                {
                    products[i] = product;
                    return;
                }
            }
            Console.WriteLine("Product not found.");
        }

        public bool ProductExists(int productId)
        {
            foreach (Product product in products)
            {
                if (product.Id == productId)
                    return true;
            }
            return false;
        }

        public void RemoveProduct(int productId)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (((Product)products[i]).Id == productId)
                {
                    products.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Product not found.");
        }

        public Product GetProductById(int productId)
        {
            foreach (Product product in products)
            {
                if (product.Id == productId)
                    return product;
            }
            Console.WriteLine("Product not found.");
            return null;
        }

        public void PrintAllProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

    internal class ProductProgram
    {
        static void Main(string[] args)
        {
            ProductArrayListExample inventory = new ProductArrayListExample();

            Product p1 = new Product(101, "Laptop", 45000);
            Product p2 = new Product(102, "Smartphone", 20000);
            Product p3 = new Product(103, "Tablet", 15000);

            inventory.AddProduct(p1);
            inventory.AddProduct(p2);
            inventory.AddProduct(p3);

            Product updatedP2 = new Product(102, "Smartphone Pro", 25000);
            inventory.UpdateProduct(updatedP2);

            Console.WriteLine($"Product with ID 102 exists: {inventory.ProductExists(102)}");

            inventory.RemoveProduct(103);

            Product prod = inventory.GetProductById(101);
            if (prod != null)
            {
                Console.WriteLine($"Product ID 101: {prod.Name}, ₹{prod.Price}");
            }

            Console.WriteLine("\nAll Products:");
            inventory.PrintAllProducts();
        }
    }
}