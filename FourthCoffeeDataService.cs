using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Services;
using System.ServiceModel.Web;

namespace Accessing_Remote_Data
{
    public class FourthCoffeeDataService : DataService<FourthCoffee>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetServiceOperationAccessRule("SalesPersonByEmail", ServiceOperationRights.ReadMultiple);
        }

        [WebGet]
        [SingleResult]
        public SalesPerson SalesPersonByEmail(string emailAddress)
        {
           return (from p in this.CurrentDataSource.SalesPerson
                       where String.Equals(p.Area.area)
                       select p).SingleOrDefault;
        }
    }
}
