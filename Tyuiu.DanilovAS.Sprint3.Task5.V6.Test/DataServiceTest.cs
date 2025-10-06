using Tyuiu.DanilovAS.Sprint3.Task5.V6.Lib;
namespace Tyuiu.DanilovAS.Sprint3.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            DataService ds = new DataService();

            int startValueOne = 1;
            int stopValueOne = 3;
            int startValueTwo = 1;
            int stopValueTwo = 10;

            var res = ds.GetSumSumSeries(startValueOne, startValueTwo, stopValueOne, stopValueTwo);
            var wait = 40.917;

            Assert.AreEqual(wait, res);
        }
    }
}
