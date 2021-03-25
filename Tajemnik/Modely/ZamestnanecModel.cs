using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajemnik.Modely
{
    class ZamestnanecModel
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string CeleJmeno { get; set; }
        public string PracovniEmail { get; set; }
        public string SoukromyEmail { get; set; }
        public bool Doktorand { get; set; }
        public double Uvazek { get; set; }
        public List<PracovniStitek> SeznamStitku { get; set; }
    }
}
