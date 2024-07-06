using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PShop.COTLOI.Models.DichVuOrder;

namespace PShop.COTLOI.Models
{
    public class DichVuOrder : IDichVuOrder
    {
        public bool ValidateCustomerInformation(string name, string sdt, string diachi)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(diachi))
            {
                return false;
            }

            return true;
        }
        public bool ValidateCreateOrder(Order order)
        {

            if (order == null) return false;

            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 || item.Price < 0 || item.Quantity <= 0) return false;
            }
            if (!ValidateCustomerInformation(order.TenKhachHang, order.SoDienThoai, order.DiaChi)) return false;
            return true;
        }

        public bool ValidateUpdateOrder(Order order)
        {
            if (order == null) return false;
            if (!order.OrderId.HasValue) return false;

            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            if (!order.DatePlaced.HasValue) return false;

            if (order.DateProcessed.HasValue || order.DateProcessing.HasValue) return false;

            if (string.IsNullOrWhiteSpace(order.UniqueId)) return false;

            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 || item.Price < 0 || item.Quantity <= 0 || item.OrderId == order.OrderId) return false;
            }

            if (!ValidateCustomerInformation(order.TenKhachHang, order.SoDienThoai, order.DiaChi)) return false;
            return false;
        }

        public bool ValidateProcessOrder(Order order)
        {
            if (!order.DateProcessed.HasValue || string.IsNullOrWhiteSpace(order.AdminUser)) return false;

            return true;
        }
	}
}
