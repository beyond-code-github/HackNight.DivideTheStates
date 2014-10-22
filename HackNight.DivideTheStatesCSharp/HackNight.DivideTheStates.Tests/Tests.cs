namespace HackNight.DivideTheStates.Tests
{
    using System.Collections.Generic;

    using HackNight.DivideTheStates.Engine;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void One_Item_One_Box()
        {
            var items = new List<int> { 1 };
            var result = Engine.Divide(1, items);

            Assert.AreEqual(result.Count, 1);
            CollectionAssert.AreEquivalent(result[0], new[] { 0 });
        }
    }
}
