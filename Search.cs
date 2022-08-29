using System;
namespace Search
{
    public class Search
    {
        public int linearSearch(int[] arr, int n, int key)
        {
            int index = 0;
            while(index < n)
            {
                if (arr[index]== key)
                {
                    return index;
                }
                index = index + 1;
            }
            return -1;
        }
        public int binarySearch(int[]arr, int n, int key)
        {
            int left = 0;
            int right = n - 1;
             while(left < n)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    right = mid - 1;
                }
                else if(key > arr[mid])
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int n = 6;
            int key = 4;

            Search search = new Search();

            search.linearSearch(arr, n, key);
            search.binarySearch(arr, n, key);
        }
    }
}

