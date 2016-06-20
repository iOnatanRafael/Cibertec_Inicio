using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "This field is required")]

        public string Name { get; set; }
        [Display(Name = "Stock")]
        [Required(ErrorMessage = "This field is required")]

        public decimal Stock { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "This field is required")]

        public decimal Price { get; set; }
        public DateTime? DateRegistration { get; set; }
}
}
