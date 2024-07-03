using _Lesson05___Model_in_AspNet_MVC_5_TMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _Lesson05___Model_in_AspNet_MVC_5_TMD.Controllers
{
    public class TMDCustomerController : Controller
    {
        // GET: TMDCustomer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TMDCustomerDetails()
        {
            // Tạo đối tượng dữ liệu
            var customer_tmd = new TMDCustomer()
            {
                CustomerID_TMD = 1,
                FirstName_TMD = "Trần Minh",
                LastName_TMD = " Đức",
                Address_TMD = "Hà Nội",
                YearOfBirth_TMD = 2004,
        };
            ViewBag.customer_tmd = customer_tmd;
            return View();
        }

        //GET: TMDListCustomer
        public ActionResult TMDListCustomer()
        {
            var list_tmd = new List<TMDCustomer>()
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
            //ViewBag.list_tmd = list_tmd;
            return View(list_tmd);
        }
    }
}