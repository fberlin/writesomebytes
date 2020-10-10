using System;
using System.IO;

namespace writesomebytes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                bytes[i] = (byte)i;
            }

            File.WriteAllBytes("256bytes.txt", bytes);
        }
    }
}
