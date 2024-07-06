using PShop.COTLOI.Models;

namespace PShop.NGUOIDUNG.GioHang.ChucNang
{
    public interface IXoaSanPham
    {
        Task<Order> Execute(int productId);
    }
}