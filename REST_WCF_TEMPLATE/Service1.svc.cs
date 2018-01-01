using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_WCF_TEMPLATE
{
    //template til eksamen
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Static list
        #region STATIC LIST
        //private static List<Catch> catches = new List<Catch>()
        //{
        //    new Catch(1,"Tas","Torsk",3.4,"Øresund",22),
        //    new Catch(2,"Poul","Skalle",1.2,"Furesø",23),
        //    new Catch(){Id=3,Navn = "Hans",Art="Ørred",Sted="Øresund",Uge=44,Vægt = 3.1}

        //};
        #endregion

        //Connection string
        private static string connectingString =
               "Server=tcp:natascha.database.windows.net,1433;Initial Catalog=School;Persist Security Info=False;User ID=nataschajakobsen;Password=Roskilde4000;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";




      

    }
}
