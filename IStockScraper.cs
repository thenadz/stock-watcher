using System;

namespace StockWatcher
{
    interface IStockScraper : IDisposable
    {
        void Start();
    }
}
