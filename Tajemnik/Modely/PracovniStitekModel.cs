using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajemnik.Modely
{
    class PracovniStitekModel
    {
        public string Nazev { get; set; }
        public ZamestnanecModel Zamestanec { get; set; }
        public PredmetModel Predmet { get; set; }
        public enum Typ {prednaska, cviceni, seminar, zapocet, klasifikovanyZapocet, zkouska }
        public int PocetStudentu { get; set; }
        public int PocetHodin { get; set; }
        public int PocetTydnu { get; set; }
        public enum Jazyk { Cz, En }

    }
}
