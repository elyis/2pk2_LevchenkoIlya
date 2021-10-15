using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание массива пользователя
            Console.WriteLine("Введите количество строк таблицы");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов таблицы");
            int m = Convert.ToInt32(Console.ReadLine());

            if (n <= 0 || m <= 0)
            {
                Console.WriteLine("Ошибка: Матрица не может быть построена по входным данным: [" + n + ";" + m + "]");
                return;
            }
              

            //Создание границ генерации значений матрицы
            Console.WriteLine("Введите левую (меньшую) границу генерации матрицы");
            int borderDown = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите правую (большую) границу генерации матрицы");
            int borderUp = Convert.ToInt32(Console.ReadLine());

            if(borderUp < borderDown)
            {
                Console.WriteLine("Ошибка: Указан неверный диапазон генерации чисел: [" + borderDown + ";" + borderUp + "]");
                return;
            }

            int[,] nums = new int[n, m];
            Random rnd = new Random();

            //Минимальное значение каждого столбца
            int[] nums_min_of_column = new int[m];
            for (int i = 0; i < m; i++)
                nums_min_of_column[i] = borderUp;

            for(int i = 0;i < n;i++)
            {
                for(int j = 0,iter_nums_min = 0; j < m;j++,iter_nums_min++)
                {
                    nums[i, j] = rnd.Next(borderDown,borderUp);
                    Console.Write(nums[i, j] + " ");
                    if (nums[i, j] < nums_min_of_column[iter_nums_min])
                        nums_min_of_column[iter_nums_min] = nums[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Минимальные значения в каждом столбце:");
            for (int i = 0; i < m; i++)
                Console.Write(nums_min_of_column[i] + "  ");
            Console.WriteLine();

            Array.Sort(nums_min_of_column);
            Console.Write("Максимальное значение среди минимальных значений столбцов = " + nums_min_of_column[m - 1]);
        }
    }
}
