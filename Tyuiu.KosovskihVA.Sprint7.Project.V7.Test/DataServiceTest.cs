using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tyuiu.KosovskihVA.Sprint7.Project.V7.Lib;

namespace Tyuiu.KosovskihVA.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService service = new DataService();
        [TestMethod]
        public void CalculationTest()
        {
            List<double> doubles = new List<double> { 1, 2, 3, 4, 5 };
            Assert.AreEqual(5, service.Calculation(doubles, "Count"));
            Assert.AreEqual(15.0, service.Calculation(doubles, "Sum"));
            Assert.AreEqual(0.33, Math.Round(service.Calculation(doubles, "Mid"), 2));
            Assert.AreEqual(1, service.Calculation(doubles, "Min"));
            Assert.AreEqual(5, service.Calculation(doubles, "Max"));
        }
        [TestMethod]
        public void ComparisonTest()
        {
            Assert.IsTrue(service.Comparison(2, 1, 0));
            Assert.IsFalse(service.Comparison(2, 1, 1));
            Assert.IsTrue(service.Comparison(1, 2, 1));
            Assert.IsFalse(service.Comparison(1, 2, 0));
            Assert.IsFalse(service.Comparison(1, 2, 2));
        }
    }
}
