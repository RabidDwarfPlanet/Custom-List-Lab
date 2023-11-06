using CustomList;

namespace CustomListsTests
{
    [TestClass]
    public class AllIndexesOfTests
    {
        [TestMethod]
        public void AllIndexesOf_NoItemsInList_MethodReturnsEmptyArray()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            int[] array = list.AllIndexesOf(5);

            //Assert
            Assert.AreEqual(0, array.Length);

        }

        [TestMethod]
        public void AllIndexesOf_OneInstanceInList_MethodReturnsArrayWithItemsIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(8);
            list.Add(4);
            list.Add(2);
            int[] array = list.AllIndexesOf(4);

            //Assert
            Assert.AreEqual(1, array[0]);

        }

        [TestMethod]
        public void AllIndexesOf_MultipleInstancesInList_ArrayLengthMatchesNumberOfInstances()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(8);
            list.Add(4);
            list.Add(8);
            list.Add(2);
            list.Add(8);
            int[] array = list.AllIndexesOf(8);

            //Assert
            Assert.AreEqual(3, array.Length);

        }

        [TestMethod]
        public void AllIndexesOf_MultipleInstancesInList_AllInstancesIndexesAppearInArray()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(8);
            list.Add(4);
            list.Add(8);
            list.Add(2);
            list.Add(8);
            int[] array = list.AllIndexesOf(8);

            //Assert
            Assert.AreEqual(0, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(4, array[2]);
        }

        [TestMethod]
        public void AllIndexesOf_MultipleInstancesInList_WhenOverloadedOnceAllInstancesIndexesAfterStartIndexAppearInArray()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(8);
            list.Add(4);
            list.Add(8);
            list.Add(2);
            list.Add(8);
            int[] array = list.AllIndexesOf(8, 1);

            //Assert
            Assert.AreEqual(2, array[0]);
            Assert.AreEqual(4, array[1]);
        }

        [TestMethod]
        public void AllIndexesOf_MultipleInstancesInList_WhenOverloadedTwiceAllInstancesIndexesBetweenStartAndEndIndexAppearInArray()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(8);
            list.Add(4);
            list.Add(8);
            list.Add(2);
            list.Add(8);
            list.Add(8);
            int[] array = list.AllIndexesOf(8, 1, 4);

            //Assert
            Assert.AreEqual(2, array[0]);
            Assert.AreEqual(4, array[1]);
        }
    }
}