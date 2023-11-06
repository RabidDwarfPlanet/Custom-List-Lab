using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class LastIndexOfTests
    {
        [TestMethod]
        public void LastIndexOf_ItemIsInList_MethodReturnsIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);

            //Assert
            Assert.AreEqual(0, list.LastIndexOf(5));

        }

        [TestMethod]
        public void LastIndexOf_ItemIsNotInList_MethodReturnsNegitive1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);

            //Assert
            Assert.AreEqual(-1, list.LastIndexOf(1));

        }

        [TestMethod]
        public void LastIndexOf_MultipleInstancesOfItemAreInList_MethodReturnsLastInstancesIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Add(5);
            list.Add(5);

            //Assert
            Assert.AreEqual(3, list.LastIndexOf(5));

        }

        [TestMethod]
        public void LastIndexOf_MultipleInstancesOfItemAreInList_WhenOverloadedOnceWithAStartingIndexPastLastInstanceReturnsNegativeOne()
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
            Assert.AreEqual(-1, list.LastIndexOf(5, 4));

        }

        [TestMethod]
        public void LastIndexOf_MultipleInstancesOfItemAreInList_WhenOverloadedTwiceReturnsLastIndexWithinRange()
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
            Assert.AreEqual(2, list.LastIndexOf(5, 0, 2));

        }

    }
}