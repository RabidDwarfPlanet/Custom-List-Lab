using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void Sort_ItemsAreInList_CountRemainsSame()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Sort();

            //Assert
            Assert.AreEqual(2, list.Count);

        }

        [TestMethod]
        public void Sort_IntsAreInList_ItemsAreProperlySortedByValue()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);
            list.Add(2);
            list.Add(1);
            list.Add(4);
            list.Add(3);
            list.Sort();

            //Assert
            Assert.AreEqual("1, 2, 3, 4, 5, 6", list.ToString());

        }

        [TestMethod]
        public void Sort_StringAreInList_ItemsAreProperlySortedByLetter()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            //Act
            list.Add("banana");
            list.Add("kiwi");
            list.Add("apple");
            list.Add("blueberry");
            list.Add("strawberry");
            list.Add("orange");
            list.Sort();

            //Assert
            Assert.AreEqual("apple, banana, blueberry, kiwi, orange, strawberry", list.ToString());

        }
    }
}