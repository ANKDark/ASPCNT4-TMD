using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2_TMD.Models
{
    public class Anhh
    {
        private static readonly List<Anh> data = new List<Anh>()
        {
            new Anh
            {
                anh = "HATY7996.jpg"
            },
            new Anh
            {
                anh = "MEO_7805.jpg"
            },
            new Anh
            {
                anh = "MEO_7807.jpg"
            }
        };
        public IList<Anh> GetAnhs()
        {
            return data;
        }
        public void AddANh(Anh a)
        {
            data.Add(a);
        }
    }
}