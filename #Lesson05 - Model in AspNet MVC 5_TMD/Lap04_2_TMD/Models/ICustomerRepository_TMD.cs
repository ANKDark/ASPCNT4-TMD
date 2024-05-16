using Lap04_2_TMD.Models;
using System.Collections.Generic;

namespace Lap04_2_TMD.Models
{
    public interface ICustomerRepository_TMD
    {
        // Khai báo phương thức lấy danh sách khách hàng
        IList<Customer_TMD> GetCustomers_TMD();

        // Khai báo phương thức lấy khách hàng
        Customer_TMD GetCustomers_TMD(string customerId_TMD);

        // Khai báo phương thức thêm khách hàng
        void AddCustomer_TMD(Customer_TMD cus_tmd);

        // Khai báo phương thức cập nhật khách hàng
        void UpdateCustomer_TMD(Customer_TMD cus_tmd);

        // Khai báo phương thức tìm kiếm khách hàng
        IList<Customer_TMD> SearchCustomer_TMD(string name_TMD);

        // Khai báo phương thức xóa khách hàng
        void DeleteCustomer_TMD(Customer_TMD cus_tmd);
    }
}
