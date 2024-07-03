using Lap04_TMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lap04_TMD.Controllers
{
    public class Customer_TMDController : Controller
    {
        // GET: Customer_TMD
        public ActionResult CustomerDetail()
        {
            Customer_TMD cus_tmd = new Customer_TMD()
            {
                CustomerId_TMD = "2210900014",
                FullName_TMD = "Trần Minh Đức",
                Address_TMD = "Hà Nội",
                Email_TMD = "dinhhoangducdbp2004@gmail.com",
                Phone_TMD = "0855312279",
                Balance_TMD = 100000000
            };
            return View(cus_tmd);
        }

        public ActionResult CustomerList()
        {
            List<Customer_TMD> listcustomer_tmd = new List<Customer_TMD>(){
                new Customer_TMD()
                {
                    CustomerId_TMD = "2210900014",
                    FullName_TMD = "Trần Minh Đức",
                    Address_TMD = "Hà Nội",
                    Email_TMD = "dinhhoangducdbp2004@gmail.com",
                    Phone_TMD = "0855312279",
                    Balance_TMD = 100000000
                },
                new Customer_TMD()
                {
                    CustomerId_TMD = "KH002",
                    FullName_TMD = "Đỗ Thị Cúc",
                    Address_TMD = "Hà Nội",
                    Email_TMD = "cucdt@gmail.com",
                    Phone_TMD = "0986.767.444",
                    Balance_TMD = 2200000
                },
                new Customer_TMD()
                {
                    CustomerId_TMD = "KH003",
                    FullName_TMD = "Nguyễn Tuấn Thắng",
                    Address_TMD = "Nam Định",
                    Email_TMD = "thangnt@gmail.com",
                    Phone_TMD = "0924.656.542",
                    Balance_TMD = 1200000
                },
                new Customer_TMD()
                {
                    CustomerId_TMD = "KH004",
                    FullName_TMD = "Lê Ngọc Hải",
                    Address_TMD = "Hà Nội",
                    Email_TMD = "hailn@gmail.com",
                    Phone_TMD = "0996.555.267",
                    Balance_TMD = 6200000
                }
             };

            ViewBag.listcustomer_tmd = listcustomer_tmd;
            return View();
        }
    }
}
