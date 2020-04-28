using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckIndex_ReturnsValueOfIndex()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 16;
            int expected = 16;
            int actual;


            //act
            testList.Add(itemToAdd);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Two_Integers_To_Equal_One_Integer()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 1 + 2;
            int expected = 3;
            int actual;

            //act
            testList.Add(itemToAdd);
            actual = testList.Count;
            
            //assert
            Assert.AreEqual(expected, actual)
        }

        [TestMethod]
        public void Add_NoInput_Equals_Zero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 0;
            int expected = 0;
            int actual;

            //act
            testList.Add(itemToAdd);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        
    // what happens if you add multiple things (or add to a CustomList that already has some values)?
    // what happens to the last-added item?
    // what happens to the Count?

    // what happens if you add more items than the initial Capacity of the CustomList?

}
}
