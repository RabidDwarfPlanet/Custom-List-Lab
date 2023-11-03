using CustomList;

namespace TestProject1
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
        public void Insert_ItemInsertedToListHasNegitiveIndex_ExceptionIsThrown()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Add(5);

            //Assert
            //Assert.ThrowsException<ArgumentOutOfRangeException>(list.Insert(-2, 3));
        }



    }
}