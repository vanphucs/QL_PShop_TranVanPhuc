using PShop.COTLOI.Models;

namespace ADMIN.CongQuanTri
{
	public interface IXemChiTietDonHang
	{
		Order Execute(int orderId);
	}
}