using System;
using System.IO;

namespace OOP_Laba6
{
    class PrintFile
    {
        static public void print_file(ref int[] arr)
        {
            string path = @"result.txt";
            using (StreamWriter fout = new StreamWriter(path, false))
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    fout.Write($"{arr[i]}\n");
                }
            }
        }
    }
}
