using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Product
    {
        [Display(Name = "Product_Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }

        [Display(Name = "Product_Description", ResourceType = typeof(Resource))]
        public string Description { get; set; }

        [Display(Name = "Product_Price", ResourceType = typeof(Resource))]
        public double Price { get; set; }

        [Display(Name = "Product_CreateDate", ResourceType = typeof(Resource))]
        public DateTime? CreateDate { get; set; }
    }
}
