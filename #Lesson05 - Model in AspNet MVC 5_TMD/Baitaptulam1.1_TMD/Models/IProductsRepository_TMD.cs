using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaptulam1.1_TMD.Models
{
    internal interface IProductsRepository_TMD
    {
        IList<Product_TMD> GetProduct_TMD();

        Product_TMD GetProduct_TMD(string productId_TMD);

        void AddProduct_TMD(Product_TMD prd_tmd);

        void UpdateProduct_TMD(Product_TMD prd_tmd);

        IList<Product_TMD> SearchProduct_TMD(string name_TMD);
        IList<Product_TMD> SearchCategory_TMD(string name_TMD);

        void DeleteProduct_TMD(Product_TMD prd_tmd);
    }
}
