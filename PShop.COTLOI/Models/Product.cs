using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.COTLOI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Brand  { get; set; }
        public string Name { get; set; }
        public double Gia { get; set; }
        public string ImageLink { get; set; }
        public string MoTa { get; set; }

    }
}
