using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Self Practise
            //Display<int> displayInt = new Display<int>();
            //displayInt.Show(123);

            //Display<double> displayDouble = new Display<double>();
            //displayDouble.Show(123.35425);

            //Display<string> displayString = new Display<string>();
            //displayString.Show("Jesus Christ");

            //Display<char> displayChar = new Display<char>();
            //displayChar.Show('J');

            //store values inside a list
            DataStore<int> intStoreInList = new DataStore<int>();
            
            intStoreInList.datalist.Add(12);
            intStoreInList.datalist.Add(2);
            intStoreInList.datalist.Add(4);
            intStoreInList.datalist.Add(1);
            intStoreInList.datalist.Add(15);
            intStoreInList.datalist.Add(16);
            intStoreInList.datalist.Add(7);

            SortData<int> srt = new SortData<int>();
            ReturnData<int> retList = new ReturnData<int>();
            retList.DisplayList(srt.SortList(intStoreInList.datalist));


            #endregion
            #region Article Practise
           
            //DataStore<string> strStoreInArray = new DataStore<string>();
            //strStoreInArray.Data = "some data";
            ////copy values from 1 array to another 
            //string[] dataValues = new string[5] { "one", "Two", "Three", "Four", "Five" };
            //Array.Copy(dataValues, 0, strStoreInArray.dataArray, 0, strStoreInArray.dataArray.Length);

            //ReturnData<string> retArray = new ReturnData<string>();
            //retArray.DisplayArray(strStoreInArray.dataArray, strStoreInArray.dataArray.Length);


            //DataStore<int> intStore = new DataStore<int>();
            //intStore.Data = 123;

            //KeyValuPair<int, string> intStrPair = new KeyValuPair<int, string>();
            //intStrPair.Key = 1;
            //intStrPair.Value = "Xolani";

            //KeyValuPair<string, double> strDblPair = new KeyValuPair<string, double>();
            //strDblPair.Key = "Salary";
            //strDblPair.Value = 4325;

            #endregion
            Console.ReadLine();
        }
    }
    #region SelfPractise
    class Display<T>
    {
        public void Show(T value)
        {
            Console.WriteLine(value);
        }
    }
    #endregion
    #region Article Practise
    class DataStore<T>
    {
        //Generic field , it cannot be initialized.
        public T Data { get; set; }
        //Generic Array
        public T[] dataArray = new T[5];
        public List<T> datalist = new List<T>();
    }

    class ReturnData<T>
    {
        public void DisplayArray(T[] initArray, int arrLenght)
        {
            for (int i = 0; i < initArray.Length; i++)
            {
                if(!(initArray[i] == null))
                {
                    Console.WriteLine(initArray[i]);
                }
            }
        }
        public void DisplayList( List<T> initList)
        {
            foreach (var item in initList)
            {
                Console.WriteLine(item);
            }
        }
    }
    class SortData<T>
    {
        //how to sort generic types
       public List<T> SortList(List<T> li)
        {
            //List<T> temp = new List<T>();
            //for (int i = 0; i < li.Count; i++)
            //{
            //    for (int j = 0; j < li.Count; j++)
            //    {
            //        if (Comparison(li[i], li[j]) < 0)
            //        {

            //        }
            //    }
            //}
            li.Sort();
            List<T> temp = new List<T>();
            foreach (var item in li)
            {
                temp.Add(item);
            }
            return temp;
        }
    }
    class KeyValuPair<Tkey,Tvalue>
    {
        //Generic field , it cannot be initialized.
        public Tkey Key { get; set; }
        //Generic field , it cannot be initialized.
        public Tvalue Value { get; set; } 
    }
    #endregion
}
