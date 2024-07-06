using PShop.COTLOI.Models;

namespace PShop.NGUOIDUNG.GioHang.ChucNang
{
    public interface ICapNhatSanPham
    {
        Task<Order> Execute(int productId, int quantity);
    }
}