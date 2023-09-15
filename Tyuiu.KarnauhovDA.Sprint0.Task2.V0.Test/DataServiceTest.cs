using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarnauhovDA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KarnauhovDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Даниил";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Даниил", res);


        }
    }
}
