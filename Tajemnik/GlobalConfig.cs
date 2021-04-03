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
            public static IDataConnection Connection { get; private set; }

            public static void InitializeConnections(DatabaseType db)
            {
                if (db == DatabaseType.Sql)
                {
                    // TODO udělat sql connector pořádně
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                }
                //if (textfiles)
                //{
                //    // TODO = text file connector
                //    TextConnection text = new TextConnection();
                //    Connections.Add(text);
                //}
            }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        }

    }
