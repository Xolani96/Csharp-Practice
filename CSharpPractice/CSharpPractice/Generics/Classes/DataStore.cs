using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class DataStore<T>
    {
        //Generic field , it cannot be initialized.
        public T Data { get; set; }
        //Generic Array
        public T[] dataArray = new T[5];
        public List<T> datalist = new List<T>();
    }
}