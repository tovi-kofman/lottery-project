using Microsoft.AspNetCore.Mvc;
using MyProject.DTO;
using MyProject.Entities;
using MyProject.Interface;

namespace MyProject.Services
{
    public class ProductService
    {
        //static DataContext DataContextManager { get; set; }
        readonly IDataContext _dataContext;

        public ProductService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Product> GetProducts()
        {
            return _dataContext.LoadData<Product>();
        }
        public Product GetProductById(int id)
        {
            return _dataContext.LoadData<Product>().FirstOrDefault(x => x.ProductId == id);
        }
        public bool AddProduct(Product product)
        {
            var products= _dataContext.LoadData<Product>();
            products.Add(product);
            return _dataContext.SaveData(products);
        }
        public bool UpdateProduct(int id, Product product)
        {
            var products=_dataContext.LoadData<Product>();
            foreach (Product prod in products)
            {
                if (prod.ProductId == id)
                {
                    prod.Picture = product.Picture;
                    prod.Marketer = product.Marketer;
                    prod.Name = product.Name;
                    prod.Description = product.Description;
                    return _dataContext.SaveData(products);
                }
            }
            return false;
        }
        public bool RemoveProduct(int id)
        {
            var products=_dataContext.LoadData<Product>();
            return products.Remove(products.FirstOrDefault(x => x.ProductId == id));
        }
    }
}
