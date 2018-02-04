﻿using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        using (var source = new FileStream("copyMe.png", FileMode.Open))
        {
            using (var destination = new FileStream("copy.png", FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                        break;
                    destination.Write(buffer, 0, readBytes);
                }
            }
        }

    }
}
