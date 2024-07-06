using PShop.KHODULIEU;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PShop.NGUOIDUNG.PluginInterfaces.DataStore;
using PShop.NGUOIDUNG.ViewProductScreen;
using PShop.NGUOIDUNG.SearchProductScreen;
using PShop.NGUOIDUNG.GioHang;
using PShop.NGUOIDUNG.GioHang.StateStore;
using PShop.COTLOI.Models;
using PShop.NGUOIDUNG.GioHang.ChucNang;
using PShop.NGUOIDUNG.GioHang.ThongTinDonHang;
using ADMIN.CongQuanTri;
//using PShop.SQL.FolderSQL;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddAuthentication("PShop.XacThucCookie")
    .AddCookie("PShop.XacThucCookie", config =>
    {
        config.Cookie.Name = "PShop.XacThucCookie";
        config.LoginPath = "/authenticate";
    });

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//builder.Services.AddTransient<IDataAccess>(sp => new DataAccess(builder.Configuration.GetConnectionString("Default")));


builder.Services.AddScoped<IGioHang, GioHang>();
builder.Services.AddScoped<IGioHangStateStore, GioHangStateStore>();

builder.Services.AddSingleton<IKhoLuuTruSP, KhoLuuTruSP>();
builder.Services.AddSingleton<IKhoDatHang, KhoDatHang>();

builder.Services.AddTransient<IDichVuOrder, DichVuOrder>();
builder.Services.AddTransient<IXemSP, XemSP>();
builder.Services.AddTransient<ITimKiemSP, TimKiemSP>();
builder.Services.AddTransient<IThemVaoGioHang, ThemVaoGioHang>();
builder.Services.AddTransient<IXemGioHang, XemGioHang>();
builder.Services.AddTransient<IXoaSanPham, XoaSanPham>();
builder.Services.AddTransient<ICapNhatSanPham, CapNhatSanPham>();
builder.Services.AddTransient<IDatHang, DatHang>();
builder.Services.AddTransient<IXemXacNhanDH, XemXacNhanDH>();

builder.Services.AddTransient<IXemDHChuaThanhToan, XemDHChuaThanhToan>();
builder.Services.AddTransient<IXemChiTietDonHang, XemChiTietDonHang>();
builder.Services.AddTransient<IThuTuDatHang, ThuTuDatHang>();
builder.Services.AddTransient<IXemDonHangDaXuLy, XemDonHangDaXuLy>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
