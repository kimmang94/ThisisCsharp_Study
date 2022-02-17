﻿using System;

namespace Hello
{
    
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            Console.WriteLine("Hello, {0}", args[0]);
        }
    }
}
