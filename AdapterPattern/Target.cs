using System;

namespace AdapterPattern
{
    /// <summary>
    /// The 'Target' class
    /// defines the domain-specific interface that Client uses
    /// </summary>
    class Target
    {
        protected string _stock;
        protected float _stockPrice;
        protected string _stockName;

        // Constructor
        public Target(string stock)
        {
            this._stock = stock;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nStock: {0} ------ ", _stock);
        }
    }
}
