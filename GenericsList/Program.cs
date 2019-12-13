using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsList;

namespace GenericsList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> arrayList = new GenericList<int>();

            // Auto-grow and Add 
            arrayList = new GenericList<int>(2);
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);

            Console.WriteLine("Count: {0}", arrayList.Count);
            Console.WriteLine("Capacity: {0}", arrayList.Capacity);

            // Insert, RemoveAt
            arrayList.Clear();

            arrayList.Insert(0, 4);
            arrayList.Insert(0, 3);
            arrayList.Insert(0, 2);
            arrayList.Insert(0, 1);

            arrayList.RemoveAt(0);
            arrayList.RemoveAt(arrayList.Count - 1);

            Console.WriteLine("Count: {0}", arrayList.Count);
            Console.WriteLine("Capacity: {0}", arrayList.Capacity);

            // IndexOf
            Console.WriteLine("Index of element 3: {0}", arrayList.IndexOf(3));

            Console.ReadLine();
        }
    }
}
