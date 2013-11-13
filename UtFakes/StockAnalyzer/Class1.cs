using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS.UTFakes
{
     public interface IStockFeed
    {
        int GetSharePrice(string company);
    }

    public class StockAnalyzer
    {
        private IStockFeed stockFeed;
        public StockAnalyzer(IStockFeed feed)
        {
            stockFeed = feed;
        }
        public int GetContosoPrice()
        {
            return stockFeed.GetSharePrice("COOO");
        }
    }
}
