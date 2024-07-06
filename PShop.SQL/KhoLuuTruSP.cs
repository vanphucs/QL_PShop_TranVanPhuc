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
    public class KhoLuuTruSP : IKhoLuuTruSP
    {
        private readonly IDataAccess dataAccess;
        public KhoLuuTruSP(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Product GetProduct(int id)
        {
            return dataAccess.QuerySingle<Product, dynamic>("SELECT * FROM Product WHERE ProductId = @ProductId",
                new { ProductId = id });
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            List<Product> list;
            if (string.IsNullOrWhiteSpace(filter))
                list = dataAccess.Query<Product, dynamic>("SELECT * FROM Product", new { });
            else
                list = dataAccess.Query<Product, dynamic>("SELECT * FROM Product WHERE Name LIKE '%' + @Filter + '%'",
                    new { Filter = filter });
            return list.AsEnumerable();
        }
    }
}
