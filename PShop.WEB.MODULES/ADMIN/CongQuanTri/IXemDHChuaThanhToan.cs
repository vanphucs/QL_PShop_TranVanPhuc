using PShop.COTLOI.Models;

namespace ADMIN.CongQuanTri
{
    public interface IXemDHChuaThanhToan
    {
        IEnumerable<Order> Execute();
    }
}