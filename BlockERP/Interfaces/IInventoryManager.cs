using MiniERP.Models;
using System.Collections.Generic;


namespace MiniERP.Interfaces
{
    public interface IInventoryManager
    {
        void AddProduct(Product product);
        void UpdateQuantity(int productId, int newQuantity);
        void DeleteProduct(int productId);
        Product GetProductById(int productId);
        List<Product> GetAllProducts();
    }

}