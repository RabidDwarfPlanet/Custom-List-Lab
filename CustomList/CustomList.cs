using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        public int Count { get => count; }
        public int Capacity { get => capacity; }

        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;

        }

        //Member Methods (CAN DO)
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        private void IncreaseCapacity()
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] doubledItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    doubledItems[i] = items[i];
                }
                items = doubledItems;
            }
        }
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            IncreaseCapacity();
            items[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            for(int i = 0; i < count; i++)
            {
                
                if (EqualityComparer<T>.Default.Equals(item, items[i]))
                {
                    for (int j = i; j < count; j++)
                    {
                        
                        if(j == count - 1) { items[j] = default(T); }
                        else { items[j] = items[j + 1]; }
                    }
                    count--;
                    return true;
                }     
            }
            return false;
        }

        public override string ToString()
        {
            bool first = true;
            string list = "";
            //returns a single string that contains all items from array
            for(int i = 0; i < Count; i++)
            {
                if (!first) { list += ", "; }
                else { first = false; }
                list += $"{items[i]}";
            }
            return list;
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> combinedList = new CustomList<T>();
            for(int i = 0; i < firstList.Count; i++)
            {
                combinedList.Add(firstList[i]);
            }
            for(int i = 0; i < secondList.Count; i++)
            {
                combinedList.Add(secondList[i]);
            }

            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return combinedList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            CustomList<T> reducedList = new CustomList<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                reducedList.Add(firstList[i]);
            }
            CustomList<T> removeList = new CustomList<T>();
            for (int i = 0; i < secondList.Count; i++)
            {
                removeList.Add(secondList[i]);
            }
            for (int i = 0; i < reducedList.Count; i++)
            {
                foreach(T removeItem in removeList.items)
                {
                    if (EqualityComparer<T>.Default.Equals(reducedList[i], removeItem))
                    {
                        reducedList.Remove(reducedList[i]);
                        removeList.Remove(removeItem);
                        i--;
                        break;
                    }
                }
            }
            return reducedList;
        }

        public void Zip(CustomList<T> list)
        {
            CustomList<T> zippedList = new CustomList<T>();
            int i;
            for (i = 0; i < Count; i++)
            {
                zippedList.Add(items[i]);
                if (i < list.Count)
                {
                    zippedList.Add(list[i]);
                }
            }
            if (i >= Count && list.Count > Count)
            {
                for(int j = i; j < list.Count; j++)
                {
                    zippedList.Add(list[j]);
                }
            }

            count = zippedList.Count;
            capacity = zippedList.Capacity;
            items = zippedList.items;
        }

        public bool Contains(T item) 
        {
            foreach(T obj in items)
            {
                if(EqualityComparer<T>.Default.Equals(obj, item))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for(int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(T item)
        {
            int last = -1;
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, items[i]))
                {
                    last = i;
                }
            }
            return last;
        }

        public void TrimExcess()
        {
            if (capacity > 4)
            {
                if(count > 4) { capacity = count; }
                else { capacity = 4; }
            }

        }

        public void Clear()
        {
            items = new T[capacity];
            count = 0;
            TrimExcess();
        }

        public void Insert(int index, T item)
        {
            if(index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException();
            }
            IncreaseCapacity();
            T[] tempItems = new T[capacity];
            items.CopyTo(tempItems, 0);
            for (int j = index; j < count; j++)
            {
                items[j + 1] = tempItems[j];
            }
            items[index] = item;
            count++;
        }

        public T[] ToArray()
        {
            T[] array = new T[count];
            for(int i = 0; i < count; i++)
            {
                array[i] = items[i];
            }
            return array;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int j = index; j < count; j++)
            {
                if (j == Count - 1) { items[j] = default(T); }
                else { items[j] = items[j + 1]; }
            }
            count--;
        }

        public void Reverse()
        {
            T[] reversed = new T[capacity];
            int index = 0;
            for(int i = count - 1; i >= 0; i--)
            {
                reversed[index] = items[i];
                index++;
            }
            items = reversed;
        }
        public void Sort()
        {
            var sorting = new CustomList<T>();
            for(int i = 0; i < count; i++)
            {
                bool placed = false;
                if (i == 0) { sorting.Add(items[i]); }
                else
                {
                    foreach(T item in sorting)
                    {
                        if (Comparer.Default.Compare(items[i], item) < 0)
                        {
                            sorting.Insert(sorting.IndexOf(item), items[i]);
                            placed = true;
                            break;
                        }
                        
                    }
                    if (!placed)
                    {
                        sorting.Add(items[i]);
                    }
                }
            }
            items = sorting.items;
        }
    }
}
