﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeExample
{
    internal class FindMinimum
    {
        public void FindMinInt()
        {
            Console.WriteLine("Enter 1st Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0 || a.CompareTo(b) <= 0 && a.CompareTo(c) < 0 || a.CompareTo(b) < 0 && a.CompareTo(c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", a);
            }
            if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0 || b.CompareTo(a) <= 0 && b.CompareTo(c) < 0 || b.CompareTo(a) < 0 && b.CompareTo(c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", b);
            }
            if (c.CompareTo(a) < 0 && c.CompareTo(b) < 0 || c.CompareTo(a) <= 0 && c.CompareTo(b) < 0 || c.CompareTo(a) < 0 && c.CompareTo(b) <= 0)
            {
                Console.WriteLine("{0} is Minimum", c);
            }


        }
    }
}