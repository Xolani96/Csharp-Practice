using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class SortData<T>
    {
        //how to sort generic types
        public List<T> SortList(List<T> li)
        {
            li.Sort();
            List<T> temp = new List<T>();
            foreach (var item in li)
            {
                temp.Add(item);
            }
            return temp;
        }

        public void GenBubbleSort<T>(T[] array) where T:IComparable
        {
            for (int i = array.Length; i>1; i--)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if(array[j].CompareTo(array[j+1])>0)
                    {
                        GenSwap(array, j,j+1);
                    }
                }
            }
        }
        public void InsertionSort(int[] array)
        {
            //Problem: it skips the first value and sorts the rest of the values,
            int j,key, i;
            for (i = 0; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;
                while (j>0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        public void GenSwap<T>(T[] source, int i, int j)
        {
            T temp = source[i];
            source[i] = source[j];
            source[j] = temp;
        }
       
    }
}
