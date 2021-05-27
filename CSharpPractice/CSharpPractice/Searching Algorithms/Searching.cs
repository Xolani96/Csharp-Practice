using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice.Searching_Algorithms
{
    public class Searching
    {
        private int[] Dataset;
        private int value;
        public Searching(int[] dataset, int value)
        {
            this.Dataset = dataset;
            this.value = value;
        }
        //Recursive Binary search Implementation
        public int RecursiveBinarySearch()
        {
            return InternalRecursiveBinarySearch(0, Dataset.Length);
            //this is a local function : are private methods of a type that are nested in another member. 
            int InternalRecursiveBinarySearch( int low , int high)
            {
                if (low >= high)
                    return -1;

                int mid = (low + high) / 2;
                if (Dataset[mid] == this.value)
                    return mid;

                if (Dataset[mid] < this.value)
                    return InternalRecursiveBinarySearch(mid + 1, high);
                return InternalRecursiveBinarySearch(low, mid);
            }
        }

        //Iterative Binary search Implementation
        public int BinarySearch()
        {
            //define the boundaries
            int low = 0;
            int high = Dataset.Length;

            while(low < high)
            {
                int mid = (low + high) / 2;
                if (Dataset[mid] == this.value) return mid;
                if (Dataset[mid] < this.value) low = mid + 1; else high = mid;
            }
            return -1;
        }
    }
}
