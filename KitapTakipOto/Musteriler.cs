using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapTakipOto
{
    public class Musteriler
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EPosta { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
