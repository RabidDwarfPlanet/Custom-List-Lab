using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class MinusOperatorTests
    {
        [TestMethod]
        public void MinusOperator_SecondListMinusFirstList_ToStringOutputsFirstListWithoutItemsInSecondList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            secondList.Add(5);
            secondList.Add(1);
            secondList.Add(4);
            CustomList<int> reducedList = firstList - secondList;

            //Assert
            Assert.AreEqual("2, 3", reducedList.ToString());

        }

        [TestMethod]
        public void MinusOperator_SecondListIsLongerThanFirstList_ToStringOutputsFirstListWithoutItemsInSecondList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            secondList.Add(5);
            secondList.Add(1);
            secondList.Add(4);
            secondList.Add(6);
            secondList.Add(5);
            CustomList<int> reducedList = firstList - secondList;

            //Assert
            Assert.AreEqual("2, 3", reducedList.ToString());

        }

        [TestMethod]
        public void MinusOperator_FirstListIsLongerThanSecondList_ToStringOutputsFirstListWithoutItemsInSecondList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(5);
            firstList.Add(6);
            secondList.Add(1);
            secondList.Add(5);
            secondList.Add(6);
            CustomList<int> reducedList = firstList - secondList;

            //Assert
            Assert.AreEqual("2, 3", reducedList.ToString());

        }

        [TestMethod]
        public void MinusOperator_MultipleInstancesOfAnItemInFirstListAreInSecondList_ToStringOutputsFirstListWithoutOnlySameAmountOfItemsInSecondList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(4);
            secondList.Add(1);
            secondList.Add(1);
            secondList.Add(4);
            CustomList<int> reducedList = firstList - secondList;

            //Assert
            Assert.AreEqual("1, 1", reducedList.ToString());

        }

        [TestMethod]
        public void MinusOperator_MultipleInstancesOfAnItemInFirstListAreInSecondList_ToStringOutputsOfFirstListRemainsUnchanged()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(4);
            secondList.Add(1);
            secondList.Add(1);
            secondList.Add(4);
            CustomList<int> reducedList = firstList - secondList;

            //Assert
            Assert.AreEqual("1, 1, 1, 1, 4", firstList.ToString());

        }

        [TestMethod]
        public void MinusOperator_MultipleInstancesOfAnItemInFirstListAreInSecondList_ToStringOutputsOfSecondListRemainsUnchanged()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(1);
            firstList.Add(4);
            secondList.Add(1);
            secondList.Add(1);
            secondList.Add(4);
            CustomList<int> reducedList = firstList - secondList;

            //Assert
            Assert.AreEqual("1, 1, 4", secondList.ToString());

        }
    }
}