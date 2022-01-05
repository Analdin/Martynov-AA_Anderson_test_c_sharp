using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martynov_AA_Anderson_test_c_sharp.Number
{
    public class NumberSeven
    {
        /// <summary>
        /// Проверяем введенное число на соответствие условиям задачи
        /// </summary>
        public void JobWithNumbers()
        {
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (num >= 7)
                {
                    Console.WriteLine("Привет");
                    break;
                }
                else if(num <= 7)
                {
                    Console.WriteLine("Число меньше 7, повторите ввод... или напечатайте '0', чтобы выйти с задачи...");

                    if(num == 0)
                    {
                        Console.WriteLine("Завершаем задание...");
                        break;
                    }

                    num = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
