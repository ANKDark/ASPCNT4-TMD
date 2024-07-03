using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baitaptulam1_TMD.Models
{
    public class ProductsRepository_TMD
    {
        private static readonly List<Product_TMD> data = new List<Product_TMD>()
        {
            new Product_TMD
            {
                ProductId_TMD = "P001",
                ProductName_TMD = "lẩu vịt",
                Unit_TMD = "Nồi",
                Price_TMD = 150000,
            },
            new Product_TMD
            {
                ProductId_TMD = "P002",
                ProductName_TMD = "lẩu cá kèo",
                Unit_TMD = "Nồi",
                Price_TMD = 250000,
            },
            new Product_TMD
            {
                ProductId_TMD = "P003",
                ProductName_TMD = "lẩu thập cẩm",
                Unit_TMD = "Nồi",
                Price_TMD = 350000,
            }
        };
        public IList<Product_TMD> GetProducts_TMD()
        {
            return data;
        }
        public IList<Product_TMD> SearchProduct_TMD(string name_TMD)
        {
            return data.Where(p => p.ProductName_TMD.EndsWith(name_TMD)).ToList();
        }
        public Product_TMD GetProduct_TMD(string productId_TMD)
        {
            return data.FirstOrDefault(p => p.ProductId_TMD.Equals(productId_TMD));
        }
        public void AddProduct_TMD(Product_TMD product)
        {
            data.Add(product);
        }
        public void UpdateProduct_TMD(Product_TMD prd)
        {
            var product = data.FirstOrDefault(p => p.ProductId_TMD.Equals(prd.ProductId_TMD));
            if (product != null)
            {
                product.ProductName_TMD = prd.ProductName_TMD;
                product.Unit_TMD = prd.Unit_TMD;
                product.Price_TMD = prd.Price_TMD;
            }
        }
        public void DeleteProduct_TMD(Product_TMD product)
        {
            data.Remove(product);
        }
    }
}
