using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealtAgency.Models;


namespace TestAgency
{
    
    [TestClass]
    public class ContoraTest
    {
        [TestMethod]
        public void FillData()
        {
            Contora store = new Contora();
            store.FillTestData(10);
            Assert.AreEqual("Flat0", store.Flats[0].Name);

        }
    }
}
