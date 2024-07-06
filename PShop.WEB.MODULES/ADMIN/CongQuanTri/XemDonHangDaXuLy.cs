using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMIN.CongQuanTri
{
	public class XemDonHangDaXuLy : IXemDonHangDaXuLy
	{
		private readonly IKhoDatHang khoDatHang;
		public XemDonHangDaXuLy(IKhoDatHang khoDatHang)
		{
			this.khoDatHang = khoDatHang;
		}
		public IEnumerable<Order> Execute()
		{
			return khoDatHang.GetProcessedOrder();
		}
	}
}
