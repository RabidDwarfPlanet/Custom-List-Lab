using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
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
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            if (count == capacity) 
            {
                capacity *= 2;
                T[]doubledItems = new T[capacity];
                int i = 0;
                foreach (T transferItem in items)
                {
                    doubledItems[i] = transferItem;
                    i++;
                }
                items = doubledItems;
            }
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
                        if(j == Capacity - 1) { items[j] = default(T); }
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


    }
}
