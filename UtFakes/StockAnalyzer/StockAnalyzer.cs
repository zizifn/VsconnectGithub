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

    public class componentUnderTest
    {
        public int GetTheCurrentYear()
        {
            return DateTime.Now.Year;
        }
    }

    // code under test
    public static class Y2KChecker
    {
        public static void Check()
        {
            if (DateTime.Now == new DateTime(2000, 1, 1))
                throw new ApplicationException("y2kbug!");
        }

        public static int return5()
        {
            return 5;
        }
    }
}
