using System.Text.RegularExpressions;
using WebServices.Controller;

namespace UnitTests
{
    /// <summary>
    /// This class contains all the commun uses of unit tests
    /// </summary>
    public class BaseUnitTest
    {
        // Create instances of the different controllers here :

        public readonly FibonacciController fibonacciCtrl = new FibonacciController();
        public readonly XmlToJsonController xmlToJsonCtrl = new XmlToJsonController();

        /// <summary>
        /// This method removes all white spaces from an input string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RemoveWhiteSpace(string str)
        {
            return Regex.Replace(str, @"\s+", "");
        }
    }
}
