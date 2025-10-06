using Tyuiu.DanilovAS.Sprint3.Task6.V22.Lib;
namespace Tyuiu.DanilovAS.Sprint3.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 19;
            int stopValue = 31;

            var res = ds.GetSumTheDivisors(startValue, stopValue);
            var wait = 43;

            Assert.AreEqual(wait, res);

        }
    }
}
