using PShop.COTLOI.Models;

namespace ADMIN.CongQuanTri
{
	public interface IXemDonHangDaXuLy
	{
		IEnumerable<Order> Execute();
	}
}