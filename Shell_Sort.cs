﻿using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Shell_Sort_Namespace
{
    class Shell_Sort_Class
    {
        public static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        public static void show_array_elements(int[] arr)
        {
            foreach (var element in arr)
            {
                Write(element + " ");
            }
            Write("\n");
        }
    }
}
