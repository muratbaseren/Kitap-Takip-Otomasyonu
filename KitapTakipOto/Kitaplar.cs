using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapTakipOto
{
   public class Kitaplar
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Kategori { get; set; }
        public bool VarMi { get; set; }
        public int Fiyat { get; set; }

        public override string ToString()
        {
            return KitapAdi;
        }
    }
}
