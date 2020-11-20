using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Accessing_Remote_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://Sales.Fourthcoffee.com/SalesService.svc/GetSalesPerson";
            //var request = WebRequest.Create(uri) as HttpWebRequest;
            //var certificate = FourthCoffeeCertificateService.GetCertificate();
            //request.ClientCertificates.Add(certificate);
            var rawData = Encoding.Default.GetBytes("{\"emailAddress\":\"jesper@fourthcoffee.com\"}");
            var request = WebRequest.Create(uri) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/string";
            request.ContentLength = rawData.Length;
            var dataStream = request.GetRequestStream();
            dataStream.Write(rawData, 0, rawData.Length);
            dataStream.Close();
            var response = request.GetResponse() as HttpWebResponse;
            var stream = new StreamReader(response.GetResponseStream());
            stream.Close();
        }
    }
}
