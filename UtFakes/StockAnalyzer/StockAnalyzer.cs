using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS.UTFakes
{
    /// <summary>
    /// 为Fake接口，做准备
    /// </summary>
     public interface IStockFeed
    {
        int GetSharePrice(string company);
        int Price { get; set; }

        //event EventHandler Changed;
         /// <summary>
        /// generic methods 
         /// </summary>
         /// <typeparam name="T"></typeparam>
         /// <returns></returns>
        T GetValue<T>();

    }

    /// <summary>
     /// 为Fake接口，做准备
    /// </summary>
    public class StockAnalyzer
    {
        private IStockFeed stockFeed;
        public event EventHandler Changed;
        public StockAnalyzer(IStockFeed feed)
        {
            stockFeed = feed;
        }
        public int GetContosoPrice()
        {
            return stockFeed.GetSharePrice("COOO");
        }
        public int GetIstockFeedPrice()
        {
            return stockFeed.Price;
        }
        public int SetIstockFeedPrice(int i)
        {
            stockFeed.Price = i;
            return stockFeed.Price;
        }
        public int GetGenericmethods()
        {
            return stockFeed.GetValue<int>();
        }


    }

    /// <summary>
    /// 此类为Fake 系统的DateTime.Now做准备
    /// </summary>
    public class componentUnderTest
    {
        public int GetTheCurrentYear()
        {
            return DateTime.Now.Year;
        }
    }

    /// <summary>
    /// S.UTFakes.Fakes.ShimcomponentUnderTest.AllInstances.GetTheCurrentYear = (componentUnderTest) => { return 1; };
    /// </summary>
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

    public class ClassMethod
    {
        public int return1 { set; get; }

        public string returnClassMethodName()
        {
            return "ClassMethod";
        }
    }

}
