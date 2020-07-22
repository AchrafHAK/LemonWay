using ConsoleClient.LemonWayServiceReference;
using System;
using System.Threading.Tasks;

namespace ConsoleClient.ClientController
{
    public class LemonWayClient
    {
        /// <summary>
        /// service is an instance of the ServicesSoapClient related to the connected service : LemonWayServiceReference
        /// </summary>
        public static ServicesSoapClient service = new ServicesSoapClient();

        /// <summary>
        /// This method calls the client Fibonacci asynchronously
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public async static Task<string> FibonacciConsoleClientAsync(int val)
        {
            FibonacciResponse returnedValue = await service.FibonacciAsync(val);
            return returnedValue.Body.FibonacciResult;
        }

        /// <summary>
        /// This method calls the client XmlToJson asynchronously
        /// </summary>
        /// <param name="xString"></param>
        /// <returns></returns>
        public async static Task<string> XmlToJsonConsoleClientAsync(string xString)
        {
            XmlToJsonResponse returnedString = await service.XmlToJsonAsync(xString);
            return returnedString.Body.XmlToJsonResult;
        }
    }
}
