using System;

namespace OOP_Laba6
{
    abstract class Shape
    {
        abstract public void sort(ref int[] arr);
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
