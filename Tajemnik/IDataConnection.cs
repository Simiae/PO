﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tajemnik.Modely;

namespace Tajemnik
{
    public interface IDataConnection
    {
        ZamestnanecModel VytvorZamestnance(ZamestnanecModel model);

        List<ZamestnanecModel> GetZamestnanec_All();

        PredmetModel VytvorPredmet(PredmetModel model);

        List<PredmetModel> GetPredmet_All();
    }
}
