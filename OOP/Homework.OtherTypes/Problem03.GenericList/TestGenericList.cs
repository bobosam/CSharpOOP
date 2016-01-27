namespace Problem03.GenericList
{
    using System;

    public class TestGenericList
    {
        public static void Main()
        {
            var list = new GenericList<int> { 1, 2 };

            Console.WriteLine(list);

            list.Add(5);
            Console.WriteLine(list);

            var minElement = list.Min();
            var maxElement = list.Max();
            Console.WriteLine("min --> {0}", minElement);
            Console.WriteLine("max --> {0}", maxElement);

            list.Add(25);
            Console.WriteLine(list);
            list.Remove(1);
            Console.WriteLine(list);

            list.Insert(2, 16);
            Console.WriteLine(list);

            int index = list.Find(16);
            Console.WriteLine("index --> {0}", index);

            bool contains = list.Contain(5);
            Console.WriteLine(contains);
            contains = list.Contain(13);
            Console.WriteLine(contains);

            list.Clear();
            Console.WriteLine(list);

            Console.WriteLine();
            object[] versionAttributes = typeof(GenericList<string>).GetCustomAttributes(false);
            Console.WriteLine("Version --> {0}\n", versionAttributes[1]);
        }
    }
}
