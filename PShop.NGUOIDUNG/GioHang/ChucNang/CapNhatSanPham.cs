using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.GioHang;
using PShop.NGUOIDUNG.GioHang.StateStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.GioHang.ChucNang
{
    public class CapNhatSanPham : ICapNhatSanPham
    {
        private readonly IGioHang shoppingCart;
        private readonly IGioHangStateStore shoppingCartStateStore;
        public CapNhatSanPham(IGioHang shoppingCart, IGioHangStateStore shoppingCartStateStore)
        {
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<Order> Execute(int productId, int quantity)
        {
            var order = await shoppingCart.UpdateQuantityAsync(productId, quantity);
            shoppingCartStateStore.UpdateProductQuantity();
            return order;
        }
    }
}
