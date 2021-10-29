using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] cstrs = new string[9][];
            string[] last_elems_of_cstrs = new string[9];
            string[] max_strs = new string[9];
            string[] max_str_of_length = new string[9];
            Random rnd = new Random();
            
            for(int i = 0;i < 9;i++)
            {

                cstrs[i] = new string[rnd.Next(7, 15)];
                Console.WriteLine("Введите любой символ");
                int iter = 0;

                try
                {
                    char temp_ch = Convert.ToChar(Console.ReadLine());
                    int sum_code_elems_of_str = 0;
                    int max_length_str = 0;
                    

                    for (int j = 0; j < cstrs[i].Length; j++)
                    {
                        //Строка получает первый символ из ввода пользователя
                        cstrs[i][j] = Convert.ToString(temp_ch);

                        //Заполнение строки рандомным количеством рандомных символов
                        for (int k = 0; k < rnd.Next(1, 10); k++)
                        {
                            char ch = Convert.ToChar(rnd.Next(1, 1000));
                            cstrs[i][j] += Convert.ToString(ch);
                        }

                        //Определение строки максимального размера кодировки символов
                        int temp_sum_code = Max_str(cstrs[i][j]);
                        if (sum_code_elems_of_str < temp_sum_code)
                        {
                            sum_code_elems_of_str = temp_sum_code;
                            max_strs[i] = cstrs[i][j];
                        }

                        //Определение строки с большим количеством символов
                        if(max_length_str < cstrs[i][j].Length)
                        {
                            max_length_str = cstrs[i][j].Length;
                            max_str_of_length[i] = cstrs[i][j];
                            iter = j;
                        }    

                        Console.Write(cstrs[i][j] + "   ");

                    }
                    last_elems_of_cstrs[i] = cstrs[i][cstrs[i].Length - 1];

                }
                catch(System.FormatException e )
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
                Console.WriteLine("Last element:  " + last_elems_of_cstrs[i]);
                Console.WriteLine("Max element of code symvols :  " + max_strs[i]);
                Console.WriteLine("Max length str is :  " + max_str_of_length[i]);

                //Swap values of strs
                string temp = cstrs[i][0];
                cstrs[i][0] = cstrs[i][iter];
                cstrs[i][iter] = temp;

                Console.WriteLine("Измененный массив:");
                for(int j = 0;j < cstrs[i].Length;j++)
                    Console.Write(cstrs[i][j] + "   ");
                Console.WriteLine();

            }
        }

        public static int Max_str(string str)
        {
            int sum_code_elems_of_str = 0;
            for(int i = 0;i < str.Length;i++)
            {
                char ch = str[i];
                sum_code_elems_of_str += ch;
            }
            
            return sum_code_elems_of_str;
        }

    }
}
