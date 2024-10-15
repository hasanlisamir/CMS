using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_idarə_etmə_proqramı
{
    internal class Qrup
    {
        public int QrupKodu { get; set; }
        public string QrupAdi { get; set; }

        public Qrup(int qrupKodu, string qrupAdi)
        {
            QrupKodu = qrupKodu;
            QrupAdi = qrupAdi;
        }
    }
}
