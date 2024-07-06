using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.ViewProductScreen
{
    public class XemSP : IXemSP
    {
        private readonly IKhoLuuTruSP ProductRepository;
        public XemSP(IKhoLuuTruSP ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }
        public Product Execute(int id)
        {
            return ProductRepository.GetProduct(id);
        }
    }
}
