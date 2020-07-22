using System;
using System.Numerics;
using System.Reflection;
using WebServices.Logs;

namespace WebServices.Controller
{
    public class FibonacciController
    {
        /// <summary>
        /// This method is used by the service and the unit tests in order to calculate the nth element in the Fibunacci sequence.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string Fibonacci(int n)
        {
            try
            {
                // BigInteger is used by the library System.Numerics to accept large numbers (Fibonacci(100) = 354224848179261915075)

                if (n < 1 || n > 100)
                    return (-BigInteger.One).ToString();

                return FastDoublingFibonacci(n).ToString();
            }
            catch (Exception ex)
            {
                Logger.Exception(MethodBase.GetCurrentMethod().Name + " : " + ex.Message.ToString());
                return BigInteger.Zero.ToString();
            }
        }

        /// <summary>
        /// This method is the implementation of the Fast doubling Fibonacci algorithm with recursion.
        /// Formula : 
        /// F(2k) = F(k)[2F(k+1) - F(k)]
        /// F(2k+1) = F(k+1)² + F(k)²
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private BigInteger FastDoublingFibonacci(int n)
        {
            // The following algorithm : Fast doubling Fibonacci algorithm with recursion

            // Formula : 
            // F(2k) = F(k)[2F(k+1) - F(k)]
            // F(2k+1) = F(k+1)² + F(k)²
            // => recursion based on that

            if (n <= 2)
                return BigInteger.One;

            if (n % 2 == 0)
            {
                int k = n / 2;
                return FastDoublingFibonacci(k) * (2 * FastDoublingFibonacci(k + 1) - FastDoublingFibonacci(k));
            }
            else
            {
                int k = (n - 1) / 2;
                return FastDoublingFibonacci(k + 1) * FastDoublingFibonacci(k + 1) + FastDoublingFibonacci(k) * FastDoublingFibonacci(k);
            }
        }
    }
}