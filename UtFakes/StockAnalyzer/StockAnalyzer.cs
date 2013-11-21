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
        public static int a {get;set; }
        static Y2KChecker()
        {
            a = 2;
        }
        public static void Check()
        {
            if (DateTime.Now == new DateTime(2000, 1, 1))
                throw new ApplicationException("y2kbug!");
        }

        public static int return5()
        {
            return 5;
        }

        public static int returnA()
        {
            return a;
        }
    }

    public class ClassMethod
    {

        public int Value { set; get; }
        public ClassMethod(int value)
        {
            this.Value = value;
        }
        public int return1 { set; get; }

        public string returnClassMethodName()
        {
            return "ClassMethod";
        }
        private string returnClassPrivateMethodName()
        {
            return "ClassMethod";
        }
        public string TestreturnClassPrivateMethodName()
        {
            return this.returnClassPrivateMethodName();
        }
        public string ClassPrivateMethodName()
        {
            return "Test";
        }
    }

    public class UseClassMethod
    {
        ClassMethod clas=new ClassMethod(1);
        public string GetTestreturnClassPrivateMethodName()
        {
            return clas.TestreturnClassPrivateMethodName();
        }
    }

    public abstract class MyBase
    {
        public int MyMethod() {
            return 1;
    }
    }

    public class MyChild : MyBase
    {
    }
    
    public class MyEnumerable : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            List<int> i=new List<int>();
            return i as IEnumerator<int>;
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            List<int> i = new List<int>();
            return i as IEnumerator<int>;
        }
    }



}
