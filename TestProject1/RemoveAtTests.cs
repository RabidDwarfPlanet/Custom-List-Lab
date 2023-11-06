using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class RemoveAtTests
    {
        [TestMethod]
        public void RemoveAt_ItemsAreInList_CountDecreases()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.RemoveAt(1);

            //Assert
            Assert.AreEqual(1, list.Count);

        }

        [TestMethod]
        public void RemoveAt_ItemsAreInList_ItemInDefinedIndexIsRemoved()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.RemoveAt(1);

            //Assert
            Assert.AreEqual(0, list[1]);
        }

        [TestMethod]
        public void RemoveAt_ItemsAreBehindRemovedInList_ItemsBehindRemovedItemMoveForward()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.RemoveAt(1);

            //Assert
            Assert.AreEqual(7, list[1]);
        }


    }
}