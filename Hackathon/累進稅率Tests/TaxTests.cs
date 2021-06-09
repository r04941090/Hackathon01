using Microsoft.VisualStudio.TestTools.UnitTesting;
using 累進稅率;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 累進稅率.Tests
{
    [TestClass()]
    public class TaxTests
    {
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        [DataTestMethod()]
        public void calculateTest(decimal YearSalary, decimal expected)
        {
            var give = new Tax(YearSalary);
            decimal actual = give.calculate();
            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 100000m, 5000m };
            yield return new object[] { 540000m, 27000m };
            yield return new object[] { 540001m, 27000.12m };
            yield return new object[] { 1210000m, 107400m };
            yield return new object[] { 1218000m, 109000m };
            yield return new object[] { 2420000m, 349400m };
            yield return new object[] { 2500000m, 373400m };
            yield return new object[] { 4530000m, 982400m };
            yield return new object[] { 5530000m, 1382400m };
            yield return new object[] { 10310000m, 3294400m };
            yield return new object[] { 10710000m, 3494400m };

        }
    }
}