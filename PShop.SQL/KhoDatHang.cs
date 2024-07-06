using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using PShop.SQL.FolderSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.SQL
{
    public class KhoDatHang : IKhoDatHang
    {
        private readonly IDataAccess dataAccess;

        public KhoDatHang(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public int CreateOrder(Order order)
        {
            var sql =
                @"insert into [Order]
        ([DatePlaced]
        ,[DateProcessing]
        ,[DateProcessed]
        ,[CustomerName]
        ,[CustomerAddress]
        ,[CustomerCity]
        ,[CustomerStateProvince]
        ,[CustomerCountry]
        ,[AdminUser]
        ,[UniqueId])
        OUTPUT inserted.OrderId
        Values
        (@DatePlaced
        ,@DateProcessing
        ,@DateProcessed
        ,@CustomerName
        ,@CustomerAddress
        ,@CustomerCity
        ,@CustomerStateProvince
        ,@CustomerCountry
        ,@AdminUser
        ,@UniqueId)";
            var orderId = dataAccess.QuerySingle<int, Order>(sql, order);

            sql = @"insert into OrderLineItem
           ([ProductId]
           ,[OrderId]
           ,[Quantity]
           ,[Price])
           values
           (@ProductId
           ,@OrderId
           ,@Quantity
           ,@Price)";
            order.LineItems.ForEach(x => x.OrderId = orderId);
            dataAccess.ExecuteCommand(sql, order.LineItems);

            return orderId;
        }

        public IEnumerable<ChiTietOrder> GetLineItemsByOrderId(int orderId)
        {
            var sql = @"SELECT * FROM OrderLineItem WHERE OrderId = @OrderId";
            var lineItems = dataAccess.Query<ChiTietOrder, dynamic>(sql, new { OrderId = orderId });

            sql = @"SELECT * FROM Product WHERE ProductId = @ProductId";
            lineItems.ForEach(x => x.Product = dataAccess.QuerySingle<Product, dynamic>(sql, new { ProductId = x.ProductId }));
            return lineItems;
        }

        public Order GetOrder(int id)
        {
            var sql = @"SELECT * FROM [Order] WHERE OrderId = @OrderId";
            var order = dataAccess.QuerySingle<Order, dynamic>(sql, new { OrderId = id });
            order.LineItems = GetLineItemsByOrderId(order.OrderId.Value).ToList();
            return order;
        }

        public Order GetOrderByUniqueId(string uniqueId)
        {
            var sql = @"SELECT * FROM [Order] WHERE UniqueId = @UniqueId";
            var order = dataAccess.QuerySingle<Order, dynamic>(sql, new { UniqueId = uniqueId });
            order.LineItems = GetLineItemsByOrderId(order.OrderId.Value).ToList();
            return order;
        }

        public IEnumerable<Order> GetOrders()
        {
            return dataAccess.Query<Order, dynamic>("SELECT * FROM [Order]", new { });
        }


        public IEnumerable<Order> GetOutStandingOrders()
        {
            var sql = "SELECT * FROM [Order] WHERE DateProcessed IS NULL";
            return dataAccess.Query<Order, dynamic>(sql, new { });
        }

        public IEnumerable<Order> GetProcessedOrder()
        {
            var sql = "SELECT * FROM [Order] WHERE DateProcessed IS NOT NULL";
            return dataAccess.Query<Order, dynamic>(sql, new { });
        }


        public void UpdateOrder(Order order)
        {
            var sql = @"UPDATE [Order]
                        SET
                              [DatePlaced] = @DatePlaced
                              ,[DateProcessing] = @DateProcessing
                              ,[DateProcessed] = @DateProcessed
                              ,[CustomerName] = @CustomerName
                              ,[CustomerAddress] = @CustomerAddress
                              ,[CustomerCity] = @CustomerCity
                              ,[CustomerStateProvince] = @CustomerStateProvince
                              ,[CustomerCountry] = @CustomerCountry
                              ,[AdminUser] = @AdminUser
                              ,[UniqueId] = @UniqueId
                          WHERE OrderId = @OrderId";
            dataAccess.ExecuteCommand<Order>(sql, order);

            sql = @"UPDATE OrderLineItem
                    SET
                              [ProductId] = @ProductId
                              ,[OrderId] = @OrderId
                              ,[Quantity] = @Quantity
                              ,[Price] = @Price
                    WHERE LineItemId = @LineItemId";
            dataAccess.ExecuteCommand<List<ChiTietOrder>>(sql, order.LineItems);
        }
    }
}
