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
            firstList.Add(3);
            secondList.Add(2);
            secondList.Add(4);
            firstList.Zip(secondList);

        }
    }
}