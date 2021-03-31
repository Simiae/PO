using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajemnik
{
        public static class GlobalConfig
        {
            public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

            public static void InitializeConnections(bool database, bool textfiles)
            {
                if (database)
                {
                    // TODO udělat sql connector pořádně
                    SqlConnector sql = new SqlConnector();
                    Connections.Add(sql);
                }
                //if (textfiles)
                //{
                //    // TODO = text file connector
                //    TextConnection text = new TextConnection();
                //    Connections.Add(text);
                //}
            }
        }
    }
