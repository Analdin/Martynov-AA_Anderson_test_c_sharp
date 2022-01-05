using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martynov_AA_Anderson_test_c_sharp.Name
{
    public class CheckName
    {
        public void JobWithName()
        {
            Console.WriteLine("Введите имя:");
            string name = Convert.ToString(Console.ReadLine()).Trim();

            name.Trim();

            if (name == "Вячеслав")
            {
                Console.WriteLine("Привет, Вячеслав");
            }
            else if (name != "Вячеслав")
            {
                Console.WriteLine("Нет такого имени, повторите ввод...");

                if (name == "Вячеслав")
                {
                    Console.WriteLine("Привет, Вячеслав");
                }

                name = Convert.ToString(Console.ReadLine()).Trim();
            }
        }
    }
}
