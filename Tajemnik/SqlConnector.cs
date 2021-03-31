using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tajemnik.Modely;
using System.Data;

namespace Tajemnik
{
    public class SqlConnector : IDataConnection
    {
        public ZamestnanecModel VytvorZamestnance(ZamestnanecModel model)
        {
            model.ID = 1;
            return model;
        }
    }
}
