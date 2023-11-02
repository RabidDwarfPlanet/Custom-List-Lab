using CustomList;

namespace TestProject1
{
    [TestClass]
    public class TrimExcessTests
    {
        [TestMethod]
        public void TrimExcess_NoItemsAreInList_CapacityRemains4()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.TrimExcess();

            //Assert
            Assert.AreEqual(4, list.Capacity);

        }

        [TestMethod]
        public void TrimExcess_LessThan4ItemsAdded_CapacityRemains4()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.TrimExcess();

            //Assert
            Assert.AreEqual(4, list.Capacity);

        }

        [TestMethod]
        public void TrimExcess_MoreThan4ItemsAdded_CountMatchesCapacity()
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
            list.TrimExcess();

            //Assert
            Assert.AreEqual(list.Count, list.Capacity);

        }

        [TestMethod]
        public void TrimExcess_MoreThan4ItemsAdded_ExpectedCountMatchesCapacity()
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
            list.TrimExcess();

            //Assert
            Assert.AreEqual(6, list.Capacity);

        }


    }
}