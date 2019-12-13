using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsList
{
    public class GenericList<T> where T : IComparable
    {
        // Constant Fields
        private const int CapacityByDefault = 1;

        private T[] array;

        // Constructor
        public GenericList(int capacity = CapacityByDefault)
        {
            this.Count = 0;
            this.Capacity = capacity;

            this.array = new T[capacity];
        }

        // Properties
        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
            set
            {
                this.array[index] = value;
            }
        }

        // Adding an element
        public void Add(T element)
        {
            this.Count++;
            this.AutoGrow(this.Count);
            this.array[this.Count - 1] = element;
        }

        // Accessing an element by index, 
        public int IndexOf(T element)
        {
            return Array.IndexOf(this.array, element);
        }

        // Removing element by index
        public void RemoveAt(int index)
        {
            this.Count--;
            this.AutoGrow(this.Count);

            Array.Copy(this.array, index + 1, this.array, index, this.Count - index);

            this.array[this.Count] = default(T);
        }

        // Inserting an element at a given position 
        public void Insert(int index, T element)
        {         
            this.Count++;
            this.AutoGrow(this.Count);

            Array.Copy(this.array, index, this.array, index + 1, this.Count - index - 1);

            this.array[index] = element;
        }

        // Clearing the list
        public void Clear()
        {
            this.Count = 0;
            this.Capacity = CapacityByDefault;

            this.array = new T[this.Capacity];
        }

        // Implement auto-grow functionality:
        private void AutoGrow(int capacity)
        {
            if (capacity > this.Capacity)
            {
                this.Capacity *= 2;
                Array.Resize(ref this.array, this.Capacity);
            }
        }
    }
}
