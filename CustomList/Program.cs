namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
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
            //Assert.AreEqual(0, intList.Count);
        }
    }
}