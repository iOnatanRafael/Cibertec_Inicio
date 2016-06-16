using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAcces;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private ClientData _client = new ClientData();

        // GET: Client
        public ActionResult Index()
        {
            return View(_client.GetList());
        }

        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            if(ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Update(int ID)
        {
            Client client = _client.GetClientById(ID);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        [HttpPost]
        public ActionResult Update(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            Client client = _client.GetClientById(ID);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Delete(client);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}