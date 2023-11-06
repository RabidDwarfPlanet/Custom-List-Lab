using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class ToArrayTests
    {
        [TestMethod]
        public void ToArray_ItemsAreAddedToList_ArrayHasSameCountAsList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] array = list.ToArray();

            //Assert
            Assert.AreEqual(list.Count, array.Length);

        }

        [TestMethod]
        public void ToArray_ItemsAreAddedToList_IndexOfItemsIsSameInListAndArray()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] array = list.ToArray();

            //Assert
            Assert.AreEqual(list[1], array[1]);

        }

        [TestMethod]
        public void ToArray_ItemsAreAddedToList_IndexOfArrayIsExpectedResult()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] array = list.ToArray();

            //Assert
            Assert.AreEqual(2, array[1]);

        }


    }
}