using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.COTLOI.Models
{
    public class Order
    {
        public Order()
        {
            LineItems = new List<ChiTietOrder>();
        }
        public int? OrderId { get; set; }
        public DateTime? DatePlaced { get; set; }
        public DateTime? DateProcessed { get; set; }
        public DateTime? DateProcessing { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string AdminUser { get; set; }
        public List<ChiTietOrder> LineItems { get; set; }
        public string UniqueId { get; set; }

        public void Addproduct(int productId, int qty, double price)
        {
            var item = LineItems.FirstOrDefault(x => x.ProductId == productId);// var la kieu du lieu chua xac dinh
            if (item != null)
                item.Quantity += qty;
            else
                LineItems.Add(new ChiTietOrder { ProductId = productId, Quantity = qty, Price = price, OrderId = OrderId });
        }

        public void Removeproduct(int productId)
        {
            var item = LineItems.FirstOrDefault(x => x.ProductId == productId);// var la kieu du lieu chua xac dinh
            if (item != null) LineItems.Remove(item);
        }
    }
}
