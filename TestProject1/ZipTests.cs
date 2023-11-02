using CustomList;

namespace TestProject1
{
    [TestClass]
    public class ZipTests
    {
        [TestMethod]
        public void Zip_ZipSecondListToFirst_FirstListsStringOutputsAlternatingBetweenFirstAndSecondLists()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(3);
            secondList.Add(2);
            secondList.Add(4);
            firstList.Zip(secondList);

            //Assert
            Assert.AreEqual("1, 2, 3, 4", firstList.ToString());

        }

        [TestMethod]
        public void Zip_SecondListIsLongerThanFirst_FirstListsStringOutputsAlternatingBetweenFirstAndSecondListsUtillFirstRunsOutThenRestOfSecondsList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(3);
            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            secondList.Add(8);
            firstList.Zip(secondList);

            //Assert
            Assert.AreEqual("1, 2, 3, 4, 6, 8", firstList.ToString());

        }

        [TestMethod]
        public void Zip_FirstListIsLongerThanSecond_FirstListsStringOutputsAlternatingBetweenFirstAndSecondListsUntilSecondRunsOutThenRestOfFirstsList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(3);
            firstList.Add(5);
            firstList.Add(7);
            secondList.Add(2);
            secondList.Add(4);
            firstList.Zip(secondList);

            //Assert
            Assert.AreEqual("1, 2, 3, 4, 5, 7", firstList.ToString());

        }

        [TestMethod]
        public void Zip_FirstListIsLongerThanSecond_FirstListCountCorrectlyUpdates()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(3);
            firstList.Add(5);
            firstList.Add(7);
            secondList.Add(2);
            secondList.Add(4);
            firstList.Zip(secondList);

            //Assert
            Assert.AreEqual(6, firstList.Count);

        }
    }
}