using PShop.COTLOI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.SearchProductScreen
{
    public interface ITimKiemSP
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}