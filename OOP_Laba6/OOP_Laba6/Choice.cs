﻿using System;

namespace OOP_Laba6
{
    class Choice : Shape
    {
        public override void sort(ref int[] arr, int size)
        {
            for (int i = 0; i < size - 1; ++i)
            {
                int i_min = i;
                for (int j = i + 1; j < size; ++j)
                {
                    if (arr[j] < arr[i_min])
                    {
                        i_min = j;
                    }
                }
                swap(ref arr[i], ref arr[i_min]);
            }
        }
    }
}
