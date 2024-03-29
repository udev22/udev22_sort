﻿using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Binary_Insertion_Sort_2_Iterativ_Namespace
{
	class Binary_Insertion_Sort_2_Iterativ_Class
	{
        // iterative implementation
        static int binarySearch(int[] a, int item, int low, int high)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (item == a[mid])
                    return mid + 1;
                else if (item > a[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return low;
        }

        // Function to sort an array a[] of size 'n'
        public static void insertionSort(int[] a, int n)
        {
            int i, loc, j, selected;

            for (i = 1; i < n; ++i)
            {
                j = i - 1;
                selected = a[i];

                // find location where selected should be inseretd
                loc = binarySearch(a, selected, 0, j);

                // Move all elements after location to create space
                while (j >= loc)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = selected;
            }
        }
    }
}

// This code is contributed by udev22