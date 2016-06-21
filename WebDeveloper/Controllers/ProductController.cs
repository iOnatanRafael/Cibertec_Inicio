using System.Web.Mvc;
using WebDeveloper.DataAcces;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductData _Product = new ProductData();

        // GET: Product
        public ActionResult Index()
        {
            return View(_Product.GetList());
        }

        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(Product Product)
        {
            if (ModelState.IsValid)
            {
                _Product.Add(Product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            Product Product = _Product.GetProductById(ID);
            if (Product == null)
            {
                return RedirectToAction("Index");
            }
            return View(Product);
        }

        [HttpPost]
        public ActionResult Edit(Product Product)
        {
            if (ModelState.IsValid)
            {
                _Product.Update(Product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            Product Product = _Product.GetProductById(ID);
            if (Product == null)
            {
                return RedirectToAction("Index");
            }
            return View(Product);
        }
        
        [HttpPost]
        public ActionResult Delete(Product Product)
        {
            if (_Product.Delete(Product) > 0)
                return RedirectToAction("Index");
            return View(Product);
        }
    }
}