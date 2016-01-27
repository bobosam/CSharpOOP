namespace Problem03.GenericList
{
    public interface IGenericList<T>
    {
        int Capacity { get; }

        int Size { get; }

        T this[int index] { get;  set; }

        void Add(T item);

        void Remove(int index);

        void Insert(int index, T item);

        void Clear();

        int Find(T item);

        bool Contain(T item);
    }
}
