﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeExample
{
    internal class DeleteArray<T> where T : IComparable
    {
        T[] array;
       public DeleteArray(T[] array)
        { 
            this.array = array;
        }
        public void DeleteUsingGenerics(T search) 
        {
            T [] arr1 = new T[10];
            int k = 0;
            int flag = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(search) >0 || array[i].CompareTo(search) < 0)
                {
                    arr1[k] = array[i];
                      k++;
                }
                //if(flag == 0)
                //{
                //    arr1[k] = array[i];
                //    k++;
                //}
            }
            array = arr1;
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        //public void Delete()
        //{
        //    bool flag = true;
        //    while (flag)
        //    {
        //        Console.WriteLine("Select Array to delete Element \n 1. IntArray \n 2. FloatArray \n 3. CharArray \n 4. Exit ");
        //        int option = Convert.ToInt32(Console.ReadLine());
        //        switch (option)
        //        {
        //            case 1: //DeleteInteger();
        //                Console.WriteLine("Enter the element you want to delete");
        //                int search = Convert.ToInt32(Console.ReadLine());
        //                DeleteUsingGenerics<int>(array, search);
        //                break;
        //            case 2: //DeleteDouble();
        //                Console.WriteLine("Enter the element you want to delete");
        //                double search1 = Convert.ToDouble(Console.ReadLine());
        //                DeleteUsingGenerics<double>(DoubleArray, search1);
        //                break;
        //            case 3:// DeleteChar();
        //                Console.WriteLine("Enter the element you want to delete");
        //                char search2 = Convert.ToChar(Console.ReadLine());
        //                DeleteUsingGenerics<char>(CharArray, search2);
        //                break;
        //            default:
        //                flag = false;
        //                break;
        //        }
        //    }

        //}
        //public void DeleteInteger()
        //{
        //    int[] arr= new int[10];
        //    int k = 0;
        //    Console.WriteLine("Enter the element you want to delete");
        //    int search = Convert.ToInt32(Console.ReadLine());
        //    for(int i =0;i < IntArray.Length;i++)
        //    {
        //        if (IntArray[i] != search)
        //        {
        //            arr[k]= IntArray[i];
        //            k++;
        //        }
        //    }
        //    IntArray= arr;
        //    for (int i = 0; i < k; i++)
        //    {
        //        Console.WriteLine(IntArray[i]);
        //    }
        //}
        //public void DeleteDouble()
        //{
        //    double[] arr = new double[10];
        //    int k = 0;
        //    Console.WriteLine("Enter the element you want to delete");
        //    double search = Convert.ToDouble(Console.ReadLine());
        //    for (int i = 0; i < DoubleArray.Length; i++)
        //    {
        //        if (DoubleArray[i] != search)
        //        {
        //            arr[k] = DoubleArray[i];
        //            k++;
        //        }
        //    }
        //    DoubleArray = arr;
        //    for (int i = 0; i < k; i++)
        //    {
        //        Console.WriteLine(DoubleArray[i]);
        //    }

        //}
        //public void DeleteChar()
        //{
        //    char[] arr = new char[10];
        //    int k = 0;
        //    Console.WriteLine("Enter the element you want to delete");
        //    char search = Convert.ToChar(Console.ReadLine());
        //    for (int i = 0; i < CharArray.Length; i++)
        //    {
        //        if (CharArray[i] != search)
        //        {
        //            arr[k] = CharArray[i];
        //            k++;
        //        }
        //    }
        //    CharArray = arr;
        //    for (int i = 0; i < k; i++)
        //    {
        //        Console.WriteLine(CharArray[i]);
        //    }
        //}
    }
}
