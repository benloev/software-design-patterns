using System;

namespace AdapterPattern
{
    class Client
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Non-adapted chemical compound
            Target unknown = new Target("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Target goog = new Adapter("GOOG");
            goog.Display();

            Target msft = new Adapter("MSFT");
            msft.Display();

            Target aapl = new Adapter("AAPL");
            aapl.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
