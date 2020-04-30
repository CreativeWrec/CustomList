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
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            
            int expected = 5;
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
         
            int expected = 30;
            int actual;
            
            //act
            myList.Add(60);
            myList.Add(30);
            myList.Add(3);
            myList.Add(55);
            myList.Add(350);
           
            myList.Remove(60);
            actual = myList[1];
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveOne_CheckingCount()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;
            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(value1);
            actual = myList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveTwo_VerifyIndexZero()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            int expected = 69;
            
            //act
            myList.Add(60);
            myList.Add(69);
            myList.Add(42);
            myList.Add(347);
            myList.Add(751);
            
            myList.Remove(751);
            myList.Remove(60);

            
            //assert
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveLastInteger_VerifyIndex()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            
            int expected = 42;
            int actual;

            //act
            myList.Add(60);
            myList.Add(69);
            myList.Add(42);
            myList.Add(347);
            myList.Add(42);
            myList.Remove(42);
            
            actual = myList[2];


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_PositiveValuesRemoveOddNumberedValue_VerifyEvenIndex()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            
            int expected = 0;
            int actual;

            //act
            myList.Add(60);
            myList.Add(69);
            myList.Add(42);
            myList.Add(347);
            myList.Add(751);

            myList.Remove(60);
            myList.Remove(69);
            myList.Remove(42);
            myList.Remove(347);
            myList.Remove(751);

            actual = myList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Convert_MultipleValuesIndex_ToString()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            string expected = "12345";
            string actual;

            //act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            actual = myList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Convert_SingleValuesIndex_ToString()
        {
            //arrange
            MyCustomList<int> myList = new MyCustomList<int>();
            string expected = "26";
            string actual;

            //act
            myList.Add(26);

            actual = myList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_MultipleValuesIndex_ToStringWithStrings()
        {
            //arrange
            MyCustomList<string> myList = new MyCustomList<string>();
            string expected = "SunMoonEarth";
            string actual;

            //act
            myList.Add("Sun");
            myList.Add("Moon");
            myList.Add("Earth");


            actual = myList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void ()
        //{
        //    //arrange
        //    MyCustomList<int> myList = new MyCustomList<int>();
        //    string expected;
        //    string actual;

        //    //act
        //    myList.Add();

        //    actual = myList.;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
    
        //[TestMethod]
        //public void ()
        //{
        //    //arrange
        //    MyCustomList<int> myList = new MyCustomList<int>();
        //    string expected;
        //    string actual;

        //    //act
        //    myList.Add();

        //    actual = myList.;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
