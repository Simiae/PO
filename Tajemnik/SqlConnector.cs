using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tajemnik.Modely;
using System.Data;

//@Jmeno nvarchar(100),
//@Prijmeni nvarchar(100),
//@ID int= 0 output
namespace Tajemnik
{
    public class SqlConnector : IDataConnection
    {
        public ZamestnanecModel VytvorZamestnance(ZamestnanecModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tajemnik")))
            {
                var p = new DynamicParameters();
                p.Add("@Jmeno", model.Jmeno);
                p.Add("@Prijmeni", model.Prijmeni);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spZamestnanec_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@ID");

                return model;
            }
        }
    }
}
