using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class IndexOfTests
    {
        [TestMethod]
        public void IndexOf_ItemIsInList_MethodReturnsIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);

            //Assert
            Assert.AreEqual(1, list.IndexOf(6));

        }

        [TestMethod]
        public void Contains_ItemIsInList_MethodReturnsNegitive1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);

            //Assert
            Assert.AreEqual(-1, list.IndexOf(1));

        }

        [TestMethod]
        public void Contains_MultipleInstancesOfItemAreInList_MethodReturnsFirstInstance()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Add(5);

            //Assert
            Assert.AreEqual(0, list.IndexOf(5));

        }

        [TestMethod]
        public void IndexOf_MultipleInstancesOfItemAreInList_WhenOverloadedOnceReturnsFirstIndexAfterStartingIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Add(5);
            list.Add(5);
            list.Add(7);
            list.Add(9);

            //Assert
            Assert.AreEqual(3, list.IndexOf(5, 3));

        }

        [TestMethod]
        public void IndexOf_MultipleInstancesOfItemAreInList_WhenOverloadedTwiceReturnsFirstIndexWithinRange()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Add(5);
            list.Add(5);
            list.Add(7);
            list.Add(9);

            //Assert
            Assert.AreEqual(2, list.IndexOf(5, 1, 3));

        }

        [TestMethod]
        public void IndexOf_MultipleInstancesOfItemAreInList_WhenOverloadedTwiceAndNoInstancesAreInRangeReturnsNegativeOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Add(5);
            list.Add(2);
            list.Add(7);
            list.Add(9);
            list.Add(5);

            //Assert
            Assert.AreEqual(-1, list.IndexOf(5, 3, 2));

        }



    }
}