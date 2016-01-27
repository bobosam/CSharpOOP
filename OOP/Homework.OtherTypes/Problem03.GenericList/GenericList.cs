namespace Problem03.GenericList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Problem04.GenericList.Version;

    [Version(2, 11)]
    public class GenericList<T> : IGenericList<T>, IEnumerable<T>
    {
        private const int InitialCapacity = 2;

        private int index;
        private int capacity;
        private T[] storage;

        public GenericList()
        {
            this.capacity = InitialCapacity;
            this.storage = new T[InitialCapacity];
            this.index = 0;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public int Size
        {
            get
            {
                return this.storage.Count();
            }
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.storage[index];
            }

            set
            {
                this.ValidateIndex(index);
                this.storage[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.index == this.Capacity)
            {
                this.IncreaseCapacity();
            }

            this.storage[this.index] = item;
            this.index++;
        }

        public void Clear()
        {
            this.storage = new T[InitialCapacity];
            this.index = 0;
        }

        public bool Contain(T item)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (this.storage[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public int Find(T item)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (this.storage[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            this.ValidateIndex(index);
            if (this.index == this.Capacity)
            {
                this.IncreaseCapacity();
            }

            var newStorage = new T[this.capacity];

            for (int i = 0; i < this.index; i++)
            {
                if (i < index)
                {
                    newStorage[i] = this.storage[i];
                }

                if (i == index)
                {
                    newStorage[i] = item;
                    this.index++;
                }

                if (i > index)
                {
                    newStorage[i] = this.storage[i - 1];
                }
            }

            this.storage = newStorage;
        }

        public void Remove(int index)
        {
            this.ValidateIndex(index);
            int size = this.index - 1;
            for (int i = index; i < size; i++)
            {
                this.storage[i] = this.storage[i + 1];
            }

            this.index--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.index; i++)
            {
                yield return this.storage[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            if (0 == this.index)
            {
                return "List is clear.";
            }

            string viewList = string.Empty;

            for (int i = 0; i < this.index; i++)
            {
                viewList += this.storage[i];
                viewList += " ";
            }

            return viewList;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > this.index)
            {
                throw new ArgumentOutOfRangeException(string.Format("The index must be in range [0 - {0}]", this.index));
            }
        }

        private void IncreaseCapacity()
        {
            int newCapacity = 2 * this.Capacity;
            var newStorage = new T[newCapacity];
            for (int i = 0; i < this.capacity; i++)
            {
                newStorage[i] = this.storage[i];
            }

            this.storage = newStorage;
            this.capacity = newCapacity;
        }
    }
}
