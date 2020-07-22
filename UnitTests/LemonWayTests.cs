using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Numerics;

namespace UnitTests
{
    [TestClass]
    public class LemonWayTests : BaseUnitTest
    {
        /// <summary>
        /// This unit test is used to run all the test cases of the Fibunacci algorithm implemented in the controller.
        /// </summary>
        [TestMethod]
        public void FibunacciTest()
        {
            /// Scenario
            /// 1- Test limit cases : 0 and 100
            /// 2- Test two small numbers : 1 and 10
            /// 3- Test large numbers : 50 and 100

            /// 1- Test limit cases : 0 and 100

            string result = fibonacciCtrl.Fibonacci(0);
            Assert.AreEqual("-1", result, "Fibonacci(0) = -1");

            result = fibonacciCtrl.Fibonacci(101);
            Assert.AreEqual("-1", result, "Fibonacci(101) = 1");

            // 2- Test two small numbers : 1 and 10

            result = fibonacciCtrl.Fibonacci(1);
            Assert.AreEqual("1", result, "Fibonacci(1) = 1");

            result = fibonacciCtrl.Fibonacci(10);
            Assert.AreEqual("55", result, "Fibonacci(10) = 55");

            // 3- Test large numbers : 50 and 100

            result = fibonacciCtrl.Fibonacci(50);
            Assert.AreEqual("12586269025", result, "Fibonacci(50) = 12586269025");

            result = fibonacciCtrl.Fibonacci(100);
            Assert.AreEqual("354224848179261915075", result, "Fibonacci(100) = 354224848179261915075");
        }

        /// <summary>
        /// This unit test is used to run all the test cases of the XML to JSON algorithm implemented in the controller.
        /// </summary>
        [TestMethod]
        public void XmlToJsonTest()
        {
            /// Scenario
            /// 1- Test wrong Format XML
            /// 2- Test Empty XML
            /// 3- Test small Correct Format XML 
            /// 4- Test large Correct Format XML 

            // 1- Test wrong Format XML

            string result = xmlToJsonCtrl.XmlToJson("<foo>hello</bar>");
            Assert.AreEqual(result, "Bad Xml format");

            // 2- Test Empty XML

            result = xmlToJsonCtrl.XmlToJson("");
            Assert.AreEqual(result, "Bad Xml format");

            // 3- Test small Correct Format XML 

            result = RemoveWhiteSpace(xmlToJsonCtrl.XmlToJson("<foo>bar</foo>"));

            var expected1 = new
            {
                foo = "bar"
            };
            string expectedStr = RemoveWhiteSpace(JsonConvert.SerializeObject(expected1, Formatting.Indented));

            Assert.AreEqual(expectedStr, result);

            // 4- Test large Correct Format XML 

            result = RemoveWhiteSpace(xmlToJsonCtrl.XmlToJson(@"<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH>
                </EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>"));

            var expected2 = new
            {
                TRANS = new
                {
                    HPAY = new
                    {
                        ID = "103",
                        STATUS = "3",
                        EXTRA = new
                        {
                            IS3DS = "0",
                            AUTH = "031183"
                        },
                        MLABEL = "501767XXXXXX6700",
                        MTOKEN = "project01"
                    }
                }
            };
            expectedStr = RemoveWhiteSpace(JsonConvert.SerializeObject(expected2, Formatting.Indented));
            Assert.AreEqual(expectedStr, result);
        }
    }
}
