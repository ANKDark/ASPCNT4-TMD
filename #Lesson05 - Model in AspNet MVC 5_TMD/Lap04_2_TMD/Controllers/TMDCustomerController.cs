using Lap04_2_TMD.Models;
using System.Web.Mvc;

    public class TMDCustomerController : Controller
    {
        static CustomerRepository_TMD listCustomer;

        public TMDCustomerController()
        {
            listCustomer = new CustomerRepository_TMD();
        }
        public ActionResult GetCustomers_TMD()
        {
            return View(listCustomer.GetCustomers_TMD());
        }
        [HttpPost]
        public ActionResult GetCustomers_TMD(string name_TMD)
        {
            return View(listCustomer.SearchCustomer_TMD(name_TMD));
        }
        public ActionResult Details_TMD(string id_TMD)
        {
            return View(listCustomer.GetCustomer_TMD(id_TMD));
        }
        public ActionResult Create_TMD()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create_TMD(Customer_TMD cus_tmd)
        {
            listCustomer.AddCustomer_TMD(cus_tmd);
            return RedirectToAction("GetCustomers_TMD");
        }
        public ActionResult Edit_TMD(string id_TMD)
        {
            return View(listCustomer.GetCustomer_TMD(id_TMD));
        }
        [HttpPost]
        public ActionResult Edit_TMD(Customer_TMD cus_tmd)
        {
            listCustomer.UpdateCustomer_TMD(cus_tmd);
            return RedirectToAction("GetCustomers_TMD");
        }

        public ActionResult Delete(string id_TMD)
        {
            listCustomer.DeleteCustomer_TMD(listCustomer.GetCustomer_TMD(id_TMD));
            return RedirectToAction("GetCustomers_TMD");
        }
    }

