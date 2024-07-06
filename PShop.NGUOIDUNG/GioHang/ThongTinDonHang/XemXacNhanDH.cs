using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.GioHang.ThongTinDonHang
{
    public class XemXacNhanDH : IXemXacNhanDH
    {
        private readonly IKhoDatHang khoDatHang;
        public XemXacNhanDH(IKhoDatHang khoDatHang)
        {
            this.khoDatHang = khoDatHang;
        }
        public Order Execute(string uniqueId)
        {
            return khoDatHang.GetOrderByUniqueId(uniqueId);
        }
    }
}
