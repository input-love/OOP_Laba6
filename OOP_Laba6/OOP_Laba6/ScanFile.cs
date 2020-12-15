using System;
using System.IO;

namespace OOP_Laba6
{
    class ScanFile
    {
        static public int[] scan_file(ref string name_file, int size)
        {
            if (File.Exists(@name_file))
            {
                string line;
                int[] arr = new int[size];
                using (StreamReader stream_reader = new StreamReader(@name_file))
                {
                    for (int i = 0; i < size; ++i)
                    {
                        if ((line = stream_reader.ReadLine()) == null)
                        {
                            throw new Exception("Недопустимое количество элементов в файле!");
                        }
                        else
                        {
                            arr[i] = Parser.parse(line);
                        }
                    }
                }
                return arr;
            }
            else
            {
                throw new Exception("Нет такого файла!");
            }
        }
    }
}
