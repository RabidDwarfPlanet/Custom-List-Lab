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

    }
}