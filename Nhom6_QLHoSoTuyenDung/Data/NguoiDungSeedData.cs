using Nhom6_QLHoSoTuyenDung.Models;
using Nhom6_QLHoSoTuyenDung.Models.Entities;

namespace Nhom6_QLHoSoTuyenDung.Data
{
    public static class NguoiDungSeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (context.NguoiDungs.Any()) return;

            var nguoiDungs = new List<NguoiDung>
            {
                // Admin hệ thống (quản lý toàn bộ)
                new NguoiDung {
                    NhanVienId = "NV001",
                    TenDangNhap = "admin",
                    MatKhau = "123456",
                    VaiTro = "Admin",
                    PhongBanId = "PBKT",
                    HoTen = "Nguyễn Văn An",
                    Email = "an.kt@example.com",
                    SoDienThoai = "0901000001",
                    NgayTao = DateTime.Now
                },

                // HR phụ trách tuyển dụng
                new NguoiDung {
                    NhanVienId = "NV002",
                    TenDangNhap = "hr1",
                    MatKhau = "123456",
                    VaiTro = "HR",
                    PhongBanId = "PBNS",
                    HoTen = "Trần Thị Bích",
                    Email = "bich.ns@example.com",
                    SoDienThoai = "0901000002",
                    NgayTao = DateTime.Now
                },
                new NguoiDung {
                    NhanVienId = "NV010",
                    TenDangNhap = "hr2",
                    MatKhau = "123456",
                    VaiTro = "HR",
                    PhongBanId = "PBNS",
                    HoTen = "Lưu Thị Hằng",
                    Email = "hang.ns@example.com",
                    SoDienThoai = "0901000010",
                    NgayTao = DateTime.Now
                },

                // Người phỏng vấn (Interviewer)
                new NguoiDung {
                    NhanVienId = "NV003",
                    TenDangNhap = "pv1",
                    MatKhau = "123456",
                    VaiTro = "Interviewer",
                    PhongBanId = "PBIT",
                    HoTen = "Lê Hoàng Giang",
                    Email = "giang.it@example.com",
                    SoDienThoai = "0901000003",
                    NgayTao = DateTime.Now
                },
                new NguoiDung {
                    NhanVienId = "NV004",
                    TenDangNhap = "pv2",
                    MatKhau = "123456",
                    VaiTro = "Interviewer",
                    PhongBanId = "PBDA",
                    HoTen = "Phạm Thị Lan",
                    Email = "lan.da@example.com",
                    SoDienThoai = "0901000004",
                    NgayTao = DateTime.Now
                },
                new NguoiDung {
                    NhanVienId = "NV011",
                    TenDangNhap = "pv3",
                    MatKhau = "123456",
                    VaiTro = "Interviewer",
                    PhongBanId = "PBIT",
                    HoTen = "Nguyễn Văn Long",
                    Email = "long.full@example.com",
                    SoDienThoai = "0901000011",
                    NgayTao = DateTime.Now
                },new NguoiDung {
                    NhanVienId = "NV013",
                    TenDangNhap = "minhadmin",
                    MatKhau = "123456",
                    VaiTro = "Admin",
                    PhongBanId = "PBNS",
                    HoTen = "Đỗ Công Minh",
                    Email = "mdang2186@gmail.com",
                    SoDienThoai = "0246578427",
                    NgayTao = DateTime.Now
                },new NguoiDung {
                    NhanVienId = "NV014",
                    TenDangNhap = "quynhhr",
                    MatKhau = "123456",
                    VaiTro = "HR",
                    PhongBanId = "PBNS",
                    HoTen = "Đinh Thị Diễm Quỳnh",
                    Email = "diemquynhdinh1010@gmail.com",
                    SoDienThoai = "0925246012",
                    NgayTao = DateTime.Now
                },new NguoiDung {
                    NhanVienId = "NV015",
                    TenDangNhap = "vanpv",
                    MatKhau = "123456",
                    VaiTro = "Interviewer",
                    PhongBanId = "PBNS",
                    HoTen = "Trần Thị Thanh Vân",
                    Email = "vantran260304@gmail.com",
                    SoDienThoai = "0902456012",
                    NgayTao = DateTime.Now
                }
            };

            context.NguoiDungs.AddRange(nguoiDungs);
            context.SaveChanges();
        }
    }
}
