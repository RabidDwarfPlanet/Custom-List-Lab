using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class ReverseTests
    {
        [TestMethod]
        public void Reverse_ItemIsInList_CountRemainsSame()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Reverse();

            //Assert
            Assert.AreEqual(2, list.Count);

        }


        [TestMethod]
        public void Reverse_ItemsAreInList_ItemsIndexesAreFlipped()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Reverse();

            //Assert
            Assert.AreEqual(6, list[0]);
        }

        [TestMethod]
        public void Reverse_ManyItemAreInList_ItemsIndexesAreProperlyFlipped()
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
            list.Reverse();

            //Assert
            Assert.AreEqual("6, 5, 4, 3, 2, 1", list.ToString());
        }


    }
}