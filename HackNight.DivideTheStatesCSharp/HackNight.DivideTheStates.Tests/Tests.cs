namespace HackNight.DivideTheStates.Tests
{
    using System.Collections.Generic;
    using System.Linq;

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

            Assert.AreEqual(1, result[0].Sum());
        }

        [TestMethod]
        public void Two_Ones_One_Box()
        {
            var items = new List<int> { 1, 1 };
            var result = Engine.Divide(1, items);

            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[0].Sum());
        }

        [TestMethod]
        public void Two_Ones_Two_Boxes()
        {
            var items = new List<int> { 1, 1 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 1 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Four_Ones_Two_Boxes()
        {
            var items = new List<int> { 1, 1, 1, 1 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Three_Ones_Two_Boxes()
        {
            var items = new List<int> { 1, 1, 1 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Six_Ones_Three_Boxes()
        {
            var items = new List<int> { 1, 1, 1, 1, 1, 1 };
            var result = Engine.Divide(3, items);

            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[1].Sum());
            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[2].Sum());
        }

        [TestMethod]
        public void Five_Ones_Three_Boxes()
        {
            var items = new List<int> { 1, 1, 1, 1, 1 };
            var result = Engine.Divide(3, items);

            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[1].Sum());
            Assert.AreEqual(new[] { 1 }.Sum(), result[2].Sum());
        }

        [TestMethod]
        public void Test_2_1_1_Two_Boxes()
        {
            var items = new List<int> { 2, 1, 1 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 2 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Test_1_2_1_Two_Boxes()
        {
            var items = new List<int> { 1, 2, 1 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 2 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Test_1_1_2_Two_Boxes()
        {
            var items = new List<int> { 1, 1, 2 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 1, 1 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 2 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Test_1_2_3_Two_Boxes()
        {
            var items = new List<int> { 1, 2, 3 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 1, 2 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 3 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Test_3_1_2_Two_Boxes()
        {
            var items = new List<int> { 3, 1, 2 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 3 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1, 2 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Test_2_3_1_Two_Boxes()
        {
            var items = new List<int> { 2, 3, 1 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 3 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1, 2 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Test_10_2_1_Two_Boxes()
        {
            var items = new List<int> { 10, 2, 1 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 10 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 1, 2 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Test_10_1_100_Two_Boxes()
        {
            var items = new List<int> { 10, 1, 100 };
            var result = Engine.Divide(2, items);

            Assert.AreEqual(new[] { 100 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 10,1 }.Sum(), result[1].Sum());
        }

        [TestMethod]
        public void Test_10_1_100_2_500_Three_Boxes()
        {
            var items = new List<int> { 10, 1, 100, 2, 500 };
            var result = Engine.Divide(3, items);

            Assert.AreEqual(new[] { 500 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 100 }.Sum(), result[1].Sum());
            Assert.AreEqual(new[] { 13 }.Sum(), result[2].Sum());
        }

        [TestMethod]
        public void Test_1_2_4_8_16_Three_Boxes()
        {
            var items = new List<int> { 1, 2, 4, 8, 16 };
            var result = Engine.Divide(3, items);

            Assert.AreEqual(new[] { 16 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 8 }.Sum(), result[1].Sum());
            Assert.AreEqual(new[] { 7 }.Sum(), result[2].Sum());
        }

        [TestMethod]
        public void Test_100_Then_Ones_Three_Boxes()
        {
            var items = new List<int> { 100 };
            items.AddRange(Enumerable.Repeat(1, 100));

            var result = Engine.Divide(3, items);

            Assert.AreEqual(new[] { 100 }.Sum(), result[0].Sum());
            Assert.AreEqual(new[] { 50 }.Sum(), result[1].Sum());
            Assert.AreEqual(new[] { 50 }.Sum(), result[2].Sum());
        }
    }
}
