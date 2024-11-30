using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim
{
    public class HoaDon
    {
        private static int soLuong = 0;
        public int MaHD { get; set; } = ++soLuong;
        public DateTime Ngay { get; set; }
        public float Tien {  get; set; }
        public KhachHang KhachHang {  get; set; } //Phu
        public List<ChiTietHD> chiTietHDs { get; set; }

        public HoaDon() { }

        public HoaDon(DateTime ngay, float tien, KhachHang khachHang)
        {
            Ngay = ngay;
            Tien = tien;
            KhachHang = khachHang;
        }

        public void CapNhatKH(KhachHang khachHang)
        {
            KhachHang = khachHang;
        }

        public void ThemCTHD(ChiTietHD CTHD)
        {
            chiTietHDs.Append(CTHD);
        }
    }
}
