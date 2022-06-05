using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27_Array_Move
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4};
            int valueShift = int.Parse(Console.ReadLine());

            for (int i = 0; i < valueShift; i++)
            {
                for (int j = array.Length - 2; j > -1; j--)
                {
                    int tempNumber = array[j+1];
                    array[j+1] = array[j];
                    array[j] = tempNumber;
                }
            } 

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
