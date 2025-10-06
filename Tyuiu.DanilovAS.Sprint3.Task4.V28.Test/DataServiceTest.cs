using Microsoft.ApplicationInsights.Metrics.Extensibility;
using Tyuiu.DanilovAS.Sprint3.Task4.V28.Lib;
namespace Tyuiu.DanilovAS.Sprint3.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var wait = -2.472;
            var res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);

        }
    }
}
