using MiniERP.Models;
using MiniERP.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MiniERP.Services
{
    public class InventoryManager : IInventoryManager
    {
        private readonly List<Product> _products = new List<Product>();
        private int _nextId = 1;
        public void AddProduct(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }
        public void UpdateQuantity(int productId, int newQuantity)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                product.Quantity = newQuantity;
            }
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public void DeleteProduct(int productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                _products.Remove(product);
            }
        }


        public Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }

    }
}