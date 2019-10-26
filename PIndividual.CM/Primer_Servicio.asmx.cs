using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PIndividual.BL;
using PIndividual.DAL;

namespace PIndividual.CM
{
    /// <summary>
    /// Summary description for Primer_Servicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Primer_Servicio : System.Web.Services.WebService
    {

        [WebMethod] //para que el servicio se pueda ver desde el cliente , es decir para que esté expuesto 
        public string HelloWorld()
        {
            return "Hello World";
        }

        
    }

}
