using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Martynov_AA_Anderson_test_c_sharp.Number;

namespace MainMenu
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Меню (проверить):\n1) Цифру 7 \n2) Имя \n3) Массив \n\nНажмите нужную цифру (1-3): ");

            i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("Проверяем цифру 7...");

                    NumberSeven numberSeven = new NumberSeven();
                    numberSeven.JobWithNumbers();

                    break;
                case 2:
                    Console.WriteLine("Проверяем имя...");
                    break;
                case 3:
                    Console.WriteLine("Проверяем массив...");
                    break;
                default:
                    Console.WriteLine("Нажато что-то другое...");
                    break;
            }
            Console.WriteLine("\nНажмите любую клавишу:");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
