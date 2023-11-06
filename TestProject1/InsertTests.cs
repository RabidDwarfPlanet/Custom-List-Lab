using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class InsertTests
    {
        [TestMethod]
        public void Insert_ItemIsInsertedToList_CountIncreases()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Insert(0, 5);

            //Assert
            Assert.AreEqual(1, list.Count);

        }

        [TestMethod]
        public void Insert_ItemIsInsertedToListWhileItemsAreInTheList_ItemsBehindInsertedItemGetShiftedDownOnePlace()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Insert(2, 3);

            //Assert
            Assert.AreEqual("1, 2, 3, 4", list.ToString());
        }

        [TestMethod]
        public void Insert_ItemIsInsertedToListWhileListIsAtCapacity_CapacityIsProperlyIncreased()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Add(5);
            list.Insert(2, 3);

            //Assert
            Assert.AreEqual(8, list.Capacity);
        }

        [TestMethod]
        public void Insert_MultipleItemsInsertedToList_CapacityIsProperlyIncreased()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Add(6);
            list.Insert(2, 3);
            list.Insert(4, 5);

            //Assert
            Assert.AreEqual("1, 2, 3, 4, 5, 6", list.ToString());
        }
    }
}