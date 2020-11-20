using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Accessing_Remote_Data
{
    [DataContract()]
    public class SalesPerson
    {
        [DataMember()]
        public string FirstName { get; set; }

        [DataMember()]
        public string LastName { get; set; }

        [DataMember()]
        public string Area { get; set; }

        [DataMember()]
        public string EmailAdsress { get; set; }
    }
}
