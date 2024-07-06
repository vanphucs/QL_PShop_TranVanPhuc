using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THONGTINDONHANG.Controls
{
    public class XemThongTinKhachHang
    {
        [Required]
        public string TenKhachHang { get; set; }

        [Required]
        public string SoDienThoai { get; set; }

        [Required]
        public string DiaChi { get; set; }
    }
}
