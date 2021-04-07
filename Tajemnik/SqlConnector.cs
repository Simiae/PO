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
        public List<PredmetModel> GetPredmet_All()
        {
            List<PredmetModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tajemnik")))
            {
                output = connection.Query<PredmetModel>("dbo.spPredmet_GetAll").ToList();
            }
            return output;
        }

        public List<ZamestnanecModel> GetZamestnanec_All()
        {
            List<ZamestnanecModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tajemnik")))
            {
                output = connection.Query<ZamestnanecModel>("dbo.spZamestnanec_GetAll").ToList();
            }
            return output;
        }

        public PredmetModel VytvorPredmet(PredmetModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tajemnik")))
            {
                var p = new DynamicParameters();
                p.Add("@Zkratka", model.Zkratka);
                p.Add("@PocetTydnu", model.PocetTydnu);
                p.Add("@HodinyCviceni", model.HodinyCviceni);
                p.Add("@HodinyPrednasek", model.HodinyPrednasek);
                p.Add("@HodinySeminaru", model.HodinySeminaru);
                p.Add("@ZpusobZakonceni", model.ZpusobZakonceni);
                p.Add("@Jazyk", model.Jazyk);
                p.Add("@VelikostTridy", model.VelikostTridy);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPredmet_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@ID");

                return model;
            }
        }

        public ZamestnanecModel VytvorZamestnance(ZamestnanecModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tajemnik")))
            {
                var p = new DynamicParameters();
                p.Add("@Jmeno", model.Jmeno);
                p.Add("@Prijmeni", model.Prijmeni);
                p.Add("@PracovniEmail", model.PracovniEmail);
                p.Add("@SoukromyEmail", model.SoukromyEmail);
                p.Add("@Doktorand", model.Doktorand);
                p.Add("@Uvazek", model.Uvazek);
                p.Add("@PracovniTelefon", model.PracovniTelefon);
                p.Add("@SoukromyTelefon", model.SoukromyTelefon);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spZamestnanec_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@ID");

                return model;
            }
        }

    }
}
