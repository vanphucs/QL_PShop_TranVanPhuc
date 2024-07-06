using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;

namespace PShop.KHODULIEU
{
    public class KhoLuuTruSP : IKhoLuuTruSP
    {
        private List<Product> products;
        public KhoLuuTruSP()
        {
            products = new List<Product>
            {
                new Product
                {
                    ProductId = 120,
                    Brand = "PShop",
                    Name = "Mặt dây chuyền Vàng trắng 10K đính đá ECZ PShop",
                    Gia = 2383000,
                    ImageLink = "https://cdn.pnj.io/images/detailed/116/GMXMXMW001856-1.png",
                    MoTa = "Chất liệu Vàng trắng 10K, đính đá ECZ (Excellent Cubic Zirconia), thiết kế tinh tế và sang trọng, kích thước tùy chỉnh, trọng lượng nhẹ, bề mặt sáng bóng, kiểu dáng thanh lịch, nhập khẩu từ Mỹ, bảo hành 12 tháng."
                },
                new Product
                {
                    ProductId = 119,
                    Brand = "PShop",
                    Name = "Dây chuyền Vàng trắng Ý 18K PShop",
                    Gia = 15715000,
                    ImageLink = "https://cdn.pnj.io/images/thumbnails/300/300/detailed/99/gd0000w000583-day-chuyen-vang-trang-y-18k-pnj.png",
                    MoTa = "Chất liệu Vàng trắng 18K nhập từ Italy, kiểu dáng đơn giản, sang trọng, độ dài 45cm, khối lượng 3.5g, bề mặt đánh bóng tinh tế, khóa an toàn chống tuột, thiết kế unisex, bảo hành 12 tháng."
                },
                new Product
                {
                    ProductId = 118,
                    Brand = "PShop",
                    Name = "Bông tai Kim cương Vàng trắng 14K PShop First Diamond",
                    Gia = 15513000,
                    ImageLink = "https://cdn.pnj.io/images/thumbnails/300/300/detailed/208/sp-gbddddw000678-bong-tai-kim-cuong-vang-trang-14k-pnj-first-diamond-1.png",
                    MoTa = "Chất liệu Vàng trắng 14K, kim cương, kiểu dáng cổ điển đính 2 viên kim cương sáng bóng, kích thước khoảng 1cm, trọng lượng 1.2g, bề mặt sang trọng, khóa bướm an toàn, nhập khẩu từ Pháp, bảo hành 18 tháng."
                },
                new Product
                {
                    ProductId = 117,
                    Brand = "PShop",
                    Name = "Bông tai vàng 18K đính đá Ruby PShop",
                    Gia = 11161000,
                    ImageLink = "https://cdn.pnj.io/images/detailed/210/sp-gbrbxmy000301-bong-tai-vang-18k-dinh-da-ruby-pnj-1.png",
                    MoTa = "Chất liệu Vàng 18K, đá Ruby, kiểu dáng sang trọng đính 2 viên đá Ruby rực rỡ, kích thước khoảng 1.2cm, trọng lượng 1.5g, bề mặt tinh tế, khóa bướm chắc chắn, nhập khẩu từ Ý, bảo hành 24 tháng."
                },
                new Product
                {
                    ProductId = 116,
                    Brand = "PShop",
                    Name = "Nhẫn nam Vàng trắng 10K đính đá ECZ PShop",
                    Gia = 9044000, ImageLink = "https://cdn.pnj.io/images/thumbnails/300/300/detailed/27/gnxmxmw000169-nhan-nam-vang-trang-10k-dinh-da-ecz-pnj-01.png",
                    MoTa = "Chất liệu Vàng trắng 10K, thiết kế nam tính đính 3 viên đá ECZ sáng bóng, kiểu dáng đơn giản nhưng tinh tế, kích thước phù hợp với bàn tay nam giới, trọng lượng khoảng 6g, bề mặt bóng mịn, không phai màu, nhập khẩu từ thương hiệu trang sức uy tín, bảo hành 12 tháng."
                },
                new Product
                {
                    ProductId = 115,
                    Brand = "PShop",
                    Name = "Lắc tay Vàng trắng Ý 18K PShop",
                    Gia = 7130000,
                    ImageLink = "https://cdn.pnj.io/images/thumbnails/300/300/detailed/100/gl0000w000526-lac-tay-vang-trang-y-18k-pnj.png", 
                    MoTa = "Chất liệu Vàng trắng Ý 18K, thiết kế tinh xảo, kích thước vòng 18cm, trọng lượng 5.5g, bề mặt bóng loáng, kiểu dáng hiện đại, khóa móc chắc chắn, nhập khẩu từ Ý, bảo hành 24 tháng."
                },
                new Product
                {
                    ProductId = 114,
                    Brand = "PShop",
                    Name = "Mặt dây chuyền Vàng 18K PShop",
                    Gia = 15848000,
                    ImageLink = "https://cdn.pnj.io/images/detailed/212/sp-gm0000y001383-mat-day-chuyen-vang-18k-pnj-1.png", 
                    MoTa = "Chất liệu Vàng 18K, thiết kế thanh lịch, kích thước 2.5cm x 1.5cm, trọng lượng 2.3g, bề mặt sáng bóng, kiểu dáng cổ điển, điểm nhấn tinh tế, nhập khẩu từ Thụy Sĩ, bảo hành 24 tháng."
                },
                new Product
                {
                    ProductId = 113,
                    Brand = "PShop",
                    Name = "Bông tai Vàng trắng Ý 18K PShop",
                    Gia = 5392000,
                    ImageLink = "https://cdn.pnj.io/images/detailed/211/sp-gb0000w002596-bong-tai-vang-trang-y-18k-pnj-1.png",
                    MoTa = "Chất liệu Vàng trắng Ý 18K, thiết kế tinh tế, đính 2 viên đá quý lấp lánh, kích thước khoảng 1cm, trọng lượng 1.3g, bề mặt sáng bóng, khóa bướm an toàn, nhập khẩu từ Ý, bảo hành 24 tháng."
                },
                new Product
                {
                    ProductId = 112,
                    Brand = "PShop",
                    Name = "Nhẫn Vàng trắng 14K đính đá ECZ PShop",
                    Gia = 6510000,
                    ImageLink = "https://cdn.pnj.io/images/detailed/211/sp-gnxmxmw005162-nhan-vang-trang-14k-dinh-da-ecz-pnj-1.png", 
                    MoTa = "Chất liệu Vàng trắng 14K, đính đá ECZ (Excellent Cubic Zirconia), thiết kế sang trọng, kích thước tùy chỉnh, trọng lượng 2.0g, bề mặt bóng loáng, kiểu dáng hiện đại, nhập khẩu từ Thái Lan, bảo hành 18 tháng."
                },
                new Product
                {
                    ProductId = 111,
                    Brand = "PShop",
                    Name = "Mặt dây chuyền Vàng trắng 14K đính đá Ruby Disney PShop",
                    Gia = 4724000,
                    ImageLink = "https://cdn.pnj.io/images/detailed/207/sp-gmrbxmw000104-mat-day-chuyen-vang-trang-14k-dinh-da-ruby-disney-pnj-snow-white-&-the-seven-dwarfs-1.png",
                    MoTa = "Chất liệu Vàng trắng 14K, đính đá Ruby, thiết kế vui tươi với chủ đề Disney, kích thước tùy chỉnh, trọng lượng nhẹ, bề mặt sáng bóng, kiểu dáng độc đáo, nhập khẩu từ Mỹ, bảo hành 12 tháng."
                },
                new Product
                {
                    ProductId = 110,
                    Brand = "PShop",
                    Name = "Nhẫn Vàng 18K đính Ngọc trai Southsea PShop",
                    Gia = 21454000,
                    ImageLink = "https://cdn.pnj.io/images/detailed/211/sp-gnpsddy000163-nhan-vang-18k-dinh-ngoc-trai-southsea-pnj-1.png",
                    MoTa = "Chất liệu Vàng 18K, đính Ngọc trai Southsea, thiết kế sang trọng, kích thước tùy chỉnh, trọng lượng 3.0g, bề mặt tinh tế, kiểu dáng thanh lịch, nhập khẩu từ Nhật Bản, bảo hành 24 tháng."
                },
                new Product 
                { 
                    ProductId = 109,
                    Brand = "PShop", 
                    Name = "Mặt dây chuyền Vàng trắng 14K đính Ngọc trai Freshwater PShop",
                    Gia = 7653000, 
                    ImageLink = "https://cdn.pnj.io/images/detailed/212/sp-gmpfxmw000299-mat-day-chuyen-vang-trang-14k-dinh-ngoc-trai-freshwater-pnj-1.png",
                    MoTa = "Chất liệu Vàng trắng 14K, đính Ngọc trai Freshwater, thiết kế thanh lịch, kích thước 2cm x 1.2cm, trọng lượng 1.8g, bề mặt bóng loáng, kiểu dáng tinh tế, nhập khẩu từ Úc, bảo hành 18 tháng."
                },
                new Product 
                { 
                    ProductId = 108,
                    Brand = "PShop", 
                    Name = "Mặt dây chuyền Kim cương Vàng trắng 14K PShop", 
                    Gia = 21069000, ImageLink = "https://cdn.pnj.io/images/detailed/172/sp-gmddddw000923-mat-day-chuyen-kim-cuong-vang-trang-14k-pnj-1.png", 
                    MoTa = "Chất liệu Vàng trắng 14K, đính Kim cương, thiết kế tinh tế, kích thước 2cm x 1cm, trọng lượng 2.0g, bề mặt sáng bóng, kiểu dáng sang trọng, nhập khẩu từ Bỉ, bảo hành 18 tháng."
                },
                new Product 
                { 
                    ProductId = 107,
                    Brand = "PShop",
                    Name = "Lắc tay nam Vàng 14K PShop",
                    Gia = 25415000, ImageLink = "https://cdn.pnj.io/images/detailed/212/sp-gl0000y003277-lac-tay-nam-vang-14k-pnj-1.png", 
                    MoTa = "Chất liệu Vàng 14K, thiết kế mạnh mẽ, kích thước vòng 20cm, trọng lượng 8.0g, bề mặt sáng bóng, kiểu dáng nam tính, khóa cài chắc chắn, nhập khẩu từ Đức, bảo hành 18 tháng."
                },
                new Product 
                {
                    ProductId = 106,
                    Brand = "PShop", 
                    Name = "Bông tai Vàng 10K đính đá Synthetic Disney PShop", 
                    Gia = 4408000, ImageLink = "https://cdn.pnj.io/images/detailed/213/sp-gbztzth000006-bong-tai-vang-10k-dinh-da-synthetic-disney-pnj-inside-out-2-01.png", 
                    MoTa = "Chất liệu Vàng 10K, đính đá Synthetic, thiết kế vui tươi với chủ đề Disney, kích thước khoảng 1cm, trọng lượng 1.0g, bề mặt sáng bóng, khóa bướm an toàn, nhập khẩu từ Mỹ, bảo hành 12 tháng."
                },
                new Product { ProductId = 105, Brand = "PShop", Name = "Nhẫn Vàng 10K đính đá Synthetic Disney PShop", Gia = 4399000, 
                    ImageLink = "https://cdn.pnj.io/images/detailed/214/sp-gnzt00z000001-nhan-vang-10k-dinh-da-synthetic-pnj.png", 
                    MoTa = "Chất liệu Vàng 10K, đính đá Synthetic, thiết kế vui tươi với chủ đề Disney, kích thước tùy chỉnh, trọng lượng 2.0g, bề mặt sáng bóng, kiểu dáng độc đáo, nhập khẩu từ Mỹ, bảo hành 12 tháng." },
                new Product { ProductId = 104, Brand = "PShop", Name = "Nhẫn Vàng 10K đính đá Synthetic PShop", Gia = 2530000, 
                    ImageLink = "https://cdn.pnj.io/images/detailed/213/sp-gnzt00h000006-nhan-vang-10k-dinh-da-synthetic-disney-pnj-01.png", 
                    MoTa = "Chất liệu Vàng 10K, đính đá Synthetic, thiết kế vui tươi với chủ đề Disney, kích thước tùy chỉnh, trọng lượng 2.0g, bề mặt sáng bóng, kiểu dáng độc đáo." },
                new Product { ProductId = 103, Brand = "PShop", Name = "Bông tai Kim cương Vàng trắng 14K PShop", Gia = 27267000,
                    ImageLink = "https://cdn.pnj.io/images/detailed/191/sp-gbddddw003826-bong-tai-kim-cuong-vang-trang-14k-pnj-1.png", 
                    MoTa = "Chất liệu Vàng trắng 14K, đính kim cương, thiết kế tinh tế và sang trọng, kích thước tùy chỉnh, trọng lượng nhẹ, bề mặt sáng bóng, kiểu dáng thanh lịch, nhập khẩu từ Mỹ, bảo hành 12 tháng." },
                new Product { ProductId = 102, Brand = "PShop", Name = "Bông tai Vàng Trắng 10K Đính đá Synthetic PShop",
                    Gia = 3066000, ImageLink = "https://cdn.pnj.io/images/detailed/201/sp-gbztmxw000023-bong-tai-vang-trang-10k-dinh-da-sythetic-pnj-%EF%B8%8F-hello-kitty-1.png",
                    MoTa = "Chất liệu Vàng trắng 10K, đính đá Synthetic, thiết kế hiện đại và tinh tế, kích thước tùy chỉnh, trọng lượng nhẹ, bề mặt sáng bóng, kiểu dáng thanh lịch, nhập khẩu từ Mỹ, bảo hành 12 tháng." },
                new Product { ProductId = 101, Brand = "PShop", Name = "Mặt dây chuyền Vàng trắng 14K đính đá Topaz", Gia = 6356000, 
                    ImageLink = "https://cdn.pnj.io/images/detailed/202/sp-gmtpxmw000417-mat-day-chuyen-vang-trang-14k-dinh-da-topaz-pnj-1.png",
                    MoTa = "Chất liệu Vàng trắng 14K, đính đá Topaz, thiết kế sang trọng và tinh tế, kích thước tùy chỉnh, trọng lượng nhẹ, bề mặt sáng bóng, kiểu dáng độc đáo, nhập khẩu từ Mỹ, bảo hành 12 tháng." },
            };
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.ProductId == id);
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter)) return products;
            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }

    }
}
