using log4net;
using System.Threading;

namespace WebServices.Logs
{
    public class Logger
    {
        /// <summary>
        /// log is an instance of log4net logger
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger("LemonWay");

        /// <summary>
        /// This method logs a message when an Exception occurs. The type of these logs are Fatal.
        /// </summary>
        /// <param name="message"></param>
        public static void Exception(string message)
        {
            //Log the Exception using log4net
            //The log4net library is used for this action

            //The following condition eliminates the unit tests logging to save memory.
            if (SynchronizationContext.Current != null)
            {
                log.Fatal(message);
            }
        }
    }
}