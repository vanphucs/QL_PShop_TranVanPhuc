using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.GioHang;
using PShop.NGUOIDUNG.GioHang.StateStore;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.GioHang.ChucNang
{
    public class DatHang : IDatHang
    {
        private readonly IDichVuOrder dichVuOrder;
        private readonly IKhoDatHang khoDatHang;
        private readonly IGioHang gioHang;
        private readonly IGioHangStateStore gioHangStateStore;
        public DatHang(IDichVuOrder dichVuOrder,
             IKhoDatHang khoDatHang,
             IGioHang gioHang,
             IGioHangStateStore gioHangStateStore)
        {
            this.dichVuOrder = dichVuOrder;
            this.khoDatHang = khoDatHang;
            this.gioHang = gioHang;
            this.gioHangStateStore = gioHangStateStore;
        }

        public async Task<string> Execute(Order order)
        {
            if (dichVuOrder.ValidateCreateOrder(order))
            {
                order.DatePlaced = DateTime.Now;
                order.UniqueId = Guid.NewGuid().ToString();
                khoDatHang.CreateOrder(order);

                await gioHang.EmtyAsync();
                gioHangStateStore.UpdateLineItemsCount();

                return order.UniqueId;
            }
            return null;
        }
    }
}
