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



    }
}