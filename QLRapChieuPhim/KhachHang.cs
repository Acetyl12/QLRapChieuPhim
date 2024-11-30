using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim
{
    public class KhachHang
    {
        private static int soLuong = 0;
        public int MaKH { get; set; } = ++soLuong;
        public string HoTen { get; set; }
        public string KhuVuc { get; set; }
        public string SDT { get; set; }

        public KhachHang()
        {
            
        }

        public KhachHang(string hoTen, string khuVuc, string sDT)
        {
            HoTen = hoTen;
            KhuVuc = khuVuc;
            SDT = sDT;
        }
    }
}
