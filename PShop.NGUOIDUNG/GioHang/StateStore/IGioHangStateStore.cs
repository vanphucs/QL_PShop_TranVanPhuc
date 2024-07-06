using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.GioHang.StateStore
{
    public interface IGioHangStateStore : IStateStore
    {
        Task<int> GetItemsCount();
        void UpdateLineItemsCount();
        void UpdateProductQuantity();
    }
}
