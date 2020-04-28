using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OnePositiveInteger_OneValue()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 6;
            int expected = 1;
            int actual;
            //act
            myList.Add(value1);
            actual = myList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FourPositiveInteger_CountEqualsFour()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 6;
            int value2 = 7;
            int value3 = 10;
            int value4 = 700;
            int expected = 4;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            actual = myList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreePositiveValues_CheckingIndexZero()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 30;
            int value3 = 3;
            int expected = 60;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreePositiveValues_CheckingIndexOne()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 30;
            int value3 = 3;
            int expected = 30;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList[1];
            myList[4] = 60;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreePositiveValues_CheckingCapacity()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 30;
            int value3 = 3;
            int expected = 4;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_CheckingCount()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 30;
            int value3 = 3;
            int value4 = 55;
            int value5 = 350;
            int expected = 5;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_CheckingCapacity()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 30;
            int value3 = 3;
            int value4 = 55;
            int value5 = 350;
            int expected = 8;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Add_FivePositiveValues_CheckingCapacity()
        //{
        //    //arrange
        //    MyCustomList<int> myList = new MyCustomList<int>();
        //    int value1 = 60;
        //    int value2 = 30;
        //    int value3 = 3;
        //    int value4 = 55;
        //    int value5 = 350;
        //    int expected = 8;
        //    int actual;
        //    //act
        //    myList.Add(value1);
        //    myList.Add(value2);
        //    myList.Add(value3);
        //    myList.Add(value4);
        //    myList.Add(value5);
        //    actual = myList.Capacity;
        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void Add_FivePositiveValues_CheckingIndexZero()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 30;
            int value3 = 3;
            int value4 = 55;
            int value5 = 350;
            int expected = 60;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_CheckingIndexFour()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 30;
            int value3 = 3;
            int value4 = 55;
            int value5 = 350;
            int expected = 350;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList[4];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveOne_CheckingIndexZero()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 30;
            int value3 = 3;
            int value4 = 55;
            int value5 = 350;
            int expected = 30;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(value1);
            actual = myList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveOne_CheckingIndexZero1()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 60;
            int value2 = 60;
            int value3 = 60;
            int value4 = 60;
            int value5 = 60;
            int expected = 60;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(60);
            actual = myList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
