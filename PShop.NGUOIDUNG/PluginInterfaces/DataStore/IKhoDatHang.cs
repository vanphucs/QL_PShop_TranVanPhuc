using PShop.COTLOI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.PluginInterfaces.DataStore
{
    public interface IKhoDatHang
    {
        Order GetOrder(int id);
        Order GetOrderByUniqueId(string uniqueId);
        int CreateOrder(Order order);
        void UpdateOrder(Order order);
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOutStandingOrders();
        IEnumerable<Order> GetProcessedOrder();
        IEnumerable<ChiTietOrder> GetLineItemsByOrderId(int orderId);
    }
}
