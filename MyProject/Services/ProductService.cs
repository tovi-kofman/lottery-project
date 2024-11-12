//using Microsoft.AspNetCore.Mvc;
//using MyProject.DTO;
//using MyProject.Entities;

//namespace MyProject.Services
//{
//    public class ProductService
//    {
//        //static DataContext DataContextManager { get; set; }
//        public DataContext DataContextManager = ManagerDataContext.DataContext;

//        public List<Product> GetProducts()
//        {
//            return DataContextManager.Products;
//        }
//        public Product GetProductById(int id)
//        {
//            return DataContextManager.Products.FirstOrDefault(x => x.ProductId == id);
//        }
//        public void AddProduct(Product product)
//        {
//            DataContextManager.Products.Add(product);
//        }
//        public bool UpdateProduct(int id,Product product)
//        {
//            foreach (Product prod in DataContextManager.Products)
//            {
//                if(prod.ProductId==id)
//                {
//                    prod.Picture = product.Picture;
//                    prod.Marketer = product.Marketer;
//                    prod.Name = product.Name;
//                    prod.Description = product.Description;
//                    return true;
//                }
//            }
//            return false;
//        }
//        public bool RemoveProduct(int id)
//        {
//            return DataContextManager.Products.Remove(DataContextManager.Products.FirstOrDefault(x => x.ProductId == id));
//        }
//    }
//}
