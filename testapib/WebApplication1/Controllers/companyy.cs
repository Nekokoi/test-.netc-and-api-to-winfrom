using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using System.Data;
using Microsoft.Data.SqlClient;
using WebApplication1.model;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class companyy : ControllerBase
    {
        public readonly IConfiguration contcom;
        public companyy(IConfiguration Icontcom)
        {
            contcom = Icontcom;
        }
        [HttpGet]
        [Route("getalldacom")]

        public string Getcompyda()
        {

            SqlConnection conn = new SqlConnection(contcom.GetConnectionString("companyda").ToString());
            SqlDataAdapter getdacom = new SqlDataAdapter("select * from dbo.company", conn);
            DataTable companytb = new DataTable();
            List<datacompany> dataallcomList = new List<datacompany>();
            response respon = new response();
            getdacom.Fill(companytb);
            if (companytb.Rows.Count > 0)
            {
                for (int i = 0; i < companytb.Rows.Count; i++)
                {
                    datacompany dataallcom = new datacompany();
                    dataallcom.cpid = Convert.ToInt32(companytb.Rows[i]["cpid"]);
                    dataallcom.Name = Convert.ToString(companytb.Rows[i]["Name"]);
                    dataallcomList.Add(dataallcom);
                }
            }
            if (dataallcomList.Count > 0)
            {
               return JsonConvert.SerializeObject(dataallcomList);

            }
            else
            {
                respon.statuscode = 100;
                respon.Errormes = "not found data";
                return JsonConvert.SerializeObject(dataallcomList);
            //    return JsonConvert.SerializeObject(respon);
            
            }
            
          

        }
    }
}
