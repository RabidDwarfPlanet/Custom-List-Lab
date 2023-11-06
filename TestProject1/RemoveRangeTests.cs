using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class RemoveRangeTests
    {
        [TestMethod]
        public void RemoveRange_ItemsAreInList_CountDecreasesByRange()
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
            list.RemoveRange(1, 3);

            //Assert
            Assert.AreEqual(3, list.Count);

        }

        [TestMethod]
        public void RemoveRange_ItemsAreInList_ListNoLongerContainsItemsInRangeAfterIndex()
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
            list.RemoveRange(1, 3);

            //Assert
            Assert.IsFalse(list.Contains(2));
            Assert.IsFalse(list.Contains(3));
            Assert.IsFalse(list.Contains(4));

        }

        [TestMethod]
        public void RemoveRange_ItemsAreInList_ItemsAfterRangeAreShiftedDownToFillEmptyIndexes()
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
            list.RemoveRange(1, 3);

            //Assert
            Assert.AreEqual(5, list[1]);
            Assert.AreEqual(6, list[2]);

        }
    }
}