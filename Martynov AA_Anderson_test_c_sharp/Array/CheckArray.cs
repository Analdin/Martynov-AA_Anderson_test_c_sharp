using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martynov_AA_Anderson_test_c_sharp.Array
{
    public class CheckArray
    {
        /// <summary>
        /// Проверяем числа массива на кратность 3
        /// </summary>
        public void JobWithArray()
        {
            Console.WriteLine("Выберите размер массива:");

            int i = int.Parse(Console.ReadLine());

            int[,] array = new int [i,i];
            Random rnd = new Random();

            for(int j = 0;j< i; j++)
            {
                for(int k = 0;k< i; k++)
                {
                    array[j, k] = rnd.Next(-120, 120);
                    Console.WriteLine("{0}\t", array[j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Введите число:");

            int m = Int32.Parse(Console.ReadLine());
            var mm = array.Cast<int>().Where(j => j % m == 0).ToArray();

            foreach(var v in mm)
            {
                Console.WriteLine(v + "\t");
            }

            Console.ReadKey();
        }
    }
}
