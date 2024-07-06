using PShop.COTLOI.Models;

namespace PShop.NGUOIDUNG.GioHang.ChucNang
{
    public interface IDatHang
    {
        Task<string> Execute(Order order);
    }
}