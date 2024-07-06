using PShop.COTLOI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.PluginInterfaces.DataStore
{
    public interface IKhoLuuTruSP
    {
        IEnumerable<Product> GetProducts(string filter);
        Product GetProduct(int id);
    }
}
