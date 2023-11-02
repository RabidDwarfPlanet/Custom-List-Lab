using CustomList;

namespace TestProject1
{
    [TestClass]
    public class ToStringsTests
    {
        [TestMethod]
        public void ToString_WhenStringsAreAddedToTheList_ReturnStringsAsOneString()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();

            //Act
            stringList.Add("bread");
            stringList.Add("milk");

            //Assert
            Assert.AreEqual("bread, milk", stringList.ToString());
        }

        [TestMethod]
        public void ToString_WhenIntsAreAddedToTheList_ReturnIntsAsOneString()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(3);
            intList.Add(5);

            //Assert
            Assert.AreEqual("3, 5", intList.ToString());
        }

        [TestMethod]
        public void ToString_WhenNothingIsAddedToTheList_ReturnsEmptyString()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act


            //Assert
            Assert.AreEqual("", intList.ToString());
        }

        [TestMethod]
        public void ToString_WhenAllItemsAreRemovedFromList_ReturnsEmptyString()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            //Act
            intList.Add(3);
            intList.Add(5);
            intList.Remove(5);
            intList.Remove(3);

            //Assert
            Assert.AreEqual("", intList.ToString());
        }
    }
}