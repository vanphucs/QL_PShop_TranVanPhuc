using PShop.COTLOI.Models;

namespace PShop.NGUOIDUNG.GioHang.ChucNang
{
    public interface IXemGioHang
    {
        Task<Order> Execute();
    }
}