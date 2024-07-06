using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.SearchProductScreen
{
    public class TimKiemSP :  ITimKiemSP
    {
        private readonly IKhoLuuTruSP ProductRepository;
        public TimKiemSP(IKhoLuuTruSP ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }
        public IEnumerable<Product> Execute(string filter)
        {
            return ProductRepository.GetProducts(filter);
        }
    }
}
