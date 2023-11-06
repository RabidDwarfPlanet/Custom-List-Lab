namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(8);
            list.Add(4);
            list.Add(8);
            list.Add(2);
            list.Add(8);
            int[] array = list.AllIndexesOf(8);
        }
    }
}