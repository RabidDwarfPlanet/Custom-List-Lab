﻿using System;
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
            //returns a single string that contains all items from array
            return "";
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
