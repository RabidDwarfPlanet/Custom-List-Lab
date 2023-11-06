using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class ContainsTests
    {
        [TestMethod]
        public void Contains_ItemIsInList_MethodReturnsTrue()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);

            //Assert
            Assert.IsTrue(list.Contains(6));

        }

        [TestMethod]
        public void Contains_ItemIsNotInList_MethodReturnsFalse()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);

            //Assert
            Assert.IsFalse(list.Contains(6));

        }

        [TestMethod]
        public void Contains_ItemIsNotInList_WhenOverloadedOnceAndItemIsNotInRangeMethodReturnsFalse()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);


            //Assert
            Assert.IsFalse(list.Contains(2, 2));

        }

        [TestMethod]
        public void Contains_ItemIsNotInList_WhenOverloadedOnceAndItemIsInRangeMethodReturnsTrue()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);


            //Assert
            Assert.IsTrue(list.Contains(2, 1));

        }

        [TestMethod]
        public void Contains_ItemIsNotInList_WhenOverloadedTwiceAndItemIsNotInRangeMethodReturnsFalse()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);


            //Assert
            Assert.IsFalse(list.Contains(6, 1, 4));

        }

        [TestMethod]
        public void Contains_ItemIsNotInList_WhenOverloadedTwiceAndItemIsInRangeMethodReturnsTrue()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);


            //Assert
            Assert.IsTrue(list.Contains(3, 1, 4));

        }

    }
}