using System.Numerics;
using System.Threading;
using System.Web.Services;
using WebServices.Controller;

namespace WebServices
{
    /// <summary>
    /// Summary description for Services
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Services : WebService
    {
        private readonly FibonacciController fibonacciCtrl = new FibonacciController();
        private readonly XmlToJsonController xmlToJsonCtrl = new XmlToJsonController();

        /// <summary>
        /// This API uses an integer n as a parameter and calculates the nth element in the Fibunacci sequence. 
        /// The result is -1 if n < 1 or n > 100 (and 0 if Exception => See the logs for details)
        /// </summary>
        /// <param name="n">should be between 1 and 100)</param>
        /// <returns></returns>
        [WebMethod]
        public string Fibonacci(int n, int timeout = 0)
        {
            Thread.Sleep(timeout);
            return fibonacciCtrl.Fibonacci(n);
        }

        /// <summary>
        /// This API converts an XML (as a string) to a JSON.
        /// The XML nodes are cleaned before the conversion.
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        [WebMethod]
        public string XmlToJson(string xml, int timeout = 0)
        {
            Thread.Sleep(timeout);
            return xmlToJsonCtrl.XmlToJson(xml);
        }
    }
}
