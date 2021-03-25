using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajemnik.Modely
{
    class PredmetModel
    {
        public string Zkratka { get; set; }
        public int PocetTydnu { get; set; }
        public int HodinyPrednasek { get; set; }
        public int HodinyCviceni { get; set; }
        public int HodinySeminaru { get; set; }
        public enum ZpusobZakonceni { z, zk}
        public enum Jazyk { cz, en }



    }
}
