using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.GioHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.GioHang.ChucNang
{
    public class XemGioHang : IXemGioHang
    {
        private readonly IGioHang shoppingCart;
        public XemGioHang(IGioHang shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public Task<Order> Execute()
        {
            return shoppingCart.GetOrderAsync();
        }
    }
}
