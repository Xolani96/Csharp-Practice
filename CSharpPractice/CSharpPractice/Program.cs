using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Self Practise
            //ReturnData<int> displayInt = new ReturnData<int>();
            //displayInt.Show(123);

            //ReturnData<double> displayDouble = new ReturnData<double>();
            //displayDouble.Show(123.35425);

            //ReturnData<string> displayString = new ReturnData<string>();
            //displayString.Show("Jesus Christ");

            //ReturnData<char> displayChar = new ReturnData<char>();
            //displayChar.Show('J');

            //store values inside a Int list
            DataStore<int> intStoreInList = new DataStore<int>();
            intStoreInList.datalist.Add(12);
            intStoreInList.datalist.Add(2);
            intStoreInList.datalist.Add(4);
            intStoreInList.datalist.Add(1);
            intStoreInList.datalist.Add(15);
            intStoreInList.datalist.Add(16);
            intStoreInList.datalist.Add(7);

            //store values inside an array
            //numbers
            DataStore<int> intStoreInArray = new DataStore<int>();
            int[] numbers = new int[] { 65, 2, 45, 1, 34, };
            Array.Copy(numbers, intStoreInArray.dataArray, intStoreInArray.dataArray.Length);
            SortData<int> srt = new SortData<int>();
            srt.InsertionSort(intStoreInArray.dataArray);
            ReturnData<int> returnArray = new ReturnData<int>();
            returnArray.DisplayArray(intStoreInArray.dataArray, intStoreInArray.dataArray.Length);

            //Letters
            //DataStore<char> strStoreInArray = new DataStore<char>();
            //char[] letter = new char[] { 'e', 'u', 'l', 'f', 'h' };
            //Array.Copy(letter, strStoreInArray.dataArray, strStoreInArray.dataArray.Length);
            //SortData<int> srt1 = new SortData<int>();
            //srt1.GenBubbleSort(strStoreInArray.dataArray);
            //ReturnData<char> returnArray1 = new ReturnData<char>();
            //returnArray1.DisplayArray(strStoreInArray.dataArray, strStoreInArray.dataArray.Length);

            //DataStore<string> strStoreInList = new DataStore<string>();
            //strStoreInList.datalist.Add("Xolani");
            //strStoreInList.datalist.Add("Ziyanda");
            //strStoreInList.datalist.Add("Mom");
            //strStoreInList.datalist.Add("Simphiwe");
            //strStoreInList.datalist.Add("Dad");

            ////sort the given data
            //SortData<string> srt2 = new SortData<string>();
            ////display the stored data
            //ReturnData<string> retListStr = new ReturnData<string>();
            //retListStr.DisplayList(srt2.SortList(strStoreInList.datalist));

            


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
}
