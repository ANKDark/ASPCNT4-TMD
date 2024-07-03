using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using TmdLap09.Models; // Sửa lại namespace để không cần sử dụng 'static'

namespace TmdLap09.Controllers
{
    public class HomeController : Controller
    {
        // Khởi tạo entity nhà hàng
        TmdNhaHangEntities nhahang = new TmdNhaHangEntities();

        public ActionResult Index()
        {
            return View();
        }

        // Tạo caching
        [OutputCache(Location = OutputCacheLocation.Server, Duration = 10000)]
        public ActionResult Products()
        {
            // Lấy tất cả sản phẩm
            var listproduct = nhahang.TmdProducts.AsEnumerable();
            // Chuyển ra view
            return View(listproduct);
        }

        // Thêm sản phẩm vào giỏ và hiển thị ra view
        public ActionResult AddToBasket(string id)
        {
            // Nếu có id thì add vào giỏ hàng
            if (id != null)
            {
                AddBasket(id);
            }
            // Đưa dữ liệu ra view
            return View(GetBasket());
        }

        #region "xử lý giỏ hàng"

        private List<TmdItem> GetBasket()
        {
            // Chuyển Session thành mảng
            string[] apid = Session["pid"].ToString().Split(new char[] { ',' });
            string[] aqty = Session["qty"].ToString().Split(new char[] { ',' });

            // Tạo danh sách chứa kết quả
            List<TmdItem> listproduct = new List<TmdItem>();

            // Duyệt mảng id và quantity
            for (int i = 0; i < apid.Length - 1; i++)
            {
                int id = int.Parse(apid[i]);
                // Lấy sản phẩm có id trong bảng
                TmdProducts p = nhahang.TmdProducts.SingleOrDefault(x => x.TmdId == id);
                // Khởi tạo item với các thông số tương ứng sản phẩm chọn
                TmdItem it = new TmdItem()
                {
                    TmdId = p.TmdId,
                    TmdName = p.TmdName,
                    TmdPicture = p.TmdPicture,
                    TmdPrice = p.TmdPrice.Value,
                    TmdQuantity = int.Parse(aqty[i]),
                    TmdAmount = p.TmdPrice.Value * int.Parse(aqty[i])
                };
                // Thêm vào danh sách
                listproduct.Add(it);
            }
            // Trả về kết quả là một danh sách các item đã chọn với đầy đủ thông tin
            return listproduct;
        }

        private void AddBasket(string pid)
        {
            // Nếu trống thì nối id và chuỗi
            if (Session["pid"].ToString() == "")
            {
                Session["pid"] += pid + ",";
                Session["qty"] += "1,";
            }
            else
            {
                // Chuyển Session thành mảng và kiểm tra trùng sản phẩm
                string[] apid = Session["pid"].ToString().Split(new char[] { ',' });
                string[] aqty = Session["qty"].ToString().Split(new char[] { ',' });
                // Đánh dấu chưa trùng
                bool flag = false;
                // Duyệt
                for (int i = 0; i < apid.Length - 1; i++)
                {
                    // Nếu trùng id thì tăng số lượng lên 1 và thoát khỏi for
                    if (apid[i] == pid)
                    {
                        int q = int.Parse(aqty[i]) + 1;
                        aqty[i] = q.ToString();
                        flag = true;
                        break;
                    }
                }
                // Nếu trùng thì duyệt mảng nối lại chuỗi
                if (flag == true)
                {
                    Session["pid"] = "";
                    Session["qty"] = "";
                    for (int i = 0; i < apid.Length - 1; i++)
                    {
                        Session["pid"] += apid[i] + ",";
                        Session["qty"] += aqty[i] + ",";
                    }
                }
                else // Không trùng thì nối với id chọn
                {
                    Session["pid"] += pid + ",";
                    Session["qty"] += "1,";
                }
            }
        }

        #endregion
    }
}
