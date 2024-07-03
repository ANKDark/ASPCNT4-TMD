using _Lesson05___Model_in_AspNet_MVC_5_TMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _Lesson05___Model_in_AspNet_MVC_5_TMD.Controllers
{
    public class TMDCustomerScaffdingController : Controller
    {
        //mockdata
        private static List<TMDCustomer> listCustomer_TMD = new List<TMDCustomer>()
            {
                new TMDCustomer
                {
                    CustomerID_TMD = 1,
                    FirstName_TMD = "Trần Minh",
                    LastName_TMD = " Đức",
                    Address_TMD = "Hà Nội",
                    YearOfBirth_TMD = 2004,
                },
                new TMDCustomer
                {
                    CustomerID_TMD = 2,
                    FirstName_TMD = "Trần Minh",
                    LastName_TMD = " Đức Đẹp Trai",
                    Address_TMD = "K22CNT4",
                    YearOfBirth_TMD = 2004,
                },
                new TMDCustomer
                {
                    CustomerID_TMD = 3,
                    FirstName_TMD = "Trần Minh",
                    LastName_TMD = " Đức Đẹp Trai",
                    Address_TMD = "K22CNT4",
                    YearOfBirth_TMD = 2004,
                },
                new TMDCustomer
                {
                    CustomerID_TMD = 4,
                    FirstName_TMD = "Trần Minh",
                    LastName_TMD = " Đức Đẹp Trai",
                    Address_TMD = "K22CNT4",
                    YearOfBirth_TMD = 2004,
                },
                new TMDCustomer
                {
                    CustomerID_TMD = 5,
                    FirstName_TMD = "Trần Minh",
                    LastName_TMD = " Đức Đẹp Trai",
                    Address_TMD = "K22CNT4",
                    YearOfBirth_TMD = 2004,
                },
            };


        // GET: TMDCustomerScaffding
        //List Customer
        public ActionResult Index()
                {
                    return View(listCustomer_TMD);
                }
        [HttpGet]
        public ActionResult Create_TMD()
        {
            var model_tmd = new TMDCustomer();
            return View();
        }
        [HttpPost]
        public ActionResult Create_TMD(TMDCustomer model)
        {
            //Thêm đối tượng khách hàng vào ds dữ liệu
            listCustomer_TMD.Add(model);
            //return View();
            //Chuyển về trang ds
            return RedirectToAction("Index");
        }

        public ActionResult Edit_TMD(int id)
        {
            var customer_tmd = listCustomer_TMD.FirstOrDefault(x => x.CustomerID_TMD == id);
            if (customer_tmd == null)
            {
                return HttpNotFound();
            }
            return View(customer_tmd);
        }

        public ActionResult Details_TMD(int id)
        {
            var customer_tmd = listCustomer_TMD.FirstOrDefault(x => x.CustomerID_TMD == id);
            if (customer_tmd == null)
            {
                return HttpNotFound();
            }
            return View(customer_tmd);
        }
        public ActionResult Delete_TMD(int? id)
        {
            var customer_tmd = listCustomer_TMD.FirstOrDefault(x => x.CustomerID_TMD == id);
            listCustomer_TMD.Remove(customer_tmd);
            return RedirectToAction("Index");
        }
    }
}