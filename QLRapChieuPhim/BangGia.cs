using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim
{
    public class BangGia
    {
        public List<float> bangGia = new List<float>
        {
            30000, 40000, 50000, 80000
        };

        public float this[int index] 
        { 
            get { 
                if (bangGia.Count > index) 
                { 
                    return bangGia[index]; 
                } else 
                {
                    throw new ArgumentException();
                } 
            } 
        }
    }
}
