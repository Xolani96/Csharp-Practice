using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ReturnData<T>
    {
        public void DisplayArray(T[] initArray, int arrLenght)
        {
            for (int i = 0; i < initArray.Length; i++)
            {
                if (!(initArray[i] == null))
                {
                    Console.WriteLine(initArray[i]);
                }
            }
        }
        public void DisplayList(List<T> initList)
        {
            foreach (var item in initList)
            {
                Console.WriteLine(item);
            }
        }
        public void Show(T value)
        {
            Console.WriteLine(value);
        }
    }
}
