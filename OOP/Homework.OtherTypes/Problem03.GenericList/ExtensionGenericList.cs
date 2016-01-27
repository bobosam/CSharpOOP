namespace Problem03.GenericList
{
    using System;
    using System.Linq;
    
    public static class ExtensionGenericList
    {
        public static T Max<T>(this GenericList<T> storage)
            where T : IComparable
        {
            T maxElement = storage[0];
            int size = storage.Count();
            for (int i = 1; i < size; i++)
            {
                if (storage[i].CompareTo(maxElement) > 0)
                {
                    maxElement = storage[i];
                }
            }

            return maxElement;
        }

        public static T Min<T>(this GenericList<T> storage)
            where T : IComparable
        {
            T minElement = storage[0];
            int size = storage.Count();
            for (int i = 1; i < size; i++)
            {
                if (storage[i].CompareTo(minElement) < 0)
                {
                    minElement = storage[i];
                }
            }

            return minElement;
        }
    }
}
