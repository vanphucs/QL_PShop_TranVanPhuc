using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.KHODULIEU
{
    public class KhoDatHang : IKhoDatHang
    {
        private Dictionary<int, Order> orders;
        public KhoDatHang()
        {
            orders = new Dictionary<int, Order>();
        }

        public int CreateOrder(Order order)
        {
            order.OrderId = orders.Count + 1;

            orders.Add(order.OrderId.Value, order);
            return order.OrderId.Value;
        }

        public IEnumerable<Order> GetOrders()
        {
            return orders.Values;
        }

        public IEnumerable<Order> GetOutStandingOrders()
        {
            var allOrder = (IEnumerable<Order>)orders.Values;
            return allOrder.Where(x => x.DateProcessed.HasValue == false);
        }

        public IEnumerable<Order> GetProcessedOrder()
        {
            var allOrder = (IEnumerable<Order>)orders.Values;
            return allOrder.Where(x => x.DateProcessed.HasValue);
        }

        public Order GetOrder(int id)
        {
            return orders[id];
        }

        public Order GetOrderByUniqueId(string uniqueId)
        {
            foreach (var order in orders)
            {
                if (order.Value.UniqueId == uniqueId) return order.Value;
            }
            return null;
        }

        public void UpdateOrder(Order order)
        {
            if (order == null || !order.OrderId.HasValue) return;

            var ord = orders[order.OrderId.Value];
            if (ord == null) return;

            orders[order.OrderId.Value] = order;
        }

        IEnumerable<ChiTietOrder> IKhoDatHang.GetLineItemsByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
