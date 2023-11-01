using CustomList;

namespace TestProject1
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void Remove_RemoveAddedItemFromList_CountDecreases()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(3);
            intList.Remove(3);

            //Assert
            Assert.AreEqual(0, intList.Count);
        }

        [TestMethod]
        public void Remove_RemoveAddedItemFromList_Index0Is0()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(3);
            intList.Remove(3);

            //Assert
            Assert.AreEqual(0, intList[0]);
        }

        [TestMethod]
        public void Remove_RemoveAddedItemFromList_Index0IsNullIfStrings()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();

            //Act
            stringList.Add("ello");
            stringList.Remove("ello");

            //Assert
            Assert.IsNull(stringList[0]);
        }

        [TestMethod]
        public void Remove_RemoveAddedItemFromList_MethodReturnsTrue()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();

            //Act
            stringList.Add("ello");
            bool removed = stringList.Remove("ello");

            //Assert
            Assert.IsTrue(removed);
        }

        [TestMethod]
        public void Remove_RemoveWhileNothingIsInList_MethodReturnsFalse()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(1);
            bool removed = intList.Remove(3);

            //Assert
            Assert.IsFalse(removed);
        }

        [TestMethod]
        public void Remove_RemoveWhileNothingIsInList_CountRemainsTheSame()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(1);
            bool removed = intList.Remove(3);

            //Assert
            Assert.AreEqual(1, intList.Count);
        }

        [TestMethod]
        public void Remove_RemoveItemWhileItemsAreAfterItInList_ItemsBehindMoveForward()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Remove(3);

            //Assert
            Assert.AreEqual(4, intList[2]);
        }

        [TestMethod]
        public void Remove_RemoveItemWhileMultipleInstancesArePresent_OnlyFirstInstanceIsRemoved()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(3);
            intList.Add(3);
            intList.Add(3);
            intList.Add(3);
            intList.Remove(3);

            //Assert
            Assert.AreEqual(3, intList[2]);
        }
    }
}
