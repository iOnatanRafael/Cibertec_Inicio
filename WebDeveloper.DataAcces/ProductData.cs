using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAcces
{
    public class ProductData : BaseDataAccess<Product>
    {
        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Description = "Cristal", Price=3.0, CreateDate = null },
                new Product { Id = 2, Description = "Pilsen", Price=0.0, CreateDate = DateTime.Now },
                new Product { Id = 3, Description = "Cuzqueña", Price=5.0, CreateDate = null },
                new Product { Id = 4, Description = "Sublime", Price=1.1, CreateDate = DateTime.Now },
                new Product { Id = 5, Description = "Coca Cola", Price=0.0, CreateDate = null },
                new Product { Id = 6, Description = "Inca Kola", Price=0.0, CreateDate = DateTime.Now },
                new Product { Id = 7, Description = "7Up", Price=1.5, CreateDate = null },
                new Product { Id = 8, Description = "Pepsi", Price=0.0, CreateDate = DateTime.Now },
            };
        }
    }
}
