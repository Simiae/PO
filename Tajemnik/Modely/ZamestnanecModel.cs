using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajemnik.Modely
{
    public class ZamestnanecModel
    {
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string CeleJmeno { get; set; }
        public string PracovniEmail { get; set; }
        public string SoukromyEmail { get; set; }
        public bool Doktorand { get; set; }
        public double Uvazek { get; set; }
        public List<PracovniStitekModel> SeznamStitku { get; set; } = new List<PracovniStitekModel>();
        public string PracovniTelefon { get; set; }
        public string SoukromyTelefon { get; set; }


        // metody
        //public PracovniBodyBezAnglictiny()
        //{

        //}

        //public PracovniBody()
        //{

        //}

        //public ZamestnanecModel()
        //{

        //}

        public ZamestnanecModel()
        {

        }

        public ZamestnanecModel(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

    }
}
