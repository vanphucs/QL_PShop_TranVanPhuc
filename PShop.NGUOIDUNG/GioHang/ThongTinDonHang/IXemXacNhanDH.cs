using PShop.COTLOI.Models;

namespace PShop.NGUOIDUNG.GioHang.ThongTinDonHang
{
    public interface IXemXacNhanDH
    {
        Order Execute(string uniqueId);
    }
}