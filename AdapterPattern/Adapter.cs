using System;

namespace AdapterPattern
{
    /// <summary>
    /// The 'Adapter' class
    /// adapts the interface Adaptee to the Target interface.
    /// </summary>
    class Adapter : Target
    {
        private Adaptee _bank;

        // Constructor
        public Adapter(string name)
            : base(name)
        {
        }

        public override void Display()
        {
            // The Adaptee
            _bank = new Adaptee();

            _stockName = _bank.GetStockName(_stock);
            _stockPrice = _bank.GetStockPrice(_stock);

            base.Display();
            Console.WriteLine(" Stock Name: {0}", _stockName);
            Console.WriteLine(" Stock Price: {0}", _stockPrice);
        }
    }
}
