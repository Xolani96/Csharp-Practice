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

        public void GenBubbleSort<T>(List<T> list) where T:IComparable
        {
            for (int i = 0; i < list.Count ; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if(list[i].CompareTo(list[i+1])<0)
                    {
                        Swap(list,i-1,i);
                    }
                }
            }
        }

        public void Swap<T>(List<T> source, int i, int j)
        {
            T temp = source[i];
            source[i] = source[j];
            source[j] = temp;
        }
    }
}
