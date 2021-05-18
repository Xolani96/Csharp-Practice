using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice.Searching_Algorithms
{
    public class Searching
    {
        //Recursive Binary search Implementation
        public static int RecursiveBinarySearch(int[] array, int value)
        {
            return InternalRecursiveBinarySearch(0,array.Length);
            //this is a local function : are private methods of a type that are nested in another member. 
            int InternalRecursiveBinarySearch( int low , int high)
            {
                if (low >= high)
                    return -1;

                int mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;

                if (array[mid] < value)
                    return InternalRecursiveBinarySearch(mid + 1, high);
                return InternalRecursiveBinarySearch(low, mid);
            }
        }

        //Iterative Binary search Implementation
        public static int BinarySearch(int[] array, int value)
        {
            //define the boundaries
            int low = 0;
            int high = array.Length;

            while(low < high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == value) return mid;
                if (array[mid] < value) low = mid + 1; else high = mid;
            }
            return -1;
        }
    }
}
