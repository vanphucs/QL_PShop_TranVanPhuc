using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMIN.CongQuanTri
{
	public class XemChiTietDonHang : IXemChiTietDonHang
	{
		private readonly IKhoDatHang khoDatHang;
		public XemChiTietDonHang(IKhoDatHang khoDatHang)
		{
			this.khoDatHang = khoDatHang;
		}

		public Order Execute(int orderId)
		{
			return khoDatHang.GetOrder(orderId);
		}
	}
}
