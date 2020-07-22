using ConsoleClient.ClientController;
using log4net;
using System;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\nSection : Fibonacci\n");

                DisplayFibonacciResultInConsole(0);
                DisplayFibonacciResultInConsole(1);
                DisplayFibonacciResultInConsole(10);
                DisplayFibonacciResultInConsole(50);
                DisplayFibonacciResultInConsole(100);
                DisplayFibonacciResultInConsole(101);

                Console.WriteLine("\nSection : XmlToJson\n");

                DisplayXmlToJsonResultInConsole("<foo>hello</bar>");
                DisplayXmlToJsonResultInConsole("");
                DisplayXmlToJsonResultInConsole("<foo>bar</foo>");
                DisplayXmlToJsonResultInConsole(@"<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH>
                    </EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Console APP Exception: " + ex.Message.ToString());
            }
        }

        /// <summary>
        /// This method calls the Fibonacci client controller and displays the output to the console
        /// </summary>
        /// <param name="n"></param>
        static private void DisplayFibonacciResultInConsole(int n)
        {
            Console.Write("Fibunacci(" + n.ToString() + ") = ");
            string result = LemonWayClient.FibonacciConsoleClientAsync(n).Result.ToString();
            Console.WriteLine(result + "\n");
        }

        /// <summary>
        /// This method calls the XmlToJson client controller and displays the output to the console
        /// </summary>
        /// <param name="xmlStr"></param>
        static private void DisplayXmlToJsonResultInConsole(string xmlStr)
        {
            Console.Write("XmlToJson(" + xmlStr + ") = ");
            string result = LemonWayClient.XmlToJsonConsoleClientAsync(xmlStr).Result.ToString();
            Console.WriteLine(result + "\n");
        }
    }
}
