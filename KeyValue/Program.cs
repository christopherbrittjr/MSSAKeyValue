﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();

            try
            {
                Console.WriteLine(d["Cats"]);
            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            d["Cats"] = 42;
            d["Dogs"] = 17;
            
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}