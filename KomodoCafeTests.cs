using KomodoCafe_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoCafe_Tests
{
    [TestClass]
    public class KomodoCafeTests
    {
        [TestMethod]
        public void CreateItem_ShouldMakeItems()
        {
            Menu items = new Menu();
            items.MealName = "Food";

            string expected = "Food";
            string actual = items.MealName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 
        {
        }
    }
}
