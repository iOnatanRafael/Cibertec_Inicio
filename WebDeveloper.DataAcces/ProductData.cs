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
        public Product GetProductById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Products.FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
