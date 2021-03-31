using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajemnik.Modely
{
    public class SkupinkaModel
    {
        public string Zkratka { get; set; }
        public int Rocnik { get; set; }
        public enum Semestr { LS, ZS }
        public int PocetStudentu { get; set; }
        public enum FormaStudia { P, K }
        public enum TypStudia { Bc, Mgr}
        public enum Jazyk { Cz, En }
        public string Nazev { get; set; }
        public List<PredmetModel> SeznamPredmetu { get; set; } = new List<PredmetModel>();

    }
}
