using PShop.COTLOI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.GioHang
{
    public interface IGioHang
    {
        Task<Order> GetOrderAsync();
        Task<Order> AddProductAsync(Product product);
        Task<Order> UpdateQuantityAsync(int productId, int quantity);
        Task<Order> UpdateOrderAsync(Order order);
        Task<Order> DeleteProductAsync(int productId);
        Task<Order> PlaceOrderAsync();
        Task EmtyAsync();
    }
}
