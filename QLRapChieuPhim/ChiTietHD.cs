using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim
{
    public class ChiTietHD
    {
        public ChiTietHD()
        {
            
        }
        public ChiTietHD(int iDCTHD, Ghe ghe)
        {
            IDCTHD = iDCTHD;
            Ghe = ghe;
        }

        public int IDCTHD {  get; set; }
        public Ghe Ghe {  get; set; }
        public string MaHD { get; set; } //Phu

        public void NhapMaHD(string maHD)
        {
            MaHD = maHD;
        }
    }
}
