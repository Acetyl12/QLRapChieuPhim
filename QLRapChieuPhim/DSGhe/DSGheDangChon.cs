using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim.DSGhe
{
    public class DSGheDangChon: IEnumerable<Ghe>
    {
        public List<Ghe> DSGheDChon = new List<Ghe>();

        public void ChonGhe(Ghe ghe)
        {
            DSGheDChon.Add(ghe);
        }
        
        public bool IsAny(int id)
        {
            return DSGheDChon.Any(gh => gh.MaGhe == id);
        }

        public void Remove(int id)
        {
            Console.WriteLine(id);
            DSGheDChon.RemoveAll(gh => gh.MaGhe == id);
        }

        public void Clear()
        {
            DSGheDChon.Clear();
        }

        public IEnumerator<Ghe> GetEnumerator()
        {
            return DSGheDChon.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
