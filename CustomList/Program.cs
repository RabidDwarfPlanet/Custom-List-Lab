namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();

            //Act
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(5);
            firstList.Add(6);
            secondList.Add(1);
            secondList.Add(6);
            secondList.Add(5);
            CustomList<int> reducedList = firstList - secondList;

            //Assert
            //Assert.AreEqual("2, 3", reducedList.ToString());
        }
    }
}