﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<int> a = new Element<int>(4);
            Element<int> b = new Element<int>(5);
            Element<int> c = new Element<int>(6);
            List<int> List = new List<int>();
            List.Addfirst(a);
            List.Addfirst(b);
            List.Addfirst(c);
            List.printList();
            Console.ReadKey();
        }
    }
}
