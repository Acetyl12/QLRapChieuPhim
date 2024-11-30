using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim.DSGhe
{
    public class DSGheDaChon
    {
        public List<Ghe> dsGheDaChon = new List<Ghe>();

        public void Chon(Ghe ghe)
        {
            dsGheDaChon.Append(ghe);
        }
    }
}
