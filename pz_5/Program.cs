using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Ex 1:");
            Console.WriteLine("Вывести построчно целые в диапазоне [-25;25;25]");

            //цикл здесь не нужен, т.к простые вычисления, которые можно вручную сделать
            int i = -25;
            for (; i <= 25; i += 25)
                Console.WriteLine(i);
            */

            /*
            Console.WriteLine("Ex 2:");
            Console.WriteLine("От P 5 чисел");

            char ch = 'P';
            int int_next_ch = Convert.ToInt32(ch);
            for(int i = 0;i <= 5;i++)
            {
                Console.Write(ch);
                int_next_ch += 1;
                ch = Convert.ToChar(int_next_ch);
            }
            */

            /*
            Console.WriteLine("Ex 3");
            Console.WriteLine("4 # в 7 строках");

            for(int i = 0; i < 7;i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write("#");
                Console.WriteLine();
            }
            */

            /*
            Console.WriteLine("Ex 4");
            Console.WriteLine("[0;100] % 2");

            short current_inc = 1;
            for(int i = 0;i < 100;)
            {
                if (i % 2 == 0)
                {
                    current_inc = 2;
                    for (; i < 100; i += current_inc)
                        Console.WriteLine(i);
                }

                else
                    i += current_inc;
            }
            */

            /*
            Console.WriteLine("Ex 5:");
            Console.WriteLine("3 и 50, разница 17");

            int i;
            int j;
            for(i = 3, j = 50; (j - i) != 17 ; i++, j--)
                Console.WriteLine("ïncr = " + i + " dect = " + j);
            */
        }
    }
}
