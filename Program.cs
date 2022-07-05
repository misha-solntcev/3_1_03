using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 3
В одномерном массиве, состоящем из n вещественных элементов, вычислить:
 минимальный элемент массива;
 сумму элементов массива, расположенных между первым и последним положительными элементами. */

namespace _3_1_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[] { -1, 2, -3, 4, 5, -6, 7, 8, -9 };

            // Минимальный элемент массива:
            double min = nums[0];
            foreach (double num in nums)
                if (num < min)
                    min = num;
            Console.WriteLine($"min = {min}");

            // Первый положительный элемент:
            int first = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                {
                    first = i;
                    break;
                }
            Console.WriteLine($"first = {first}");

            // Последний положительный элемент:
            int last = first;
            for (int i = first ; i < nums.Length; i++)
                if (nums[i] > 0)
                    last = i;
            Console.WriteLine($"last = {last}");

            // Сумма
            double sum = 0;
            for (int i = first + 1; i < last; i++)
                sum += nums[i];
            Console.WriteLine($"sum = {sum}");

            Console.ReadKey();
        }
    }
}
