using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajemnik.Modely
{
    public class PredmetModel
    {
        public string Zkratka { get; set; }
        public int PocetTydnu { get; set; }
        public int HodinyPrednasek { get; set; }
        public int HodinyCviceni { get; set; }
        public int HodinySeminaru { get; set; }
        public enum ZpusobZakonceni { z, zk}
        public enum Jazyk { cz, en }
        public int VelikostTridy { get; set; }
        public List<SkupinkaModel> SeznamSkupin { get; set; } = new List<SkupinkaModel>();
        public string NazevPredmetu { get; set; }               // bez vlivu na aplikaci
        public int PocetKreditu { get; set; }               // bez vlivu na aplikaci
        public enum GarantujiciUstav { UIUI }               // bez vlivu na aplikaci
        public string JmenoGaranta { get; set; }               // bez vlivu na aplikaci




    }
}
