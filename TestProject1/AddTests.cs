using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void Add_ItemsAddedToList_CountIncreases()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(3);

            //Assert
            Assert.AreEqual(1, intList.Count);
        }

        [TestMethod]
        public void Add_ItemIsAddedToList_ItemIsFoundAt0Index()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(3);

            //Assert
            Assert.AreEqual(3, intList[0]);
        }

        [TestMethod]
        public void Add_MultipleItemsAddedToList_ItemsAreSquentiallyAddedToIndex()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);

            //Assert
            Assert.AreEqual(4, intList[3]);
        }

        [TestMethod]
        public void Add_MoreItemsThanCapacityAdded_ListCapacityDoubles()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            //Assert
            Assert.AreEqual(8, intList.Capacity);
        }

        [TestMethod]
        public void Add_MoreItemsThanCapacityAdded_PreviouslyAddedItemsIndexesRemainUnchanged()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            //Assert
            Assert.AreEqual(1, intList[0]);
        }
    }
}