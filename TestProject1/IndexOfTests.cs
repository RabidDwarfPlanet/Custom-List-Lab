using CustomList;

namespace TestProject1
{
    [TestClass]
    public class IndexOfTests
    {
        [TestMethod]
        public void IndexOf_ItemIsInList_MethodReturns1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);

            //Assert
            Assert.AreEqual(1, list.IndexOf(6));

        }

        [TestMethod]
        public void Contains_ItemIsInList_MethodReturnsTrue()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(5);
            list.Add(6);

            //Assert
            Assert.AreEqual(-1, list.IndexOf(1));

        }



    }
}