using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PShop.NGUOIDUNG.GioHang
{
    public class GioHang : IGioHang
    {
        private const string cstrShoppingCart = "eShop.ShoppingCart";
        private readonly IJSRuntime jSRuntime;
        private readonly IKhoLuuTruSP productRepository;
        public GioHang(IJSRuntime jsRuntime, IKhoLuuTruSP productRepository)
        {
            this.jSRuntime = jsRuntime;
            this.productRepository = productRepository;

        }
        public async Task<Order> AddProductAsync(Product product)
        {
            var order = await GetOrder();
            order.Addproduct(product.ProductId, 1, product.Gia);
            await SetOrder(order);
            return order;
        }

        public async Task<Order> DeleteProductAsync(int productId)
        {
            var order = await GetOrder();
            order.Removeproduct(productId);
            await SetOrder(order);
            return order;
        }

        public Task EmtyAsync()
        {
            return this.SetOrder(null);
        }

        public async Task<Order> GetOrderAsync()
        {
            return await GetOrder();
        }

        public Task<Order> PlaceOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            await this.SetOrder(order);
            return order;
        }

        public async Task<Order> UpdateQuantityAsync(int productId, int quantity)
        {
            var order = await GetOrder();
            if (quantity < 0) return order;
            else if (quantity == 0) return await DeleteProductAsync(productId);

            var lineItem = order.LineItems.SingleOrDefault(x => x.ProductId == productId);
            if (lineItem != null) lineItem.Quantity = quantity;
            await SetOrder(order);

            return order;
        }

        private async Task<Order> GetOrder()
        {
            Order order = null;
            var Strorder = await jSRuntime.InvokeAsync<string>("localStorage.getItem", cstrShoppingCart);
            if (!string.IsNullOrEmpty(Strorder) && Strorder.ToLower() != "null")
                order = JsonConvert.DeserializeObject<Order>(Strorder);
            else
            {
                order = new Order();
                SetOrder(order);
            }

            foreach (var item in order.LineItems)
            {
                item.Product = productRepository.GetProduct(item.ProductId);
            }
            return order;
        }

        private async Task SetOrder(Order order)
        {
            await jSRuntime.InvokeVoidAsync("localStorage.setItem", cstrShoppingCart, JsonConvert.SerializeObject(order));
        }
    }
}
