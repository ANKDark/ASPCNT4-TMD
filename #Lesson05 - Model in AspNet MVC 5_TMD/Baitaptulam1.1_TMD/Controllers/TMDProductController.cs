using Baitaptulam1_TMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitaptulam1.1_TMD.Controllers
{
    public class TMDProductController : Controller
    {
        static ProductsRepository_TMD listProduct;

        public TMDProductController()
        {
            listProduct = new ProductsRepository_TMD();
        }

        public ActionResult GetProduct_TMD()
        {
            return View(listProduct.GetProducts_TMD());
        }

        [HttpPost]
        public ActionResult GetProduct_TMD(string name_TMD)
        {
            return View(listProduct.SearchProduct_TMD(name_TMD));
        }

        public ActionResult Details_TMD(string id_TMD)
        {
            return View(listProduct.GetProduct_TMD(id_TMD));
        }

        public ActionResult Create_TMD()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create_TMD(Product_TMD prd_tmd)
        {
            listProduct.AddProduct_TMD(prd_tmd);
            return RedirectToAction("GetCustomers_TMD");
        }

        public ActionResult Edit_TMD(string id_TMD)
        {
            return View(listProduct.GetProduct_TMD(id_TMD));
        }

        [HttpPost]
        public ActionResult Edit_TMD(Product_TMD cus_tmd)
        {
            listProduct.UpdateProduct_TMD(cus_tmd);
            return RedirectToAction("GetCustomers_TMD");
        }

        public ActionResult Delete_TMD(string id_TMD)
        {
            var product = listProduct.GetProduct_TMD(id_TMD);
            if (product != null)
            {
                listProduct.DeleteProduct_TMD(product);
            }
            return RedirectToAction("GetProduct_TMD");
        }
    }
}
