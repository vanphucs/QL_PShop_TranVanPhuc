using PShop.NGUOIDUNG.GioHang.StateStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.GioHang
{
    public class GioHangStateStore : StateStoreBase, IGioHangStateStore
    {
        private readonly IGioHang shoppingCart;
        public GioHangStateStore(IGioHang shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public async Task<int> GetItemsCount()
        {
            var order = await shoppingCart.GetOrderAsync();
            if (order != null && order.LineItems != null && order.LineItems.Count > 0)
                return order.LineItems.Count;
            return 0;
        }

        public void UpdateLineItemsCount()
        {
            base.BroadCastStateChange();
        }

        public void UpdateProductQuantity()
        {
            base.BroadCastStateChange();
        }
    }
}
