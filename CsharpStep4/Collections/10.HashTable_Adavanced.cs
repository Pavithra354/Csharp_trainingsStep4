using ProductManagement;
using System;
using System.Collections;

namespace ProjectCode
{
    internal class ProductHashTableExample
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
            if (products.ContainsKey(productI
