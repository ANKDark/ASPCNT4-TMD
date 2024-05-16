using Lap04_2_TMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lap04_2_TMD.Models
{
    public class CustomerRepository_TMD
    {
        private static readonly List<Customer_TMD> data = new List<Customer_TMD>()
    {
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
        public IList<Customer_TMD> GetCustomers_TMD()
        {
            return data;
        }
        public IList<Customer_TMD> SearchCustomer_TMD(string name_TMD)
        {
            return data.Where(c => c.FullName_TMD.EndsWith(name_TMD)).ToList();
        }
        public Customer_TMD GetCustomer_TMD(string customerId_TMD)
        {
            return data.FirstOrDefault(c => c.CustomerId_TMD.Equals(customerId_TMD));
        }
        //thực thi phương thức thêm khách hàng
        public void AddCustomer_TMD(Customer_TMD cus_tmd)
        {
            data.Add(cus_tmd);
        }
        public void UpdateCustomer_TMD(Customer_TMD cus_tmd)
        {
            var customer = data.FirstOrDefault(c =>
            c.CustomerId_TMD.Equals(cus_tmd.CustomerId_TMD));
            if (customer != null)
            {
                customer.FullName_TMD = cus_tmd.FullName_TMD;
                customer.Address_TMD = cus_tmd.Address_TMD;
                customer.Email_TMD = cus_tmd.Email_TMD;
                customer.Phone_TMD = cus_tmd.Phone_TMD;
                customer.Balance_TMD = cus_tmd.Balance_TMD;
            }
        }
        public void DeleteCustomer_TMD(Customer_TMD cus_tmd)
        {
            data.Remove(cus_tmd);
        }
    }
}
   