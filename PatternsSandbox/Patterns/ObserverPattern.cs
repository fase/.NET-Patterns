using System;
using System.Collections.Generic;

namespace PatternsSandbox.Patterns
{
    class ObserverPattern : IPattern
    {
        public void RunExample()
        {
            decimal price = 23.50m;

            Stock stock = new Stock("MSFT", price);
            Console.WriteLine("Stock set to {0:C}.", stock.Price);

            Bidder bidderA = new Bidder("Bidder A", stock);
            Bidder bidderB = new Bidder("Bidder B", stock);
            Bidder bidderC = new Bidder("Bidder C", stock);

            stock.Attach(bidderA);
            stock.Attach(bidderB);
            stock.Attach(bidderC);

            price = 24.25m;
            Console.WriteLine("\nStock set to {0:C}.", price);
            stock.Price = price;

            stock.Detach(bidderB);
            Console.WriteLine("\n{0} detached.", bidderB.Name);

            price = 26.75m;
            Console.WriteLine("\nStock set to {0:C}.", price);
            stock.Price = price;
        }

        abstract class StockObservable
        {
            private readonly List<IBidderObserver> _observers = new List<IBidderObserver>();

            public void Attach(IBidderObserver observer)
            {
                _observers.Add(observer);
            }

            public void Detach(IBidderObserver observer)
            {
                _observers.Remove(observer);
            }

            protected void Notify()
            {
                foreach (var observerClient in _observers)
                {
                    observerClient.Update();
                }
            }
        }

        class Stock : StockObservable
        {
            private decimal _price;
            public decimal Price
            {
                get { return _price; }
                set
                {
                    if (_price != value)
                    {
                        _price = value;
                        this.Notify();
                    }
                }
            }

            public string Symbol { get; private set; }

            public Stock(string symbol, decimal startingPrice)
            {
                Symbol = symbol;
                _price = startingPrice;
            }
        }

        interface IBidderObserver
        {
            void Update();
        }

        class Bidder : IBidderObserver
        {
            public string Name { get; private set; }
            private readonly Stock _stock;

            public Bidder(string name, Stock stock)
            {
                Name = name;
                _stock = stock;
            }

            public void Update()
            {
                Console.WriteLine("{0} sees the price of stock {1} change to {2:C}", Name, _stock.Symbol, _stock.Price);
            }
        }
    }
}
