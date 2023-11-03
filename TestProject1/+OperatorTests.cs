using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class PlusOperatorTests
    {
        [TestMethod]
        public void PlusOperator_FirstListIsLonger_ToStringOutputsFirstListCombinedWithSecond()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            secondList.Add(5);
            secondList.Add(6);
            CustomList<int> combinedList = firstList + secondList;

            //Assert
            Assert.AreEqual("1, 2, 3, 4, 5, 6", combinedList.ToString());

        }

        [TestMethod]
        public void PlusOperator_SecondListIsLonger_ToStringOutputsFirstListCombinedWithSecond()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(2);
            secondList.Add(3);
            secondList.Add(4);
            secondList.Add(5);
            secondList.Add(6);
            CustomList<int> combinedList = firstList + secondList;

            //Assert
            Assert.AreEqual("1, 2, 3, 4, 5, 6", combinedList.ToString());

        }

        [TestMethod]
        public void PlusOperator_SecondListIsEmpty_ToStringOutputIsTheSameAsFirstList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            CustomList<int> combinedList = firstList + secondList;

            //Assert
            Assert.AreEqual(firstList.ToString(), combinedList.ToString());

        }

        [TestMethod]
        public void PlusOperator_FirstListIsEmpty_ToStringOutputIsTheSameAsSecondList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            secondList.Add(1);
            secondList.Add(2);
            secondList.Add(3);
            secondList.Add(4);
            CustomList<int> combinedList = firstList + secondList;

            //Assert
            Assert.AreEqual(secondList.ToString(), combinedList.ToString());

        }
    }
}