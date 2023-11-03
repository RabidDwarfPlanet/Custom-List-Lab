using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class ClearTests
    {
        [TestMethod]
        public void Clear_NothingIsAddedToList_CountIs0()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Clear();

            //Assert
            Assert.AreEqual(0, list.Count);

        }

        [TestMethod]
        public void Clear_ItemsAreAddedToList_CountIs0()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            //Act
            list.Add("bread");
            list.Add("milk");
            list.Clear();

            //Assert
            Assert.AreEqual(0, list.Count);

        }

        [TestMethod]
        public void Clear_ItemsAreAddedToList_NothingIsInFirstIndex()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            //Act
            list.Add("bread");
            list.Add("milk");
            list.Clear();

            //Assert
            Assert.IsNull(list[0]);

        }

        [TestMethod]
        public void Clear_MoreItemsAreAddedToListThanInitialCapacity_CapacityResets()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            //Act
            list.Add("bread");
            list.Add("milk");
            list.Add("eggs");
            list.Add("cheese");
            list.Add("tea");
            list.Add("flour");
            list.Clear();

            //Assert
            Assert.AreEqual(4, list.Capacity);

        }
    }
}