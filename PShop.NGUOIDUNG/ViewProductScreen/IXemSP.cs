using PShop.COTLOI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.NGUOIDUNG.ViewProductScreen
{
    public interface IXemSP
    {
        Product Execute(int id);
    }
}