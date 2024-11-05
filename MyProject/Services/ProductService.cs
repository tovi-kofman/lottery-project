using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;

namespace MyProject.Services
{
    public class ProductService
    {
        public List<Product> Products { get; set; }
        public List<Product> GetProducts()
        {
            return Products;
        }
        public Product GetProductById(int id)
        {
            return Products.FirstOrDefault(x => x.ProductID == id);
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public ActionResult<bool> UpdateProduct(int id,Product product)
        {
            foreach (Product prod in Products)
            {
                if(prod.ProductID==id)
                {
                    Products.Insert(Products.IndexOf(prod),product);

                    //prod.ProductID = product.ProductID;
                    //prod.Picture = product.Picture;
                    //prod.Marketer = product.Marketer;
                    //prod.Name = product.Name;
                    //prod.Description = product.Description;
                    //return new OkResult();
                    return true;
                }
            }
            //return new NotFoundResult();///////////////////////
            return false;
        }
        public ActionResult<bool> RemoveProduct(int id)
        {
            return Products.Remove(Products.FirstOrDefault(x => x.ProductID == id));
        }
    }
}
