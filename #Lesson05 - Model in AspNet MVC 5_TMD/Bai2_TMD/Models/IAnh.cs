using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_TMD.Models
{
    internal interface IAnh
    {
        IList<Anh> GetAnhs();

        Anh GetProduct_TMD(string anh);

        void AddProduct_TMD(Anh anh);
    }
}
