using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMIN.CongQuanTri
{
	public class ThuTuDatHang : IThuTuDatHang
	{
		private readonly IKhoDatHang orderRepository;
		private readonly IDichVuOrder orderService;
		public ThuTuDatHang(IKhoDatHang orderRepository, IDichVuOrder orderService)
		{
			this.orderRepository = orderRepository;
			this.orderService = orderService;
		}

		public bool Execute(int orderId, string adminUserName)
		{
			var order = orderRepository.GetOrder(orderId);
			order.AdminUser = adminUserName;
			order.DateProcessed = DateTime.Now;

			if (orderService.ValidateProcessOrder(order))
			{
				orderRepository.UpdateOrder(order);
				return true;
			}
			return false;
		}
	}
}
