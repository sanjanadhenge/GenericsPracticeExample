using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //int[] IntArray = { 1, 5, 8, 9, 6, 3, 4 };
            //double[] DoubleArray = { 1.1, 5.7, 9.8, 5.6 };
            //char[] CharArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
            //DeleteArray deleteArray = new DeleteArray();
            //deleteArray.Delete();
            //DeleteArray<int> deleteArray = new DeleteArray<int>(IntArray);
            //deleteArray.DeleteUsingGenerics(5);
            //DeleteArray<double> deleteArray1 = new DeleteArray<double>(DoubleArray);
            //deleteArray1.DeleteUsingGenerics(9.8);
            //DeleteArray<char> deleteArray2 = new DeleteArray<char>(CharArray);
            //deleteArray2.DeleteUsingGenerics('d');
            // FindMinimum findMinimum = new FindMinimum();
            //findMinimum.FindMinInt();
            //findMinimum.FindMinFloat();
            // findMinimum.FindMinString();
            //findMinimum.FindMin<int>(50, 100, 150);
            //findMinimum.FindMin<double>(5.2f, 9.8f, 1.50f);
            //findMinimum.FindMin<string>("Apple","Mango","Banana");
            FindMinimum<int> findMinimum1 = new FindMinimum<int>(10, 1000, 100);
            findMinimum1.FindMin();
            FindMinimum<double> findMinimum2 = new FindMinimum<double>(15.9f, 12.2f, 5.25f);
            findMinimum2.FindMin();
            FindMinimum<string> findMinimum3 = new FindMinimum<string>("Peach", "Apple", "Banana");
            findMinimum3.FindMin();

        }
    }
}