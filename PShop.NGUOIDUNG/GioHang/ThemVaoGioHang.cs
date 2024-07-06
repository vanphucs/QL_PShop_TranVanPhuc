using PShop.NGUOIDUNG.GioHang.StateStore;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.GioHang
{
    public class ThemVaoGioHang : IThemVaoGioHang
    {
        private readonly IKhoLuuTruSP productRepository;
        private readonly IGioHang shoppingCart;
        private readonly IGioHangStateStore shoppingCartStateStore;
        public ThemVaoGioHang(IKhoLuuTruSP productRepository,
                              IGioHang shoppingCart, 
                              IGioHangStateStore shoppingCartStateStore)
        {

            this.productRepository = productRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async void Execute(int productId)
        {
            var product = productRepository.GetProduct(productId);
            await shoppingCart.AddProductAsync(product);

            shoppingCartStateStore.UpdateLineItemsCount();
        }
    }
}
